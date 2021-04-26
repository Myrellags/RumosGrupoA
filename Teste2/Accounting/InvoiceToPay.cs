using System;

namespace Ecommerce.Accounting
{
    public class InvoiceToPay // CONTAS A PAGAR
    {
        #region "Atributos"
        private int _idII;    //private int idNE;
        private bool _status; //private bool _status;
        #endregion

        #region "Propriedades"
        public int IdII
        {
            get { return _idII; }
            set { _idII = value; }
        }
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        #region "Construtores"
        public InvoiceToPay()
        {

        }
        public InvoiceToPay(int idII, bool status)
        {
            _idII = idII;
            _status = status;
        }
        #endregion
    }
}
