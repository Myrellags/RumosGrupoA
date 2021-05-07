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
    class InvoiceToReceiveDAO // PEDIDOS RECEBIDOS 
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
                result = db.InvoiceToReceives.FromSqlRaw("Select * From InvoiceToReceives order by Id").ToList();
            }
            return result;
        }

        //procurar InvoiceToReceive - /Invoice a receber ou Ordens a receber
        public IList<InvoiceToReceive> FiltraPorEstado(string Status)
        {
            Status = "0";

            IList<InvoiceToReceive> lista = contexto.InvoiceToReceives.Where(InvoiceToReceive => InvoiceToReceive.Status.Contains(Status)).ToList();
            return lista;

        }
    }
}
