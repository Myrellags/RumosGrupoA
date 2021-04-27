using System;

using System.ComponentModel.DataAnnotations.Schema;


namespace Ecommerce.Billing

{
    class InvoiceOrder
    {

        #region "Propriedades"

        public int IoID { get; set; }
       
        public int InvoicesReceivableID { get; set; }
        public string Status { get; set; }
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
