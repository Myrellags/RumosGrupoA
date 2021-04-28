using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ecommerce.Billing

{
    class InvoiceOrder
    {

        #region "Propriedades"

        public int IoID { get; set; } // nao deveria ser InvoiceOrderID ?? a chamada da chave no invoicetopays esta assim
        public int InvoicesReceivableID { get; set; }
        public string Status { get; set; }
        public List<Billing.InvoicesReceivable> InvoicesReceivable { get; set; }
        #endregion

        #region "Construtores"
        public InvoiceOrder()
        {

        }

        public InvoiceOrder(int idIO, int idInvoicesReceivable, string status)
        {
            IoID = idIO;
            InvoicesReceivableID = idInvoicesReceivable;
            Status = status;
        }

        #endregion

    }

}
