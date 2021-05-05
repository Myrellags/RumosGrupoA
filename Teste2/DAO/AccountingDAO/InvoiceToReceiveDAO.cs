using Ecommerce.Data;
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
    }
}
