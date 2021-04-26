using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Billing

{
    public class SendOrder
    {
        #region "Atributos"
        private int _idSalesOrder;  //private int idPedidoVenda;
        private int _idSendOrder;   //private int idEnvioOrdem;
        private string _status;     //private string status;
        #endregion

        #region "Propriedades"

        public int IdSalesOrder
        {
            get { return _idSalesOrder; }
            set { _idSalesOrder = value; }
        }

        public int IdSendOrder
        {
            get { return _idSendOrder; }
            set { _idSendOrder = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        #region "Construtores"
        public SendOrder()
        {

        }

        public SendOrder(int idSalesOrder, int idSendOrder, string status)
        {
            _idSalesOrder = idSalesOrder;
            _idSendOrder = idSendOrder;
            _status = status;
        }

        #endregion

    }
}
