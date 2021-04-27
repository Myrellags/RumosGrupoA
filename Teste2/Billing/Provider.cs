﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Billing

{
    public class Provider
    { 
        #region "Propriedades"

        public int ProviderID { get; set; }
        //[ForeignKey("People")]
        public int PeopleID { get; set; }
      
        public string Delete { get; set; }
        #endregion

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