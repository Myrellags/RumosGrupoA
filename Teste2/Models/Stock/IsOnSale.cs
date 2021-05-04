using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock
{
    [Table("IsOnSales")]
    public class IsOnSale
    {
        #region "Propriedades"
        [Key]
        public int IsOnSaleID { get; set; }
        [ForeignKey("Product")]
        // public virtual Product Products { get; set; }
        public int ProductID { get; set; }
        [ForeignKey("Warehouse")]
        // public virtual Warehouse Warehouses { get; set; }
        public int WarehouseID { get; set; }
        [Required] 
        public double CostProduct { get; set; }
        [Required] 
        public double ValueSalePercent { get; set; }

        public virtual ICollection<Stock.Product> Products { get; set; }
        //public List<Stock.Warehouse> Warehouses { get; set; }

        public Product Product
        {
            get => default;
            set
            {
            }
        }

        #endregion

        #region "Construtores"
        public IsOnSale()
        {

        }
        public IsOnSale(int idIsOnSale, int idProduct, int idWarehouse, double costProduct,
            double valueSalePercent)
        {
            IsOnSaleID = idIsOnSale;
            ProductID = idProduct;
            WarehouseID = idWarehouse;
            CostProduct = costProduct;
            ValueSalePercent = valueSalePercent;
        }
        #endregion
    }
}