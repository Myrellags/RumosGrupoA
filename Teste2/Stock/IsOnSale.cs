using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock
{
    public class IsOnSale
    {
        #region "Propriedades"
        public int IsOnSaleID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }

        public double CostProduct { get; set; }
        public double ValueSalePercent { get; set; }
        
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