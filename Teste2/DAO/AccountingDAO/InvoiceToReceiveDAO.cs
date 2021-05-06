using Ecommerce.Accounting;
using Ecommerce.Billing;
using Ecommerce.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DAO.AccountingDAO
{
    class InvoiceToReceiveDAO
    {
        private BDEcommerce contexto;

        public InvoiceToReceiveDAO(BDEcommerce contexto)
        {
            this.contexto = contexto;
        }
        public static List<InvoiceToReceive> GetInvoiceToPay()
        {
            List<InvoiceToReceive> result = new List<InvoiceToReceive>();
            using (var db = new BDEcommerce())
            {
                result = db.InvoiceToReceive.FromSqlRaw("Select * From InvoiceToReceive order by Id").ToList();
            }
            return result;
        }

        //procurar Open-Invoice/InvoiceOrders - tentei ligar à variavel status = true , na classe InvoiceOrders
        public IList<InvoiceOrder> FiltraPorEstado(string Status)
        {
            IList<InvoiceOrder> lista = contexto.InvoiceOrders.Where(InvoiceOrder => InvoiceOrder.Status.Contains(Status)).ToList();
            return lista;
        }
    }
}
