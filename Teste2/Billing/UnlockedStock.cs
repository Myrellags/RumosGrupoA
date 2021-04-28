using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Billing
{
    public class UnlockedStock
    {

        #region "Propriedades"

        public int UnlockedID { get; set; }

        //[ForeignKey("Product")]
        public int ProductID { get; set; }
        public string Status { get; set; }
        public List<Stock.Product> Product { get; set; }

        #endregion

        #region "Construtores"
        public UnlockedStock()
        {

        }

        public UnlockedStock(int idUnlocked, int idProduct, string status)
        {
            UnlockedID = idUnlocked;
            ProductID = idProduct;
            Status = status;
        }

        #endregion

    }

}
