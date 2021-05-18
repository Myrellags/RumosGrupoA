using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCEcommerce.Models.Stock;

namespace WebAppMVCEcommerce.Models.Billing
{
    [Table("ProductsShoppingCars")]
    public class ProductsShoppingCar
    {
        #region "ProductsShoppingCar"
        [Key]
        public int ProductsShoppingCarID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("ShoppingCar")]
        public int ShoppingCarID { get; set; }
        public virtual ShoppingCar ShoppingCar { get; set; }

        public virtual ICollection<Stock.Product> Products { get; set; }

        #endregion
    }
}
