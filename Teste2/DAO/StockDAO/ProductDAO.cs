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
    public static bool DeleteProduct(Product p)
    {
        bool result = false;
        using (var db = new BDEcommerce())
        {
            db.Products.Remove(p);
            result = (db.SaveChanges() == 1);
        }

        return result;
    }
    //Buscar produto por ID, chave primária
    public Product BuscaPorId(int id)
    {
        Product product = contexto.Products.Find(id);
        return product;
    }
    //Buscar por categoria
    public static List<Product> GetProducts(string tipo)
    {
        List<Product> result = new List<Product>();
        using (var db = new BDEcommerce())
        {
            result = db.Products.Where(f => f.CategoryProduct.Contains(tipo)).OrderBy(f => f.ProductID).ToList(); 
            db.Products.OrderBy(f => f.CategoryProduct).ToList();
        }
        return result;
    }
    //Update Produto
    public static bool UpdateProduct(Product p)
    {
        bool result = false;
        using (var db = new BDEcommerce())
        {
            db.Products.Update(p);
            result = (db.SaveChanges() == 1);
        }

        return result;
    }
}
