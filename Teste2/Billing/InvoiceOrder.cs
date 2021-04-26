using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Billing

{
    class InvoiceOrder
    {
        #region "Atributos"
        private int _idIO;                   //private int idNotaFatura;
        private int _idInvoicesReceivable;   //private int idPedidoVenda;
        private string _status;              //private string status;
        #endregion

        #region "Propriedades"

        public int IdIO
        {
            get { return _idIO; }
            set { _idIO = value; }
        }

        public int IdInvoicesReceivable
        {
            get { return _idInvoicesReceivable; }
            set { _idInvoicesReceivable = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        #region "Construtores"
        public InvoiceOrder()
        {

        }

        public InvoiceOrder(int idIO, int idInvoicesReceivable, string status)
        {
            _idIO = idIO;
            _idInvoicesReceivable = idInvoicesReceivable;
            _status = status;
        }

        #endregion

    }

}
