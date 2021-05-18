using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCEcommerce.Models.Billing;
using WebAppMVCEcommerce.Models.Stock;
using WebAppMVCEcommerce.Models.Purchase;

namespace WebAppMVCEcommerce.Models.Purchase
{
    [Table("Quotations")]
    public class Quotation
    {
        #region "Propriedades"
        public int QuotationID { get; set; }
        [ForeignKey("Provider")]
        public int ProviderID { get; set; }
        public virtual Provider Provider { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("MethodOfPayment")]
        public int MethodOfPaymentID { get; set; }
        public virtual MethodOfPayment MethodOfPayment { get; set; }
        [Required]
        [StringLength(60)]
        public string NameUser { get; set; }
        public string NameProduct { get; set; }
        public string NameProvider { get; set; }
        [Required]
        public double PriceProduct { get; set; }
        [Required]
        public int QuantityProduct { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DataReq { get; set; }
        public string Delete { get; set; }
        public virtual ICollection<Stock.Product> Products { get; set; }

        
        #endregion

        #region "Construtores"
        public Quotation()
        {
        }
        public Quotation(int quotationID, int providerID, int productID, int methodOfPaymentID, string nameUser, string nameProduct,
            string nameProvider, int priceProduct, int quantityProduct, string delete)
        {
            QuotationID = quotationID;
            ProviderID = providerID;
            ProductID = productID;
            MethodOfPaymentID = methodOfPaymentID;
            NameUser = nameUser;
            NameProduct = nameProduct;
            NameProvider = nameProvider;
            PriceProduct = priceProduct;
            QuantityProduct = quantityProduct;
            Delete = delete;
        }
        #endregion
    }
}
