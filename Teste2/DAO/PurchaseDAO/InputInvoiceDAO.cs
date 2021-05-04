using System;

public class InputInvoiceDAO
{
    private EcommerceContext contexto;

    public InputInvoiceDAO(EcommerceContext contexto)
    {
        this.contexto = contexto;
    }
    public IList<InputInvoice> Lista()
    {
        var lista = contexto.InputInvoice.ToList();
        return lista;
    }
    //Cria um nova invoice(adiciona, salva..)
    public void Adiciona(InputInvoice inputInvoice)
    {
        contexto.InputInvoice.Add(inputInvoice);
        contexto.SaveChanges();
    }
    //Buscar por invoice
    public IList<InputInvoice> FiltraPorNumeroInvoice(string numberInvoice)
    {
        IList<InputInvoice> lista = contexto.InputInvoice.Where(inputInvoice => inputInvoice._numberII.Contains(numberInvoice)).ToList();
        return lista;
    }
    //Deletar
    public void Remove(int id)
    {
        InputInvoice i = new InputInvoice() { _idII = id };
        contexto.InputInvoice.Remove(i);
        contexto.SaveChanges();
    }
    //Buscar invoice por ID, chave primária
    public InputInvoice BuscaPorId(int id)
    {
        InputInvoice InputInvoice = contexto.InputInvoiceos.Find(id);
        return post;
    }
    //Update Invoice
    public void Atualiza(InputInvoice inputInvoice)
    {
        contexto.Entry(inputInvoice).State = EntityState.Modified;
        contexto.SaveChanges();
    }
}
