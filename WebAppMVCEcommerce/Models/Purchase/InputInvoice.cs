using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCEcommerce.Models.Purchase
{
    [Table("InputInvoices")]
    public class InputInvoice // guia de transporte
    {
        #region "Propriedades"
        [Key]
        public int InputInvoiceID { get; set; }
        [ForeignKey("PurchaseRequest")]
        public int PurchaseRequestID { get; set; }
        public virtual PurchaseRequest PurchaseRequest { get; set; }
        [StringLength(60)]
        [Required] 
        public string NameProvider { get; set; }
        [StringLength(60)]
        [Required] 
        public string MethodOfPayment { get; set; }
        [StringLength(15)]
        [Required] 
        public string NumberII { get; set; }
        [Required] 
        public DateTime DateII { get; set; }
        [StringLength(60)]
        [Required] 
        public string NameProduct { get; set; }
        [Required] 
        public int QtdProduct { get; set; }
        [Required] 
        public double PriceProduct { get; set; }
        public double CampaignProvider { get; set; }

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
