using System;

namespace ProductCategory
{
    public enum typeC
    {
        Cozinha,
        Cama,
        Mesa,
        Banho,
        Jardim
    }
    public class ProductCategory
    {
        #region "Atributos"
        private int _idCategory;         //private int idCategoria;
        private string _nameCategory;   //private string nomeCategoria;
        private typeC _category;   //private string tipoCategoria;
        #endregion
    }
}
