using System;

public class ProductDAO
{
    private EcommerceContext contexto;

    public ProductDAO(EcommerceContext contexto)
    {
        this.contexto = contexto;
    }
    public IList<Product> Lista()
    {
        var lista = contexto.Product.ToList();
        return lista;
    }
    //Cria um novo produto(adiciona, salva..)
    public void Adiciona(Product product)
    {
        contexto.Product.Add(product);
        contexto.SaveChanges();
    }
    //Buscar por Categoria de produto
    public IList<Product> FiltraPorCategoria(string category)
    {
        IList<Product> lista = contexto.Product.Where(product => product._idCategory.Contains(category)).ToList();
        return lista;
    }
    //Deletar
    public void Remove(int id)
    {
        Product p = new Product() { _idProduct = id };
        contexto.Product.Remove(p);
        contexto.SaveChanges();
    }
    //Buscar produto por ID, chave primária
    public Product BuscaPorId(int id)
    {
        Product product = contexto.Productos.Find(id);
        return post;
    }
    //Update Produto
    public void Atualiza(Product product)
    {
        contexto.Entry(product).State = EntityState.Modified;
        contexto.SaveChanges();
    }
}
