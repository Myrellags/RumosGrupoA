using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Order
{
    public class Category
    {

        #region "Atributos"
        private string _idCategoria; //private string idCategoria
        private string _nomeCategoria; //private string nomeCategoria
        #endregion

        #region "Propriedades"

        public string idCategoria
        {
            get { return _idCategoria; }
            set { _idCategoria = value; }
        }

        public string nomeCategoria
        {
            get { return _nomeCategoria; }
            set { _nomeCategoria = value; }
        }

        #endregion

        #region "Construtores"
        public Category()
        {

        }

        public Category(string idCategoria, string nomeCategoria)
        {
            _idCategoria = idCategoria;
            _nomeCategoria = nomeCategoria;
        }
        #endregion
    }
}