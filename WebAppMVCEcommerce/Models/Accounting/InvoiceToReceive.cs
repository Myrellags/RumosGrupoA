using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCEcommerce.Models.Billing;
using WebAppMVCEcommerce.Models.Purchase;

namespace WebAppMVCEcommerce.Models.Accounting
{
    [Table("InvoiceToReceives")]
    [Index(nameof(InvoiceToReceiveID), IsUnique = true)]
    public class InvoiceToReceive // CONTAS A Receber
    {
        #region "Propriedades InvoiceToReceive"
        [Key]
        public int InvoiceToReceiveID { get; set; }
        [ForeignKey("InvoiceOrder")]
        public int InvoiceOrderID { get; set; }
        public virtual InvoiceOrder InvoiceOrder { get; set; }
        public string Status { get; set; }

        #endregion

        #region "Construtores InvoiceToReceive"
        public InvoiceToReceive()
        {

        }
        public InvoiceToReceive(int idITR, int idIO, string status)
        {
            InvoiceToReceiveID = idITR;
            InvoiceOrderID = idIO;
            Status = status;
        }
        #endregion
    }
}
