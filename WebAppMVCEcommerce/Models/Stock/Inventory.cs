using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCEcommerce.Models.Stock
{
    [Table("Inventorys")]
    public class Inventory
    {
        #region "PROPRIEDADES INVENTORY"
        [Key]
        public int InventoryID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public string ProductDescription { get; set; }
        [Required]
        [StringLength(60)]
        public string NameInventory { get; set; }
        [Required]
        public int NewQuantity { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        #endregion

        #region "CONTRUTORES INVENTORY"
        public Inventory()
        {

        }
        public Inventory(int idinventory, int idProduct, int idWarehouse, string productDescription, string nameInventory, int newQuantity)
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
