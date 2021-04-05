using System;

namespace UnlockedStocks
{
	public class UnlockedStocks
	{
		#region "Atributos"
		private string _idProduto; //private string Produto
		private int _quantidade; // private int Quantidade
		private float _precosemiva; //private int Precosemiva
		private float _precocomiva; //private int Precocomiva
		private string _local; //private string Local
		#endregion
	

	#region "Propriedades"

	public string IdProduct
	{
		get { return _idProduct; }
		set { _idProduct = value; }
	}

	public int Quantidade
	{
		get { return _quantidade; }
		set { _quantidade = value; }
	}

	public float PrecosemIVA
	{
		get { return _precosemiva; }
		set { _precosemiva = value; }
	}

	public float PrecocomIVA
	{
		get { return _precocomiva; }
		set { _precocomiva = value; }
	}

	public string Local
	{
		get { return _local; }
		set { _local = value; }
	}

	#endregion

	#region "Construtores"

	public Product(string idProduct, int quantidade, float precosemiva, float precocomiva, string local)
	
	{
	_idProduct = idProduct;
	_quantidade = quantidade;
	_precosemiva = precosemiva;
	_precocomiva = precocomiva;
	_local = local;
	}
	#endregion
	}
	
}