using System;

namespace SalesPrice
{
    public class SalesPrice
    {
        #region "ATRIBUTOS SALESPRICE"
        private double _pricePurchaseProduct; // PREÇO DE COMPRA DO PRODUTO
        private double _priceSellProduct; // PREÇO DE VENDA DO PRODUTo
        private double _costsProvider;  //private double custosFornecedores;
        private double _costsProduct;   //private double custoProduto;
        private double _costsOthers;    //private double custosOutros;
        private string _typeOfCosts;    //private string tipoDeCusto;
        private string _delete;
        #endregion


        #region "Propriedades"
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
        public double CostsProvider
        {
            get { return _costsProvider; }
            set { _costsProvider = value; }
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
    }
}
