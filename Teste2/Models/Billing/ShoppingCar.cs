using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Billing

{
    [Table("ShoppingCars")]
    public class ShoppingCar
    {
        #region "Propriedades"
        [Key] 
        public int ShoppingCarID { get; set; }
        [ForeignKey("Costumer")]
        public int CostumerID { get; set; }
        //public virtual Costumer Costumers { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        //public virtual Product Products { get; set; }
        [ForeignKey("MethodOfPayment")]
        public int MethodOfPaymentID { get; set; }
        //public virtual MethodOfPayment MethodOfPayments { get; set; }
        public int QuantityOfProdut { get; set; }
        public double PriceProduct { get; set; }
        public double WeightProduct { get; set; }
        public string Delete { get; set; }


        public virtual ICollection<Stock.Product> Products { get; set; }

        public Personal.User User
        {
            get => default;
            set
            {
            }
        }



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
