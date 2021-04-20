using System;

namespace ProductCategory
{
    public enum typeC     // myrella nao entendo este conceito, pq class enum aqui? ass roger 
    {
        Cozinha,            //Um enum define uma lista precadastrada, utilizei o conceito aqui para carregar um combobox com estas opções, ta;vez isso mude
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
