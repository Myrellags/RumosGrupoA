using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCEcommerce.Models.Stock;
using WebAppMVCEcommerce.Models.Purchase;

namespace WebAppMVCEcommerce.Models.Billing
{
    [Table("ShoppingCars")]
    public class ShoppingCar
    {
        #region "Propriedades"
        [Key]
        public int ShoppingCarID { get; set; }
        [ForeignKey("Costumer")]
        public int CostumerID { get; set; }
        public virtual Costumer Costumer { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("MethodOfPayment")]
        public int MethodOfPaymentID { get; set; }
        public virtual MethodOfPayment MethodOfPayment { get; set; }
        public int QuantityOfProdut { get; set; }
        public double PriceProduct { get; set; }
        public double WeightProduct { get; set; }
        public string Delete { get; set; }


        public virtual ICollection<Stock.Product> Products { get; set; }


        #endregion

        #region "Construtores"
        public ShoppingCar()
        {
        }
        public ShoppingCar(int idShoppingCar, int idCostumer, int idProduct, int idMethodOfPayment,
                int quantityProduct, double priceProduct, double weightProduct, string delete)
        {
            ShoppingCarID = idShoppingCar;
            CostumerID = idCostumer;
            ProductID = idProduct;
            MethodOfPaymentID = idMethodOfPayment;
            QuantityOfProdut = quantityProduct;
            PriceProduct = priceProduct;
            WeightProduct = weightProduct;
            Delete = delete;
        }
        #endregion
    }
}
