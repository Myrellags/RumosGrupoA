using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock

{
    [Table("Inventorys")]
    public class Inventory
    {
        #region "PROPRIEDADES INVENTORY"
        [Key]
        public int InventoryID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        // public virtual Product Products { get; set; }
        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }
        // public virtual Warehouse Warehouses { get; set; }
        public string ProductDescription { get; set; }
        [Required]
        [StringLength(60)]
        public string NameInventory { get; set; }
        [Required] 
        public int NewQuantity { get; set; }

        public virtual ICollection<Stock.Product> Products { get; set; }
        //public List<Stock.Product> Products { get; set; }

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
            NameInventory = nameInventory;
            NewQuantity = newQuantity;
        }
        #endregion

    }
}
