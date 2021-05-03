using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Accounting
{
    [Table("InvoiceToReceives")]
    //[Index(nameof(InvoiceToReceiveID), IsUnique = true)]
    public class InvoiceToReceive // CONTAS A Receber
    {
        #region "Propriedades InvoiceToReceive"
        [Key]
        public int InvoiceToReceiveID { get; set; }
        [ForeignKey("InvoiceOrder")] 
        public int InvoiceOrderID { get; set; }
        //public virtual InvoiceOrder InvoiceOrders { get; set; }
        public bool Status { get; set; }

        public Billing.InvoiceOrder InvoiceOrder
        {
            get => default;
            set
            {
            }
        }

        #endregion

        #region "Construtores InvoiceToReceive"
        public InvoiceToReceive()
        {

        }
        public InvoiceToReceive(int idITR, int idIO, bool status)
        {
            InvoiceToReceiveID = idITR;
            InvoiceOrderID = idIO;
            Status = status;
        }
        #endregion
    }
}
