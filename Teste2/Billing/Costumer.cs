using System;

namespace Ecommerce.Billing
{
    public class Costumer
    {
        #region "Propriedades"

        public int CostumerID { get; set; }
        public int UserID { get; set; }
        public string Delete { get; set; }

        public Personal.User User
        {
            get => default;
            set
            {
            }
        }

        #endregion

        #region "Construtores"
        public Costumer()
        {

        }

        public Costumer(int idCostumer, int idUser, string delete)
        {
            CostumerID = idCostumer;
            UserID = idUser;
            Delete = delete;
        }
        #endregion
    }
}