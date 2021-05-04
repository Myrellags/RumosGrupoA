using Ecommerce.Data;
using Ecommerce.Purchase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

public class InputInvoiceDAO
{
    private BDEcommerce contexto;

    public InputInvoiceDAO(BDEcommerce contexto)
    {
        this.contexto = contexto;
    }
    public IList<InputInvoice> Lista()
    {
        var lista = contexto.InputInvoices.ToList();
        return lista;
    }
    //Cria um nova invoice(adiciona, salva..)
    public void Adiciona(InputInvoice inputInvoice)
    {
        contexto.InputInvoices.Add(inputInvoice);
        contexto.SaveChanges();
    }
    //Buscar por invoice
    public IList<InputInvoice> FiltraPorNumeroInvoice(string numberInvoice)
    {
        IList<InputInvoice> lista = contexto.InputInvoices.Where(inputInvoice => inputInvoice.NumberII.Contains(numberInvoice)).ToList();
        return lista;
    }
    //Deletar
    public void Remove(string id)
    {
        InputInvoice i = new InputInvoice() { NumberII = id };
        contexto.InputInvoices.Remove(i);
        contexto.SaveChanges();
    }
    //Buscar invoice por ID, chave primária
    public InputInvoice BuscaPorId(int id)
    {
        InputInvoice InputInvoice = contexto.InputInvoices.Find(id);
        return InputInvoice;
    }
    //Update Invoice
    public void Atualiza(InputInvoice inputInvoice)
    {
        contexto.Entry(inputInvoice).State = EntityState.Modified;
        contexto.SaveChanges();
    }
}
