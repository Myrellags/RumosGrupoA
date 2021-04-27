using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Billing

{
    public class InvoicesReceivable // Pedidos de Venda 
    {

        #region "PROPRIEDADES PEDIDOS DE VENDA" 
        public int InvoicesReceivableID { get; set; }
        //[ForeignKey("Customer")]
        public int CustomerID { get; set; }
        //[ForeignKey("Product")]
        public int ProductID { get; set; }
        [//ForeignKey("ShoppingCar")]
        public int ShoppingCarID { get; set; }
        //[ForeignKey("MethodOfPayment")]
        public int MethodOfPaymentID { get; set; }
        public int AmountProduct { get; set; }
        public double PriceProduct { get; set; }
        public double WeightProduct { get; set; }
        public string Delete { get; set; }
        public double DiscountCoupon { get; set; }
        public string Status { get; set; }
        #endregion

        #region "construtores PEDIDOS DE VENDA"
        public InvoicesReceivable()
        {

        }
        public InvoicesReceivable(int idInvoicesReceivable, int idCustomer, int idProduct, int idShoppingCar, int idMethodOfPayment, int amountProduct, double priceProduct, double weightProduct,
                        string delete, double discountCoupon, string status)
        {
            InvoicesReceivableID = idInvoicesReceivable;
            CustomerID = idCustomer;
            ProductID = idProduct;
            ShoppingCarID = idShoppingCar;
            MethodOfPaymentID = idMethodOfPayment;
            AmountProduct = amountProduct;
            PriceProduct = priceProduct;
            WeightProduct = weightProduct;
            Delete = delete;
            DiscountCoupon = discountCoupon;
            Status = status;
         
        }
        #endregion
    }
}
