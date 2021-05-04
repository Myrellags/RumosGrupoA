using Ecommerce.Data;
using Ecommerce.Stock;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

public class ProductDAO
{
    private BDEcommerce contexto;

    public ProductDAO(BDEcommerce contexto)
    {
        this.contexto = contexto;
    }
    public IList<Product> Lista()
    {
        var lista = contexto.Products.ToList();
        return lista;
    }
    //Cria um novo produto(adiciona, salva..)
    public void Adiciona(Product product)
    {
        contexto.Products.Add(product);
        contexto.SaveChanges();
    }
    //Buscar por Categoria de produto
    public IList<Product> FiltraPorCategoria(string category)
    {
        IList<Product> lista = contexto.Products.Where(product => product.CategoryProduct.Contains(category)).ToList();
        return lista;
    }
    //Deletar
    public void Remove(int id)
    {
        Product p = new Product() { ProductID = id };
        contexto.Products.Remove(p);
        contexto.SaveChanges();
    }
    //Buscar produto por ID, chave primária
    public Product BuscaPorId(int id)
    {
        Product product = contexto.Products.Find(id);
        return product;
    }
    //Update Produto
    public void Atualiza(Product product)
    {
        contexto.Entry(product).State = EntityState.Modified;
        contexto.SaveChanges();
    }
}
