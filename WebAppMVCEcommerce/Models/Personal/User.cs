using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCEcommerce.Models.Personal
{
    [Table("Users")]
    [Index(nameof(LoginUser), IsUnique = true)]
    public class User : Person
    {
        #region "PROPRIEDADES USER"
        [Key]
        public int UserID { get; set; }
        [Required]
        public string LoginUser { get; set; }
        [Required] 
        public string PassUser { get; set; }

        #endregion

        #region "CONSTRUTORES USER"
        public User()
        {

        }

        public User(int userId, string loginUser, string passUser)
        {
            UserID = userId;
            LoginUser = loginUser;
            PassUser = passUser;
        }
        #endregion

    }
}
