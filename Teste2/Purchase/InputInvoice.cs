using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Purchase
{
    [Table("InputInvoice")]
    public class InputInvoice // guia de transporte
    {
        #region "Propriedades"
        [Key]
        public int InputInvoiceID { get; set; }
        [ForeignKey("PurchaseRequest")] 
        public int PurchaseRequestID { get; set; }
        [StringLength(60)] 
        public string NameProvider { get; set; }
        [StringLength(60)] 
        public string MethodOfPayment { get; set; }
        [StringLength(15)] //até 15 caracteres
        public string NumberII { get; set; }
        public DateTime DateII { get; set; }
        [StringLength(60)] 
        public string NameProduct { get; set; }
        public int QtdProduct { get; set; }
        public double PriceProduct { get; set; }
        public double CampaignProvider { get; set; }
        public virtual PurchaseRequest PurchaseRequest { get; set; }

        public PurchaseRequest PurchaseRequest1
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
