using System;

namespace Ecommerce.Billing

{
    public class InvoicesReceivable // Pedidos de Venda 
    {

        #region "PROPRIEDADES PEDIDOS DE VENDA" 
        public int IdInvoicesReceivable { get; set; }
        public int IdCustomer { get; set; }

        public int IdProduct { get; set; }

        public int IdShoppingCar { get; set; }

        public int IdMethodOfPayment
        {
            get { return _idMethodOfPayment; }
            set { _idMethodOfPayment = value; }
        }
        public int AmountProduct
        {
            get { return _amountProduct; }
            set { _amountProduct = value; }
        }
        public double PriceProduct
        {
            get { return _priceProduct; }
            set { _priceProduct = value; }
        }
        public double WeightProduct
        {
            get { return _weightProduct; }
            set { _weightProduct = value; }
        }
        public string Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }

        public double DiscountCoupon
        {
            get { return _discountCoupon; }
            set { _discountCoupon = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        #endregion

        #region "construtores PEDIDOS DE VENDA"
        public InvoicesReceivable()
        {

        }
        public InvoicesReceivable(int idInvoicesReceivable, int idCustomer, int idProduct, int idShoppingCar, int idMethodOfPayment, int amountProduct, double priceProduct, double weightProduct,
                        string delete, double discountCoupon, string status)
        {
            _idInvoicesReceivable = idInvoicesReceivable;
            _idCustomer = idCustomer;
            _idProduct = idProduct;
            _idShoppingCar =idShoppingCar;
            _idMethodOfPayment = idMethodOfPayment;
            _amountProduct = amountProduct;
            _priceProduct = priceProduct;
            _weightProduct = weightProduct;
            _delete = delete;
            _discountCoupon = discountCoupon;
            _status = status;
         
        }
        #endregion
    }
}
