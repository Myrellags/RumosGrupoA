using System;

namespace Billing
{
    public class Provider
    {
        #region "Atributos"
        private int _idProvider; //private int idFornecedor;
        private int _idPeople;   //private int idPessoa;
        private string _delete;  //private string delete;
        #endregion

        #region "Propriedades"

        public int idProvider
        {
            get { return _idProvider; }
            set { _idProvider = value; }
        }

        public int idPeople
        {
            get { return _idPeople; }
            set { _idPeople = value; }
        }

        public string delete
        {
            get { return _delete; }
            set { _delete = value; }
        }
        #endregion

        #region "Construtores"
        public Provider()
        {

        }

        public Provider (int idProvider, int idPeople, string delete)
        {
            _idProvider = idProvider;
            _idPeople = idPeople;
            _delete = delete;
        }

        #endregion

    }
}