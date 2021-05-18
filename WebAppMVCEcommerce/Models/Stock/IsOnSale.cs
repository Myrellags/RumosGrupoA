using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCEcommerce.Models.Stock
{
    [Table("IsOnSales")]
    public class IsOnSale
    {
        #region "Propriedades"
        [Key]
        public int IsOnSaleID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [Required]
        public double CostProduct { get; set; }
        [Required]
        public double ValueSalePercent { get; set; }

        public virtual ICollection<Stock.Product> Products { get; set; }

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
