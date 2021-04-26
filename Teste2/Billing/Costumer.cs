using System;

namespace Ecommerce.Billing
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


        #region "Construtores"
        public Costumer()
        {

        }

        public Costumer(int idCostumer, int idPeople, string delete)
        {
            _idCostumer = idCostumer;
            _idPeople = idPeople;
            _delete = delete;
        }
        #endregion

        #region"Métodos"

        public void InsereCostumer()
        {
            // Instanciando a classe people
            Costumer costumer = new Costumer();

            //Gravando no database
            try
            {
                //db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //db.SubmitChanges();
            }

            #endregion
        }
    }
}