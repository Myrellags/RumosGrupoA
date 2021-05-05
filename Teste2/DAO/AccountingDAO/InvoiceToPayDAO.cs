﻿using Ecommerce.Accounting;
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
        
        public static List<InvoiceToPay> GetInvoiceToPay()
        {
            List<InvoiceToPay> result = new List<InvoiceToPay>();
            using (var db = new BDEcommerce ())
            {
                result = db.InvoiceToPays.FromSqlRaw("Select * From InvoiceToPay order by Id").ToList();
            }
            return result;
        }
    }

}
