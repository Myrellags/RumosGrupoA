using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Billing

{
    [Table("Providers")]
    public class Provider : Personal.Person
    { 
        #region "Propriedades"

        [Key]
        public int ProviderID { get; set; }
        [ForeignKey("Person")]
        public int PersonID { get; set; } 
        public string Delete { get; set; }
        #endregion

        #region "Construtores"
        public Provider()
        {

        }

        public Provider (int idProvider, int idPerson, string delete)
        {
            ProviderID = idProvider;
            PersonID = idPerson;
            Delete = delete;
        }

        #endregion

    }
}