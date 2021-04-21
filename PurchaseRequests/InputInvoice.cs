using System;

namespace Purchase
{
    public class InputInvoice // notas de encomenda 
    {
        #region "Atributos"
        private int _idII;                  //private int idNE;
        private int _idProvider;            //private int idFornecedor;
        private string _numberII;           //private string numeroNE;
        private DateTime _dateII;           //private DateTime dataEmissaoNE;
        private int _idProduct;             //private int idProduto;
        private string _nameProduct;        //private string nomeProduto;
        private int _qtdProduct;            //private int qtdProduto;
        private double _priceProduct;       //private double valorProduto;
        private double _campaignProvider;   //private double campanhaFornecedor;
        private int _idMethodOfPayment;     //private int idCondicaoPagamento;
        #endregion

        #region "Propriedades"
        public int IdII
        {
            get { return _idII; }
            set { _idII = value; }
        }
        public int IdProvider
        {
            get { return _idProvider; }
            set { _idProvider = value; }
        }
        public string NumberII
        {
            get { return _numberII; }
            set { _numberII = value; }
        }
        public DateTime DateII
        {
            get { return _dateII; }
            set { _dateII = value; }
        }
        public int IdProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; }
        }
        public string NameProduct        {
            get { return _nameProduct; }
            set { _nameProduct = value; }
        }
        public int QtdProduct
        {
            get { return _qtdProduct; }
            set { _qtdProduct = value; }
        }
        public double PriceProduct
        {
            get { return _priceProduct; }
            set { _priceProduct = value; }
        }
        public double CampaignProvider
        {
            get { return _campaignProvider; }
            set { _campaignProvider = value; }
        }
        public int IdMethodOfPayment
        {
            get { return _idMethodOfPayment; }
            set { _idMethodOfPayment = value; }
        }
        #endregion

        #region "Construtores"
        public InputInvoice()
        {

        }
        public InputInvoice(int idII, int idProvider, string numberII, DateTime dateII, int idProduct,  
                            string nameProduct, int qtdProduct, double priceProduct, double campaignProvider,
                            int idMethodOfPayment)
        {
            _idII = idII;
            _idProvider = idProvider; 
            _numberII = numberII;   
            _dateII = dateII;     
            _idProduct = idProduct;  
            _nameProduct = nameProduct;
            _qtdProduct = qtdProduct; 
            _priceProduct = priceProduct;
            _campaignProvider = campaignProvider;
            _idMethodOfPayment = idMethodOfPayment;
        }
        #endregion
    }
}
