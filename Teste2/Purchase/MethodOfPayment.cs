using System;

namespace Ecommerce.Purchase
{
    public class MethodOfPayment
    {
        #region "Propriedades"
        public int MethodOfPaymentID { get; set; }
        public string NameMethodOfPayment { get; set; }
        public int TipeMethodOfPayment { get; set; }
        #endregion

        #region"Construtores MethodOfPayment"

        public MethodOfPayment()
        {

        }

        public MethodOfPayment(int idmethodofpayment, string namemethodofpayment, int tipemethodofpayment)
        {
            MethodOfPaymentID = idmethodofpayment;
            NameMethodOfPayment = namemethodofpayment;
            TipeMethodOfPayment = tipemethodofpayment;
        }
        #endregion
    }

}
