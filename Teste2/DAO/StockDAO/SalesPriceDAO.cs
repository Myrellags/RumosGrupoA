using Ecommerce.Data;
using Ecommerce.Stock;
using System;
using System.Collections.Generic;
using System.Linq;

public class SalesPriceDAO
{
	private BDEcommerce contexto;

	public SalesPriceDAO(BDEcommerce contexto)
	{
		this.contexto = contexto;
	}
	public IList<SalesPrice> Lista()
	{
		var lista = contexto.SalesPrices.ToList();
		return lista;
	}
	public void calculatePriceSell (double pricePurchaseProduct, double priceSellProduct)
	{
		//return contexto.Product.Where(salesprice = priceSellProduct - pricePurchaseProduct).FirstOrDefault<>(ProfitMargin);
	}



}
