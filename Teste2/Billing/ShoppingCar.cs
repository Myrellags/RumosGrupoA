using System;

namespace Ecommerce.Billing

{
    public class ShoppingCar
    {
        #region "Atributos"
        private int _idShoppingCar;     //private int idCarrinhoCompras;
        private int _idClient;          //private int idCliente;
        private int _idProduct;         //private int idProduto;
        private int _idMethodOfPayment; //private int idCondicaoDePagamento;
        private int _quantityProduct;   //private int quantidadeProduto;
        private double _priceProduct;   //private double precoProdutos;
        private double _weightProduct;  //private double pesoProduto
        private string _delete;         //private string delete;
        #endregion

        #region "Propriedades"
        public int IdShoppingCar
        {
            get { return _idShoppingCar; }
            set { _idShoppingCar = value; }
        }
        public int IdClient
        {
            get { return _idClient; }
            set { _idClient = value; }
        }
        public int IdProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; }
        }
        public int IdMethodOfPayment
        {
            get { return _idMethodOfPayment; }
            set { _idMethodOfPayment = value; }
        }
        public int QuantityOfProdut
        {
            get { return _quantityProduct; }
            set { _quantityProduct = value; }
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
        #endregion

        #region "Construtores"
        public ShoppingCar()
        {
        }
        public ShoppingCar(int idShoppingCar, int idClient, int idProduct, int idMethodOfPayment,
                int quantityProduct, double priceProduct, double weightProduct, string delete)
        {
            _idShoppingCar = idShoppingCar;
            _idClient = idClient;
            _idProduct = idProduct;
            _idMethodOfPayment = idMethodOfPayment;
            _quantityProduct = quantityProduct;
            _priceProduct = priceProduct;
            _weightProduct = weightProduct;
            _delete = delete;
        }
        #endregion
    }
}
