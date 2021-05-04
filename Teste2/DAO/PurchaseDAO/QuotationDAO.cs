using Ecommerce.Data;
using Ecommerce.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;

public class QuotationDAO
{
    private BDEcommerce contexto;

    public QuotationDAO(BDEcommerce contexto)
    {
        this.contexto = contexto;
    }
    public IList<Quotation> Lista()
    {
        var lista = contexto.Quotations.ToList();
        return lista;
    }
    //Cria uma nova cotação(adiciona, salva..)
    public void Adiciona(Quotation quotation)
    {
        contexto.Quotations.Add(quotation);
        contexto.SaveChanges();
    }
}
