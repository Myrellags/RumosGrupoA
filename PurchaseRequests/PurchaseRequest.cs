using System;

namespace Purchase
{
    public class PurchaseRequest
    {
        #region "Atributos"
        private int _idQuotation;            //private int idOrcamento;
        private int _idPurchaseRequest;      //private int idPedidoCompra;
        private bool _okay;                  //private bool aprovado;
        private int _idMethodOfPayment;      //private int idCondicaoPagamento;
        private double _campaignProvider;    //private double campanhaFornecedor;
        #endregion

        #region "Propriedades"

        public int idQuotation
        {
            get { return _idQuotation; }
            set { _idQuotation = value; }
        }

        public int idPurchaseRequest
        {
            get { return _idPurchaseRequest; }
            set { _idPurchaseRequest = value; }
        }

        public bool okay
        {
            get { return _okay; }
            set { _okay = value; }
        }

        public int idMethodOfPayment
        {
            get { return _idMethodOfPayment; }
            set { _idMethodOfPayment = value; }
        }

        public double campaignProvider
        {
            get { return _campaignProvider; }
            set { _campaignProvider = value; }
        }
        #endregion

        #region"Construtores"

        public PurchaseRequest()
        {

        }

        public PurchaseRequest (int idQuotation, int idPurchaseRequest, bool okay, int idMethodOfPayment, double campaignProvider)
        {
            _idQuotation = idQuotation;
            _idPurchaseRequest = idPurchaseRequest;
            _okay = okay;
            _idMethodOfPayment = idMethodOfPayment;
            _campaignProvider = campaignProvider;
        }
        #endregion
    }
}
