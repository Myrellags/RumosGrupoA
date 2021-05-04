using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Personal
{
    [Table("Users")]
    //[Index(nameof(LoginUser), IsUnique = true)]
    public class User : Person
    {
        #region "PROPRIEDADES USER"
        [Key]
        public int UserID { get; set; }
        [Required]
        public string LoginUser { get; set; }
        public string PassUser { get; set; }

        #endregion

        #region "CONSTRUTORES USER"
        public User()
        {

        }

    public Index()
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

