using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Ecommerce.Billing

{
    public class SendOrder
    {
        
        #region "Propriedades"

        public int SendOrderID { get; set; }
        //[ForeignKey("SalesOrder")]
        public int SalesOrderID { get; set; } //pertence a que modulo e class?

        public string Status { get; set; }

      
        #endregion

        #region "Construtores"
        public SendOrder()
        {

        }

        public SendOrder(int idSalesOrder, int idSendOrder, string status)
        {
            SalesOrderID = idSalesOrder;
            SendOrderID = idSendOrder;
            Status = status;
        }

        #endregion

    }
}
