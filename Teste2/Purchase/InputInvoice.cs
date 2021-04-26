using System;

namespace Ecommerce.Purchase
{
    public class InputInvoice // notas de encomenda 
    {
        #region "Propriedades"
        public int InputInvoiceID { get; set; }
        public int ProviderID { get; set; }
        public int MethodOfPaymentID { get; set; }
        public int ProductID { get; set; }
        public string NumberII { get; set; }
        public DateTime DateII { get; set; }
        public string NameProduct { get; set; }
        public int QtdProduct { get; set; }
        public double PriceProduct { get; set; }
        public double CampaignProvider { get; set; }
        
        #endregion

    #region "Construtores"
        public InputInvoice()
        {

        }
        public InputInvoice(int idII, int idProvider, int idMethodOfPayment, int idProduct, string numberII, DateTime dateII,   
                            string nameProduct, int qtdProduct, double priceProduct, double campaignProvider)
        {
            InputInvoiceID = idII;
            ProviderID = idProvider;
            MethodOfPaymentID = idMethodOfPayment;
            ProductID = idProduct;
            NumberII = numberII;
            DateII = dateII;
            NameProduct = nameProduct;
            QtdProduct = qtdProduct;
            PriceProduct = priceProduct;
            CampaignProvider = campaignProvider;
        }
        #endregion
    }
}
