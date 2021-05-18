using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCEcommerce.Models.Stock;


namespace WebAppMVCEcommerce.Models.Billing
{
    [Table("UnlockedStocks")]
    public class UnlockedStock
    {

        #region "Propriedades"

        [Key]
        public int UnlockedID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Stock.Product> Products { get; set; }

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
