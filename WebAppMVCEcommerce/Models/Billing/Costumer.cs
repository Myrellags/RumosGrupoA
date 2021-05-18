using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCEcommerce.Models.Personal;

namespace WebAppMVCEcommerce.Models.Billing
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
        public virtual User User { get; set; }
        public string Delete { get; set; }

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
