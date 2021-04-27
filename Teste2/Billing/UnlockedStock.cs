using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Billing
{
    public class UnlockedStock
    {
        #region "Atributos"
        private int _idUnlocked;  //private int idUnlocked;
        private int _idProduct;   //private int idProduto;
        private string _status;     //private string status;
        #endregion

        #region "Propriedades"

        public int UnlockedID { get; set; }

        [ForeignKey("ProductI")]
        public int ProductID { get; set; }
        public string Status { get; set; }
        
        #endregion

        #region "Construtores"
        public UnlockedStock()
        {

        }

        public UnlockedStock(int idUnlocked, int idProduct, string status)
        {
            UnlockedID = idUnlocked;
            ProductID = idProduct;
            Status = status;
        }

        #endregion

    }

}
