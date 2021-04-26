using System;

namespace Stock
{
    public class Inventory
    {
        #region "atributos"
        private int _idProduct;             //private int idProduto;
        private int _idWarehouse;           //private int idArmazem;
        private string _productDescription; //private string descricaoProduto;
        private string _nameInventory;      //private string nomeInventario;
        private int _newQuantity;           //private int novaQuantidade;
        #endregion


        #region "PROPRIEDADES INVENTORY"

        public int idProduct
        {
            get { return _idProduct; }
            set { _idProduct = value; }
        }

        public int IdWarehouse
        {
            get { return _idWarehouse; }
            set { _idWarehouse = value; }
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
        #region "CONTRUTORES INVENTORY"
        public Inventory()
        {

        }
        public Inventory(int idProduct, int idWarehouse, string productDescription, string nameInventory,int newQuantity)
        {
            _idProduct = idProduct;
            _idWarehouse = idWarehouse;
            _productDescription = productDescription;
            _nameInventory = nameInventory;
            _newQuantity = newQuantity;
        }
        #endregion

    }
}
