using System;

namespace Purchase
{
    public class Quotation
    {
        #region "Atributos"
        private int _idQuotation;       //private int idOrcamento;
        private int _idUser;            //private int idUsuario;
        private int _idProvider;        //private int idFornecedor;
        private string _nameProduct;    //private string nomeProduto;
        private double _priceProdut;    //private double precoProduto;
        private int _quantityProduct;   //private int quantidadeProduto;
        private bool _listProduct;      //private bool listaProdutos;
        private string _delete;         //private string delete;
        #endregion

        #region "Propriedades"
        public int IdQuotation
        {
            get { return _idQuotation; }
            set { _idQuotation = value; }
        }
        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }
        public int IdProvider
        {
            get { return _idProvider; }
            set { _idProvider = value; }
        }
        public string NameProduct
        {
            get { return _nameProduct; }
            set { _nameProduct = value; }
        }
        public double PriceProduct
        {
            get { return _priceProdut; }
            set { _priceProdut = value; }
        }
        public int QuantityProduct
        {
            get { return _quantityProduct; }
            set { _quantityProduct = value; }
        }
        public bool ListaProdutos 
        {
            get { return _listProduct; }
            set { _listProduct = value; }
        }
        public string Delete
        {
            get { return _delete; }
            set { _delete = value; }
        }
        #endregion
        #region "Construtores"
        public Quotation()
        {
        }
        public Quotation(int idQuotation, int idUser, int idProvider, string nameProduct,
                int priceProduct, int quantityProduct, bool listProduct, string delete)
        {
            _idQuotation = idQuotation;
            _idUser = idUser;
            _idProvider = idProvider;
            _nameProduct = nameProduct;
            _priceProdut = priceProduct;
            _quantityProduct = quantityProduct;
            _listProduct = listProduct;
            _delete = delete;
        }
        #endregion
    }
}
