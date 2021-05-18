using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCEcommerce.Models.Stock;

namespace WebAppMVCEcommerce.Models.Stock
{
    [Table("SalesPrices")] 
    public class SalesPrice
    {
        #region "Propriedades SALESPRICE"
        [Key]
        public int SalesPriceID { get; set; }
        [ForeignKey("Product")]
        public int ProdutoID { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        public double PriceSellProduct { get; set; }
        [Required]
        public double CostsProduct { get; set; }
        public double CostsOthers { get; set; }
        public string TypeOfCosts { get; set; }
        public string Delete { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        

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
