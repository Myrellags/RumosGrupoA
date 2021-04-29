using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Billing
{
    [Table("ProductsShoppingCars")]
    public class ProductsShoppingCar
    {
        #region "ProductsShoppingCar"
        [Key]
        public int ProductsShoppingCarID { get; set; }
        [ForeignKey("Product")] 
        public int ProductID { get; set; }
        [ForeignKey("ShoppingCar")] 
        public int ShoppingCarID { get; set; }

        public virtual ICollection<Stock.Product> Products { get; set; }

        #endregion

        public ShoppingCar ShoppingCar
        {
            get => default;
            set
            {
            }
        }

        public Stock.Product Product
        {
            get => default;
            set
            {
            }
        }
    }
}
