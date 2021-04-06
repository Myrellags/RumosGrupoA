using System;

namespace Inventory
{
    public class Inventory
    {
        #region "atributos"
        private int _idProduct;             //private int idProduto;
        private int _idStorage;             //private int idArmazem;
        private string _productDescription; //private string descricaoProduto;
        private string _nameInventory;      //private string nomeInventario;
        private int _newQuantity;           //private int novaQuantidade;
        #endregion


        #region "Porpriedades"

        public int idProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; }
        }

        public int idStorage
        {
            get { return _idStorage; }
            set { _idStorage = value; }
        }

        public string productDescription
        {
            get { return _productDescription; }
            set { _productDescription = value; }
        }

        public string nameInventor
        {
            get { return _nameInventory; }
            set { _nameInventory = value; }
        }
        public int newQuantity
        {
            get { return _newQuantity; }
            set { _newQuantity = value; }
        }


        #endregion
    }
}
