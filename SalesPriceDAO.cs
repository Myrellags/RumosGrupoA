using System;

public class SalesPriceDAO
{
	private EcommerceContext contexto;

	public SalesPriceDAO(EcommerceContext contexto)
	{
		this.contexto = contexto;
	}
	public IList<SalesPrice> Lista()
	{
		var lista = contexto.SalesPrice.ToList();
		return lista;
	}
	public calculatePriceSell (double pricePurchaseProduct, double priceSellProduct)
	{
		return contexto.Product
					.Where(salesprice = priceSellProduct - pricePurchaseProduct)
					.FirstOrDefault<>(ProfitMargin);
	}



}
