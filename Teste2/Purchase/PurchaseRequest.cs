using System;

namespace Ecommerce.Purchase
{
    public class PurchaseRequest
    {

        #region "Propriedades"

        public int PurchaseRequestID { get; set; }
        public int QuotationID { get; set; }
        public bool Okay { get; set; }
        public int MethodOfPaymentID { get; set; }
        public double CampaignProvider { get; set; }

        public InputInvoice InputInvoice
        {
            get => default;
            set
            {
            }
        }
        #endregion

        #region"Construtores"

        public PurchaseRequest()
        {

        }

        public PurchaseRequest (int idQuotation, int idPurchaseRequest, bool okay, int idMethodOfPayment, double campaignProvider)
        {
            QuotationID = idQuotation;
            PurchaseRequestID = idPurchaseRequest;
            Okay = okay;
            MethodOfPaymentID = idMethodOfPayment;
            CampaignProvider = campaignProvider;
        }
        #endregion
    }
}
