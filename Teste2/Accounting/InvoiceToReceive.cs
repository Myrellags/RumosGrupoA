using System;

namespace Ecommerce.Accounting
{
    public class InvoiceToReceive // CONTAS A Receber
    {
        #region "Propriedades"
        public int InvoiceToReceiveID { get; set; }
        public int InvoiceOrderID { get; set; }
        public bool Status { get; set; }
        #endregion

        #region "Construtores"
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
