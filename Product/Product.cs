using System;

namespace Product
{
	public class Product
	{
		#region "ATRIBUTOS PRODUCT"
		private int _idProduct;  // ID DO PRODUTO 
		private string _nameProduct; // NOME DO PRODUTO
		private string _descriptionProduct; // DESCRIÇÃO DO PRODUTO
		private string _typeProduct; // TIPO DE PRODUTO
		private string _categoryProduct; // CATEGORIA DO PRODUTO
		private double _weightProduct;  // PESO DO PRODUTO
		private string _warehouseProduct;  // ARMAZEM DE ORIGEM
		private double _pricePurchaseProduct; // PRECO DE COMPRA DO PRODUTO
		private double _priceSellProduct;  // PRECO DE VENDA DO PRODUTO
		private bool _discontinuedProduct; // PRODUTO DESCONTINUADO 
		private string _delete; // FALAR COM MYRELLA (CONCEITO DE DELETE SEM APAGAR)

		#endregion
		#region "PROPRIEDADES PRODUCT"
		public int IdProduct
		{
			get { return _idProduct; }
			set { _idProduct = value; }
		}
		public string NameProduct
		{
			get { return _nameProduct; }
			set { _nameProduct = value; }
		}
		public string DescriptionProduct
		{
			get { return _descriptionProduct; }
			set { _descriptionProduct = value; }
		}
		public string TypeProduct
		{
			get { return _typeProduct; }
			set { _typeProduct = value; }
		}
		public double WeightProduct
		{
			get { return _weightProduct; }
			set { _weightProduct = value; }
		}
		public string WarehouseProduct
		{
			get { return _warehouseProduct; }
			set { _warehouseProduct = value; }
		}
		public bool DiscontinuedProduct
		{
			get { return _discontinuedProduct; }
			set { _discontinuedProduct = value; }
		}
		public double PricePurchaseProduct
		{
			get { return _pricePurchaseProduct; }
			set { _pricePurchaseProduct = value; }
		}
		public double PriceSellProduct
		{
			get { return _priceSellProduct; }
			set { _priceSellProduct = value; }
		}
		public string CategoryProduct
		{
			get { return _categoryProduct; }
			set { _categoryProduct = value; }
		}
		public string Delete 
		{
			get { return _delete; }
			set { _delete = value; }
		}

		#endregion
		#region "CONTRUTORES PRODUCT"
		public Product()
        {

        }
		public Product(string delete, string categoryProduct,  int idProduct, string nameProduct, string descriptionProduct, string typeProduct, double weightProduct, string warehouseProduct, bool discontinuedProduct, double pricePurchaseProduct, double priceSellProduct)
		{
			_idProduct = idProduct;
			_nameProduct = nameProduct;
			_descriptionProduct = descriptionProduct;
			_typeProduct = typeProduct;
			_weightProduct = weightProduct;
		_discontinuedProduct = discontinuedProduct;
			_pricePurchaseProduct = pricePurchaseProduct;
			_priceSellProduct = priceSellProduct;
			_categoryProduct = categoryProduct;
			_delete = delete;
			_warehouseProduct = warehouseProduct;
		}
		#endregion

	}

}

