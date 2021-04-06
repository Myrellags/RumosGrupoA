using System;

namespace Costumer
{
    public class Costumer
    {
        #region "Atributos"
        private int _idCostumer; //private int idCliente;
        private int _idPeople;   //private int idPessoa;
        private string _delete;  //private string delete;
        #endregion

        #region "Propriedades"

        public int idCostumer
        {
            get { return _idCostumer; }
            set { _idCostumer = value; }
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
    }
}
