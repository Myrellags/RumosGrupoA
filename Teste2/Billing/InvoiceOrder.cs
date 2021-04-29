using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ecommerce.Billing

{
    [Table("InvoiceOrders")]
    public class InvoiceOrder
    {

        #region "Propriedades"

        [Key]
        public int InvoiceOrderID { get; set; }
        [ForeignKey("InvoicesReceivable")] 
        public int InvoicesReceivableID { get; set; }
        public string Status { get; set; }

        public InvoicesReceivable InvoicesReceivable1
        {
            get => default;
            set
            {
            }
        }
        #endregion

        #region "Construtores"
        public InvoiceOrder()
        {

        }

        public InvoiceOrder(int idIO, int idInvoicesReceivable, string status)
        {
            InvoiceOrderID = idIO;
            InvoicesReceivableID = idInvoicesReceivable;
            Status = status;
        }

        #endregion

    }

}
