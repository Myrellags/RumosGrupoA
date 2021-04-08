using System;

namespace IssueInvoice
{
    public class IssueInvoice // Guias de transporte 
    {
        #region "ATRIBUTOS GUIA DE TRANSPORTE"
        private int _idSalesOrder;     //private int idPedidoVenda;
        private int _idCustomer;         //private int idCliente;
        private int _idProduct;        //private int idProduto;
        private int _idPaymentWay;     //private int idCondicaoDePagamento;
        private int _quantityProduct;  //private int quantidadeProduto;
        private double _priceProduct;  //private double precoProdutos;
        private double _weigthProduct; //private double pesoProduto;
        private string _delete;        //private string delete;
        #endregion

        #region "PROPRIEDADES GUIAS DE TRANSPORTE
        public int idSalesOrder
        {
            get { return _idSalesOrder; }
            set { _idSalesOrder = value; }
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
        public int IdPaymentWay
        {
            get { return _idPaymentWay; }
            set { _idPaymentWay = value; }
        }
        public int quantityProduct
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
            get { return _weigthProduct; }
            set { _weigthProduct = value; }
        }
        public string Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }
        #endregion
        #region "construtores guias de transporte"
        public IssueInvoice()
        {

        }
        public IssueInvoice(int idSalesOrder, int idCustomer, int idProduct, int idPaymentWay, int quantityProduct, double priceProduct, double weightProduct,
                        string address)
        {
            _idSalesOrder = idSalesOrder;
            _idCustomer = idCustomer;
            _idProduct = idProduct;
            _idPaymentWay = idPaymentWay;
            _quantityProduct = quantityProduct;
            _priceProduct = priceProduct;
            _weigthProduct = weightProduct;
            _delete = address;

        }
        #endregion
    }
}
    

