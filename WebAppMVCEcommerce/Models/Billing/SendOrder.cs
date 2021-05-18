using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCEcommerce.Models.Billing
{
    [Table("SendOrders")]
    public class SendOrder
    {

        #region "Propriedades"

        [Key]
        public int SendOrderID { get; set; }
        [ForeignKey("InvoiceOrder")]
        public int InvoiceOrderID { get; set; }
        public virtual InvoiceOrder InvoiceOrder { get; set; }
        public string Status { get; set; }

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
