using System;

namespace Billing
{
    public class UnlockedStock
    {
        #region "Atributos"
        private int _idUnlocked;  //private int idUnlocked;
        private int _idProduct;   //private int idProduto;
        private string _status;     //private string status;
        #endregion

        #region "Propriedades"

        public int IdUnlocked
        {
            get { return _idUnlocked; }
            set { _idUnlocked = value; }
        }

        public int IdProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        #region "Construtores"
        public UnlockedStock()
        {

        }

        public UnlockedStock(int idUnlocked, int idProduct, string status)
        {
            _idUnlocked = idUnlocked;
            _idProduct = idProduct;
            _status = status;
        }

        #endregion

    }

}
