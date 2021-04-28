using System;


namespace Ecommerce.Stock
{
    public class Category
    {
        #region "Propriedades Category"

        public int CategoriaID { get; set; }
        public string NomeCategoria { get; set; }
        public Ecommerce.Stock.Category Category1
        {
            get => default;
            set
            {
            }
        }
        #endregion

        #region "Construtores Category"
        public Category()
        {

        }

        public Category(int idCategoria, string nomeCategoria)
        {
            CategoriaID = idCategoria;
            NomeCategoria = nomeCategoria;
        }
        #endregion
    }
}