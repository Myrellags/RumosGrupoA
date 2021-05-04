using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock
{
    [Table("SalesPrices")] //colocar no plural
    public class SalesPrice
    {
        //[Key]//Rogério vou fazer algumas alterações neste código Ass Myrella
        //#region "Propriedades SALESPRICE"
        //public double PurchaseProduct { get; set; }
        //public double PriceSellProduct { get; set; }

        #region "Propriedades SALESPRICE"
        [Key]
        public int SalesPriceID { get; set; }
        [ForeignKey("Product")]
        public int ProdutoID { get; set; }
        [Required]
        // public virtual Product Products { get; set; }
        public double PriceSellProduct { get; set; }
        [Required] 
        public double CostsProduct { get; set; }
        public double CostsOthers { get; set; }
        public string TypeOfCosts { get; set; }
        public string Delete { get; set; }

        public virtual ICollection<Stock.Product> Products { get; set; }
        //public List<Stock.Product> Products { get; set; }Rogério vamos utilizar collection Virtual Ass Myrella

        #endregion


        #region "CONSTRUTORES SALESPRICE"
        public SalesPrice()
        {

        }
        public SalesPrice(int idProduto, double priceSellProduct, double costsProduct, double costsOthers, string typeOfCosts, string delete)
        {
            ProdutoID = idProduto;
            PriceSellProduct = priceSellProduct; 
            CostsProduct = costsProduct;
            CostsOthers = costsOthers;
            TypeOfCosts = typeOfCosts;
            Delete = delete;
        }
        #endregion
    }
}
