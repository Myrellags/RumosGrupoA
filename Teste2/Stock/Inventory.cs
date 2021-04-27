using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock
{
    public class Inventory
    {
        #region "PROPRIEDADES INVENTORY"
        public int InventoryID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }
        public string ProductDescription { get; set; }
        public string NameInventor { get; set; }
        public int NewQuantity { get; set; }

      
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
