using System;

namespace Ecommerce.Stock
{
    public class Stock
    {
        #region "ATRIBUTOS SALESPRICE"
        private int _idProduto;                 //private int idProduto;
        private double _pricePurchaseProduct;   // PREÇO DE COMPRA DO PRODUTO
        private double _priceSellProduct;       // PREÇO DE VENDA DO PRODUTO
        private double _costsProduct;           //private double custoProduto;
        private double _costsOthers;            //private double custosOutros;
        private string _typeOfCosts;            //private string tipoDeCusto;
        private string _delete;
        #endregion


        #region "Propriedades SALESPRICE"
        public double PurchaseProduct
        {
            get { return _pricePurchaseProduct; }
            set { _pricePurchaseProduct = value; }
        }

        public double PriceSellProduct
        {
            get { return _priceSellProduct; }
            set { _priceSellProduct = value; }
        }
        public int IdProduto
        {
            get { return _idProduto; }
            set { _idProduto = value; }
        }
        public double costsProduct
        {
            get { return _costsProduct; }
            set { _costsProduct = value; }
        }

        public double costsOthers
        {
            get { return _costsOthers; }
            set { _costsOthers = value; }
        }

        public string typeOfCosts
        {
            get { return _typeOfCosts; }
            set { _typeOfCosts = value; }
        }
        public string Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }
        #endregion
        #region "CONSTRUTORES SALESPRICE"
        public Stock()
        {

        }
        public Stock(double pricePurchaseProduct, double priceSellProduct, int idProduto, double costsOthers, string typeOfCosts, string delete )
        {
            _pricePurchaseProduct = pricePurchaseProduct;
            _priceSellProduct = priceSellProduct;
            _idProduto = idProduto;
            _costsOthers = costsOthers;
            _typeOfCosts = typeOfCosts;
            _delete = delete;
        }
        #endregion
    }
}
