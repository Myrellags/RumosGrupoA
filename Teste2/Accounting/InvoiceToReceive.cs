using System;

namespace Ecommerce.Accounting
{
    public class InvoiceToReceive // CONTAS A Receber
    {
        #region "Atributos"
        private int _idIO;    //private int idNotaFatura;
        private bool _status; //private bool _status;
        #endregion

        #region "Propriedades"
        public int IdIO
        {
            get { return _idIO; }
            set { _idIO = value; }
        }
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        #region "Construtores"
        public InvoiceToReceive()
        {

        }
        public InvoiceToReceive(int idIO, bool status)
        {
            _idIO = idIO;
            _status = status;
        }
        #endregion
    }
}
