﻿using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace Ecommerce.Stock
{
    public class Category
    {
        #region "Propriedades"

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

        #region "Construtores"
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