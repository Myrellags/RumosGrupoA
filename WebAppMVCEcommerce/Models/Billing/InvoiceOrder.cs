using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCEcommerce.Models.Billing
{
    [Table("InvoiceOrders")]
    public class InvoiceOrder // PEDIDOS EM ABERTO
    {

        #region "Propriedades"

        [Key]
        public int InvoiceOrderID { get; set; }
        [ForeignKey("InvoicesReceivable")]
        public int InvoicesReceivableID { get; set; }
        public virtual InvoicesReceivable InvoicesReceivable { get; set; }
        public string Status { get; set; }

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
