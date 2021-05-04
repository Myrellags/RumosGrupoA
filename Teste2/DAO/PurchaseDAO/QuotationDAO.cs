using System;

public class QuotationDAO
{
    private EcommerceContext contexto;

    public QuotationDAO(EcommerceContext contexto)
    {
        this.contexto = contexto;
    }
    public IList<Quotation> Lista()
    {
        var lista = contexto.Quotation.ToList();
        return lista;
    }
    //Cria uma nova cotação(adiciona, salva..)
    public void Adiciona(Quotation quotation)
    {
        contexto.Quotation.Add(quotation);
        contexto.SaveChanges();
    }
}
