using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCEcommerce.Models.Purchase;

namespace WebAppMVCEcommerce.Models.Accounting
{
    [Table("InvoiceToPays")]
    [Index(nameof(InvoiceToPayID), IsUnique = true)]
    public class InvoiceToPay // CONTAS A PAGAR
    {
        #region "Propriedades"
        [Key]
        public int InvoiceToPayID { get; set; }
        [ForeignKey("InputInvoice")]
        public int InputInvoiceID { get; set; }
        public virtual InputInvoice InputInvoices { get; set; }
        public bool Status { get; set; }

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
