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
		private double _weightProduct;
		private string _providerProduct;
		private bool _discontinuedProduct;
		private double _pricePurchaseProduct;
		private double _priceSellProduct;
		#endregion
		#region "PROPRIEDADES PRODUCT"
		public int IdProduct;
		{
			get { return _idProduct; }
			set { _idProduct = value; }
		}

	}
}
    

