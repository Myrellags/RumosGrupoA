using System;

namespace Ecommerce.Personal
{
    public class User : Person
    {
        #region "PROPRIEDADES USER"
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string PassUser { get; set; }

        public Billing.ShoppingCar ShoppingCar
        {
            get => default;
            set
            {
            }
        }

        public Billing.Costumer Costumer
        {
            get => default;
            set
            {
            }
        }

        #endregion

        #region "CONSTRUTORES USER"
        public User()
        {

        }
        public User(int userId, int personId, string passUser)
        {
            UserID = userId;
            PersonID = personId;
            PassUser = passUser;
        }
        #endregion

    }
}

