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
        [Required] 
        public int LoginUser { get; set; }
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

        public Costumer(int idCostumer, int loginUser, string delete)
        {
            CostumerID = idCostumer;
            LoginUser = loginUser;
            Delete = delete;
        }
        #endregion
    }
}