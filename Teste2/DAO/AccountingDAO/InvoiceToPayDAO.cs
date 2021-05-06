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
    class InvoiceToPayDAO
    {
        private BDEcommerce contexto;

        public InvoiceToPayDAO(BDEcommerce contexto)
        {
            this.contexto = contexto;
        }
        //procurar InvoiceToPay Busca SQL
        public static List<InvoiceToPay> GetInvoiceToPay()
        {
            List<InvoiceToPay> result = new List<InvoiceToPay>();
            using (var db = new BDEcommerce ())
            {
                result = db.InvoiceToPays.FromSqlRaw("Select * From InvoiceToPays order by Id").ToList();
            }
            return result;
        }
        //procurar c/ Linq Open-Invoice/InvoiceOrders ou Ordens em aberto
        public IList<InvoiceOrder> FiltraPorEstado(string Status)
        {
            Status = "0";

            IList<InvoiceOrder> lista = contexto.InvoiceOrders.Where(InvoiceOrder => InvoiceOrder.Status.Contains(Status)).ToList();
            return lista;

        }
    }

}
