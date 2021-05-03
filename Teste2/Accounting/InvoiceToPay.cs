using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Accounting
{
    [Table("InvoiceToPays")]
    public class InvoiceToPay // CONTAS A PAGAR
    {
        #region "Propriedades"
        [Key]
        public int InvoiceToPayID { get; set; }
        [ForeignKey("InputInvoice")]
        public int InputInvoiceID { get; set; }
        public bool Status { get; set; }

        public Purchase.InputInvoice InputInvoice
        {
            get => default;
            set
            {
            }
        }
        #endregion

        #region "Construtores"
        public InvoiceToPay()
        {

        }
        public InvoiceToPay(int idII, bool status)
        {
            InputInvoiceID = idII;
            Status = status;
        }
        #endregion
    }
}
