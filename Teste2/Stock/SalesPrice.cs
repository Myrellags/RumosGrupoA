using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock
{
    [Table("SalesPrice")]
    public class SalesPrice
    {
        [Key]
        #region "Propriedades SALESPRICE"
        public double PurchaseProduct { get; set; }
        public double PriceSellProduct { get; set; }

        [ForeignKey("Product")]
        public int ProdutoID { get; set; }
        public double CostsProduct { get; set; }
        public double CostsOthers { get; set; }
        public string TypeOfCosts { get; set; }
        public string Delete { get; set; }

        public List<Stock.Product> Products { get; set; }

        #endregion


        #region "CONSTRUTORES SALESPRICE"
        public SalesPrice()
        {

        }
        public SalesPrice(double pricePurchaseProduct, double priceSellProduct, int idProduto, double costsOthers, string typeOfCosts, string delete, double costsproduct)
        {
            PurchaseProduct = pricePurchaseProduct;
            PriceSellProduct = priceSellProduct;
            ProdutoID = idProduto;
            CostsProduct = costsproduct; 
               CostsOthers = costsOthers;
            TypeOfCosts = typeOfCosts;
            Delete = delete;
        }
        #endregion
    }
}
