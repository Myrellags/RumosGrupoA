using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Billing

{
    public class ShoppingCar
    { 
        #region "Propriedades"
        public int ShoppingCarID { get; set; }
        public int ClientID { get; set; } //client ID pertence a que modulo e class?
        public int ProductID { get; set; }
        public int MethodOfPaymentID { get; set; }
        public int QuantityOfProdut { get; set; }
        public double PriceProduct { get; set; }
        public double WeightProduct { get; set; }
        public string Delete { get; set; }


        //public Ecommerce.Stock.Product Product;
        //public Ecommerce.Purchase.MethodOfPayment MethodOfPayment;

        public List<Stock.Product> Product { get; set; }
        public List<Purchase.MethodOfPayment> MethodOfPayment { get; set; }



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
