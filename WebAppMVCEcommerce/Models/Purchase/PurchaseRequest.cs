using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCEcommerce.Models.Purchase
{
    [Table("PurchaseRequests")]
    public class PurchaseRequest
    {
        #region "Propriedades"
        [Key]
        public int PurchaseRequestID { get; set; }
        [ForeignKey("Quotation")]
        public int QuotationID { get; set; }
        public virtual Quotation Quotation { get; set; }
        public bool Okay { get; set; }
        [StringLength(60)]
        public string MethodOfPayment { get; set; }
        public double CampaignProvider { get; set; }


        #endregion

        #region"Construtores"

        public PurchaseRequest()
        {

        }

        public PurchaseRequest(int idQuotation, int idPurchaseRequest, bool okay, string methodOfPayment, double campaignProvider)
        {
            QuotationID = idQuotation;
            PurchaseRequestID = idPurchaseRequest;
            Okay = okay;
            MethodOfPayment = methodOfPayment;
            CampaignProvider = campaignProvider;
        }
        #endregion
    }
}
