using System;
using System.Collections.Generic;

namespace Ecommerce.Accounting
{
    public class InvoiceToReceive // CONTAS A Receber
    {
        #region "Propriedades InvoiceToReceive"
        public int InvoiceToReceiveID { get; set; }
        public int InvoiceOrderID { get; set; }
        public bool Status { get; set; }

        public List<Billing.InvoicesReceivable> InvoicesReceivables { get; set; }
       
        // public List<Billing.InvoiceOrder> InvoiceOrders { get; set; }

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
