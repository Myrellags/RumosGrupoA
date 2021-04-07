using System;

namespace Costs
{
    public class Cost
    {
        #region "Atributos"
        private double _costsProvider;  //private double custosFornecedores;
        private double _costsProduct;   //private double custoProduto;
        private double _costsOthers;    //private double custosOutros;
        private string _typeOfCosts;    //private string tipoDeCusto;
        #endregion
    

    #region "Propriedades"

    public double costsProvider
    {
        get { return _costsProvider; }
        set { _costsProvider = value; }
    }

    public double costsProduct
    {
        get { return _costsProduct; }
        set { _costsProduct = value; }
    }

    public double costsOthers
    {
        get { return _costsOthers; }
        set { _costsOthers = value; }
    }

    public string typeOfCosts
    {
        get { return _typeOfCosts; }
        set { _typeOfCosts = value; }
    }

    #endregion
    }

}
