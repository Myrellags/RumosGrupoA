using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace Order
{
    public class Order
    {
        #region "Atributos"
        private string _idOrder;       //private string idPedido
        private string _idShoppingCar; //private string idcarrinho
        private string _idClient;      //private string idClinte
        private bool _orcamentoPedido; //private bool orcamentoPedido
        private string _delete;        //private string delete
        private string _cupomDesconto; //private string cupomDesconto
        private string _status;        //private string status
        #endregion

        #region "Propriedades"
        public string idOrder
        {
            get { return _idOrder; }
            set { _idOrder = value; }
        }

        public string idShoppingCar
        {
            get { return _idShoppingCar; }
            set { _idShoppingCar = value; }
        }

        public string idClient
        {
            get { return _idClient; }
            set { _idClient = value; }
        }

        public bool orcamentoPedido
        {
            get { return _orcamentoPedido; }
            set { _orcamentoPedido = value; }
        }

        public string delete
        {
            get { return _delete; }
            set { _delete = value; }
        }

        public string cupomDesconto
        {
            get { return _cupomDesconto; }
            set { _cupomDesconto = value; }
        }

        public string status
        {
            get { return _status; }
            set { _status = value; }
        }


        #endregion
    }
}



