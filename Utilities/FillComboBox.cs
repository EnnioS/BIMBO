using Entities.DTO;
using Entities.Data;
using Presentacion.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Presentacion.Utilities
{
    public static class FillComboBox
    {

        private static BimDb1Context _db1 = new BimDb1Context();
        //Metodos Personalizados
        public static void LlenarComboBoxProveedores(CustomerComboBox cBox, List<ProviderDTO> providers)
        {
            try
            {
                //Comsulta para recuperar todos los proveedores
                var proveedoresObj = _db1.Providers.ToList();
                var count = proveedoresObj.Count();
                int i = 0;
                while (count > i)
                {
                    //Llenando lista de ProviderDTO
                    providers.Add(new ProviderDTO()
                    {
                        Id = proveedoresObj[i].Id.Trim(),
                        Name = proveedoresObj[i].Id.Trim() + " - " + proveedoresObj[i].Name.Trim()
                    });
                    i++;
                }

                //Agregando lista a combobox Proveedor
                cBox.DataSource = providers;
                cBox.DisplayMember = "Name";
                cBox.ValueMember = "Id";
                cBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                cBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema FCBU-001: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        public static void LlenarComboBoxProductos(CustomerComboBox cBox, List<ProductDTO> products)
        {
            try
            {

                //Comsulta para recuperar todos los proveedores
                var proveedoresObj = _db1.Rawmaterials.ToList();
                var count = proveedoresObj.Count();
                int i = 0;
                while (count > i)
                {
                    //Llenando lista de ProviderDTO
                    products.Add(new ProductDTO()
                    {
                        Id = proveedoresObj[i].Id.Trim(),
                        CodeName = proveedoresObj[i].Id.Trim() + " - " + proveedoresObj[i].Description.Trim()
                    });
                    i++;
                }

                //Agregando Lista a  combobox Productos
                cBox.DataSource = products;
                cBox.DisplayMember = "CodeName";
                cBox.ValueMember = "Id";
                cBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                cBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error del sistema FCBU-02: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }





        public static void FillListViewOfProductByProductDescriptionManyToMany(bool option, string searchWord, ListView listViewMateriaPrima)
        {
            try
            {

                List<ProviderProductDTO> ProveedorJoinProducto = new List<ProviderProductDTO>();
                var productCount = 0;

                if (option)
                {

                    //Query EF (Where Like "text%") odenado de manera acendente

                    ProveedorJoinProducto = (from prov in _db1.Providers
                                             join provProd in _db1.ProvidersRawmaterials on prov.Id equals provProd.ProviderId
                                             join prod in _db1.Rawmaterials on provProd.RawmaterialId equals prod.Id
                                             where prod.Description.StartsWith(searchWord)
                                             select new ProviderProductDTO
                                             {
                                                 ProductId = prod.Id,
                                                 ProductName = prod.Description,
                                                 ProviderName = prov.Name,
                                                 ProviderIsActive = prov.Acrive
                                             }).ToList();
                }
                else if (!option)
                {
                    //Query EF (Where Like "text%") odenado de manera acendente
                    ProveedorJoinProducto = (from prov in _db1.Providers
                                             join provProd in _db1.ProvidersRawmaterials on prov.Id equals provProd.ProviderId
                                             join prod in _db1.Rawmaterials on provProd.RawmaterialId equals prod.Id
                                             where prod.Id.StartsWith(searchWord)
                                             select new ProviderProductDTO
                                             {
                                                 ProductId = prod.Id,
                                                 ProductName = prod.Description,
                                                 ProviderName = prov.Name,
                                                 ProviderIsActive = prov.Acrive
                                             }).ToList();//recuperando registro de usuarios
                }


                productCount = ProveedorJoinProducto.Count();// contando cantidad de registro en tabla

                listViewMateriaPrima.Items.Clear();



                for (var i = 0; i < productCount; i++)
                {

                    ListViewItem providerItem = new ListViewItem(ProveedorJoinProducto[i].ProductId.Trim());

                    //Agregando datos a la lista
                    providerItem.SubItems.Add(ProveedorJoinProducto[i].ProductName.Trim());
                    providerItem.SubItems.Add(ProveedorJoinProducto[i].ProviderName.Trim());
                    if (Convert.ToBoolean(ProveedorJoinProducto[i].ProviderIsActive) == true)
                    {

                        providerItem.SubItems.Add("Activo");
                    }
                    else
                    {
                        providerItem.SubItems.Add("Inactivo");
                    }

                    //Agregando lista al componente listview
                    listViewMateriaPrima.Items.Add(providerItem);

                }
                
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema FCBU-004: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void FillComboBoxOfProductByProductDescriptionManyToMany(string providerId, CustomerComboBox cbxProducto)
        {
            try
            {
                var productCount = 0;
                List<ProductDTO> products = new List<ProductDTO>();

                var productsList = (from prov in _db1.Providers
                                    join provProd in _db1.ProvidersRawmaterials on prov.Id equals provProd.ProviderId
                                    join prod in _db1.Rawmaterials on provProd.RawmaterialId equals prod.Id
                                    where prov.Id == providerId
                                    select new ProductDTO
                                    {
                                        Id = prod.Id,
                                        CodeName = prod.Id + " - " + prod.Description
                                    }).ToList();//recuperando registro de usuarios

                productCount = productsList.Count();
                int i = 0;
                while (productCount > i)
                {
                    //Llenando lista de ProviderDTO
                    products.Add(new ProductDTO()
                    {
                        Id = productsList[i].Id,
                        CodeName = productsList[i].CodeName
                    });
                    i++;
                }

                //Agregando Lista a  combobox Productos
                cbxProducto.DataSource = products;
                cbxProducto.DisplayMember = "CodeName";
                cbxProducto.ValueMember = "Id";
                cbxProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
                cbxProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            } 
            catch (Exception ex) 
            {
                MessageBox.Show("Error del sistema FCBU-005: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        public static void FillComboBoxPlateByProvider(string providerId, CustomerComboBox cbxPlate)
        {


            try
            {
                List<Plate> Plate = new List<Plate>();
                //Llenar combobox de cbPlates
                var Placas = _db1.Plates.Where(pid => pid.ProviderId == providerId).Select(pid => pid.LicensePlaateNumber.Trim()).ToList();
                //Agregando lista a combobox Plates

                if (Placas.Count > 0)
                {
                    cbxPlate.DataSource = Placas;
                    cbxPlate.DisplayMember = "LicensePlaateNumber";
                    //cbxPlate.ValueMember = "Id";
                    cbxPlate.AutoCompleteMode = AutoCompleteMode.Suggest;
                    cbxPlate.AutoCompleteSource = AutoCompleteSource.ListItems;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema FCBU-006: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}

