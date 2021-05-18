using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCEcommerce.Models.Billing
{
    [Table("Providers")]
    public class Provider : Personal.Person
    {
        #region "Propriedades"

        [Key]
        public int ProviderID { get; set; }
        public string Delete { get; set; }
        #endregion

        #region "Construtores"
        public Provider()
        {

        }

        public Provider(int idProvider, string delete)
        {
            ProviderID = idProvider;
            Delete = delete;
        }

        #endregion

    }
}
