using System;

namespace Ecommerce.Accounting
{
    public class InvoiceToPay // CONTAS A PAGAR
    {
        #region "Propriedades"
        public int InvoiceToPayID { get; set; }
        public int InputInvoiceID { get; set; }
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
