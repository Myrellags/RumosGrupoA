using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ecommerce.Billing

{
    [Table("SendOrders")]
    public class SendOrder
    {
        
        #region "Propriedades"

        [Key]
        public int SendOrderID { get; set; }
        [ForeignKey("InvoiceOrder")]
        public int InvoiceOrderID { get; set; }
        //public virtual InvoiceOrder InvoiceOrders { get; set; }
        public string Status { get; set; }

        public InvoiceOrder InvoiceOrder
        {
            get => default;
            set
            {
            }
        }


        #endregion

        #region "Construtores"
        public SendOrder()
        {

        }

        public SendOrder(int invoiceOrderID, int idSendOrder, string status)
        {
            InvoiceOrderID = invoiceOrderID;
            SendOrderID = idSendOrder;
            Status = status;
        }

        #endregion

    }
}
