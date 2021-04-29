using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Billing
{
    [Table("UnlockedStocks")]
    public class UnlockedStock
    {

        #region "Propriedades"

        [Key]
        public int UnlockedID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Stock.Product> Products { get; set; }

        public Stock.Product Product
        {
            get => default;
            set
            {
            }
        }

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
