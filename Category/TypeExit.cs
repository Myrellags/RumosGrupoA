using System;

namespace TypeExit
{
    public enum TE
    {
        Venda,
        Roubo,
        Troca,
        Armazém,
        Dano
    }
    public class TypeExit
    {
        #region "atributos"
        private int _idProduct;   //private int idProduto;
        private int _idWarehouse;   //private int idArmazem;
        private TE _typeExit;     //private string tipoSaida;
        #endregion
    }
}
