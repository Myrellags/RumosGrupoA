using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Billing
{
    [Table("Costumers")]
    public class Costumer
    {
        #region "Propriedades"

        [Key]
        public int CostumerID { get; set; }
        [ForeignKey("User")] 
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