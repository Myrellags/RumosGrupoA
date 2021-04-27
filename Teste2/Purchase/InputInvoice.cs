using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Purchase
{
    public class InputInvoice // notas de encomenda 
    {
        #region "Propriedades"
        public int InputInvoiceID { get; set; }
        //[ForeignKey("PurchaseRequest")] 
        public int PurchaseRequestID { get; set; }
        public string NameProvider { get; set; }
        public string MethodOfPayment { get; set; }
        public string NumberII { get; set; }
        public DateTime DateII { get; set; }
        public string NameProduct { get; set; }
        public int QtdProduct { get; set; }
        public double PriceProduct { get; set; }
        public double CampaignProvider { get; set; }

        public PurchaseRequest PurchaseRequest
        {
            get => default;
            set
            {
            }
        }

        #endregion

        #region "Construtores"
        public InputInvoice()
        {

        }
        public InputInvoice(int idII, int purchaseRequestID, string nameProvider, string methodOfPayment, string numberII, DateTime dateII,   
                            string nameProduct, int qtdProduct, double priceProduct, double campaignProvider)
        {
            InputInvoiceID = idII;
            PurchaseRequestID = purchaseRequestID;
            NameProvider = nameProvider;
            MethodOfPayment = methodOfPayment;
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
