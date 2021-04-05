using System;

namespace Product
{
	public class Product
	{
		#region "ATRIBUTOS PRODUCT"
		private int _idProduct; 
		private string _nameProduct;
		private string _descriptionProduct;
		private string _typeProduct;
		private string _categoryProduct;
		private double _weightProduct;
		private string _warehouseProduct;
		private double _pricePurchaseProduct;
		private double _priceSellProduct;
		private bool _discontinuedProduct;
		private string _delete;

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
		public string ProviderProduct
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
		#region "CONTRUTORES"
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
		_warehouseProduct = warehouseProduct;
		_discontinuedProduct = discontinuedProduct;
			_pricePurchaseProduct = pricePurchaseProduct;
			_priceSellProduct = priceSellProduct;
			_categoryProduct = categoryProduct;
			_delete = delete;

	    }
		#endregion

	}

}

