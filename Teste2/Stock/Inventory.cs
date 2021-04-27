using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock
{
    public class Inventory
    {
        #region "PROPRIEDADES INVENTORY"
        public int InventoryID { get; set; }
        public int ProductID { get; set; }
        public int WarehouseID { get; set; }
        public string ProductDescription { get; set; }
        public string NameInventor { get; set; }
        public int NewQuantity { get; set; }

        public List<Stock.Product> Products { get; set; }
        public List<Stock.Warehouse> Warehouses { get; set; }

        public Product Product
        {
            get => default;
            set
            {
            }
        }


        #endregion

        #region "CONTRUTORES INVENTORY"
        public Inventory()
        {

        }
        public Inventory(int idinventory, int idProduct, int idWarehouse, string productDescription, string nameInventory,int newQuantity)
        {
            InventoryID = idinventory;
            ProductID = idProduct;
            WarehouseID = idWarehouse;
            ProductDescription = productDescription;
            NameInventor = nameInventory;
            NewQuantity = newQuantity;
        }
        #endregion

    }
}
