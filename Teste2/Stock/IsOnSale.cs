using System;

namespace Ecommerce.Stock
{
    public class IsOnSale
    {
        #region "Atributos"
        private int _idIsOnSale;          //private int idCampanha;
        private int _idProduct;           //private int idProduto;
        private int _idWarehouse;         //private int idArmazem;
        private double _costProduct;      //private double custoProduto;
        private double _valueSalePercent; //private double valorCampanha;
        #endregion

        #region "Propriedades"
        public int IdIsOnSale
        {
            get { return _idIsOnSale; }
            set { _idIsOnSale = value; }
        }
        public int IdProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; }
        }
        public int IdWarehouse
        {
            get { return _idWarehouse; }
            set { _idWarehouse = value; }
        }
        public double CostProduct
        {
            get { return _costProduct; }
            set { _costProduct = value; }
        }
        public double ValeuSalePercent
        {
            get { return _valueSalePercent; }
            set { _valueSalePercent = value; }
        }
        #endregion

        #region "Construtores"
        public IsOnSale()
        {

        }
        public IsOnSale(int idIsOnSale, int idProduct, int idWarehouse, double costProduct,
            double valueSalePercent)
        {
            _idIsOnSale = idIsOnSale;
            _idProduct = idProduct;
            _idWarehouse = idWarehouse;
            _costProduct = costProduct;
            _valueSalePercent = valueSalePercent;
        }
        #endregion
    }
}