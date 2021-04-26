using System;

namespace Ecommerce.Stock
{
	public class Product
	{ 
		#region "PROPRIEDADES PRODUCT"
		public int ProductID { get; set; }
		public string NameProduct { get; set; }
		public string DescriptionProduct { get; set; }
		public string TypeProduct { get; set; }
		public double WeightProduct { get; set; }
		public string WarehouseProduct { get; set; }
		public bool DiscontinuedProduct { get; set; }
		public double PricePurchaseProduct { get; set; }
		public double PriceSellProduct { get; set; }
		public string CategoryProduct { get; set; }
		public string Delete { get; set; }


		#endregion
		#region "CONTRUTORES PRODUCT"
		public Product()
        {

        }
		public Product(string delete, string categoryProduct,  int idProduct, string nameProduct, string descriptionProduct, string typeProduct, double weightProduct, string warehouseProduct, bool discontinuedProduct, double pricePurchaseProduct, double priceSellProduct)
		{
			ProductID = idProduct;
			NameProduct = nameProduct;
			DescriptionProduct = descriptionProduct;
			TypeProduct = typeProduct;
			WeightProduct = weightProduct;
			DiscontinuedProduct = discontinuedProduct;
			PricePurchaseProduct = pricePurchaseProduct;
			PriceSellProduct = priceSellProduct;
			CategoryProduct = categoryProduct;
			Delete = delete;
			WarehouseProduct = warehouseProduct;
		}
		#endregion

	}

}

