using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock
{
    public class Stock
    {

        #region "Propriedades SALESPRICE"
        public double PurchaseProduct { get; set; }
        public double PriceSellProduct { get; set; }

        [ForeignKey("Product")]
        public int ProdutoID { get; set; }
        public double CostsProduct { get; set; }
        public double CostsOthers { get; set; }
        public string TypeOfCosts { get; set; }
        public string Delete { get; set; }
        #endregion

        #region "CONSTRUTORES SALESPRICE"
        public Stock()
        {

        }
        public Stock(double pricePurchaseProduct, double priceSellProduct, int idProduto, double costsOthers, string typeOfCosts, string delete, double costsproduct)
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
