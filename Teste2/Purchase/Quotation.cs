using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Purchase
{
    public class Quotation
    {
        #region "Propriedades"
        public int QuotationID { get; set; }
        [ForeignKey("Provider")]
        public int ProviderID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        [ForeignKey("MethodOfPayment")]
        public int MethodOfPaymentID { get; set; }
        public string NameUser { get; set; }
        public string NameProduct { get; set; }
        public string NameProvider { get; set; }
        public double PriceProduct { get; set; }
        public int QuantityProduct { get; set; }
        public string Delete { get; set; }

        public MethodOfPayment MethodOfPayment
        {
            get => default;
            set
            {
            }
        }
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
