using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Billing

{
    public class ShoppingCar
    { 
        #region "Propriedades"
        public int ShoppingCarID { get; set; }
        [ForeignKey("Client")]
        public int ClientID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        [ForeignKey("MethodOfPayment")]
        public int MethodOfPaymentID { get; set; }
        public int QuantityOfProdut { get; set; }
        public double PriceProduct { get; set; }
        public double WeightProduct { get; set; }
        public string Delete { get; set; }
       
        #endregion

        #region "Construtores"
        public ShoppingCar()
        {
        }
        public ShoppingCar(int idShoppingCar, int idClient, int idProduct, int idMethodOfPayment,
                int quantityProduct, double priceProduct, double weightProduct, string delete)
        {
            ShoppingCarID = idShoppingCar;
            ClientID = idClient;
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
