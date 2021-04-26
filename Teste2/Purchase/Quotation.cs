using System;

namespace Ecommerce.Purchase
{
    public class Quotation
    {
        #region "Propriedades"
        public int QuotationID { get; set; }
        public int UserID { get; set; }
        public int ProviderID { get; set; }
        public string NameProduct { get; set; }
        public double PriceProduct { get; set; }
        public int QuantityProduct { get; set; }
        public bool ListaProdutos { get; set; }
        public string Delete { get; set; }

        public PurchaseRequest PurchaseRequest
        {
            get => default;
            set
            {
            }
        }

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
        public Quotation(int idQuotation, int idUser, int idProvider, string nameProduct,
                int priceProduct, int quantityProduct, bool listProduct, string delete)
        {
            QuotationID = idQuotation;
            UserID = idUser;
            ProviderID = idProvider;
            NameProduct = nameProduct;
            PriceProduct = priceProduct;
            QuantityProduct = quantityProduct;
            ListaProdutos = listProduct;
            Delete = delete;
        }
        #endregion
    }
}
