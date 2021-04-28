using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Billing

{
    public class Provider
    { 
        #region "Propriedades"

        public int ProviderID { get; set; }
        //[ForeignKey("People")]
        public int PeopleID { get; set; } //esta chave nao bate certo com a class people, n sera PersonID?

        public string Delete { get; set; }
        #endregion

        //public List<Personal.Person.PersonID> PersonID { get; set; }

        #region "Construtores"
        public Provider()
        {

        }

        public Provider (int idProvider, int idPeople, string delete)
        {
            ProviderID = idProvider;
            PeopleID = idPeople;
            Delete = delete;
        }

        #endregion

    }
}