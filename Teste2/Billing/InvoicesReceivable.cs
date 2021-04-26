using System;

namespace Ecommerce.Billing

{
    public class InvoicesReceivable // Pedidos de Venda 
    {
        #region "ATRIBUTOS INVOICESRECEIVABLE"
        private int _idInvoicesReceivable; //int _idPedidoVenda;
        private int _idCustomer; // int id cliente
        private int _idProduct; // int id produto
        private int _idShoppingCar; // int carrinho de compras
        private int _idMethodOfPayment; // int metodos de pagamento 
        private int _amountProduct; // quantidade de produto
        private double _priceProduct; // preço do produto
        private double _weightProduct; // _pesoProduto;
        private string _delete; //int    
        private double _discountCoupon; //private string cupomDesconto
        private string _status;        //private string status

        #endregion

        #region "PROPRIEDADES PEDIDOS DE VENDA" 
        public int IdInvoicesReceivable
        {
            get { return _idInvoicesReceivable; }
            set { _idInvoicesReceivable = value; }
        }
        public int IdCustomer
        {
            get { return _idCustomer; }
            set { _idCustomer = value; }
        }
        public int IdProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; }
        }
        public int IdShoppingCar
        {
            get { return _idShoppingCar; }
            set { _idShoppingCar = value; }
        }
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
