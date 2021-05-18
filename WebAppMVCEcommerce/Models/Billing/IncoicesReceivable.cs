using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebAppMVCEcommerce.Models.Stock;
using WebAppMVCEcommerce.Models.Purchase;

namespace WebAppMVCEcommerce.Models.Billing
{
    [Table("InvoicesReceivables")]
    public class InvoicesReceivable // Pedidos de Venda 
    {

        #region "PROPRIEDADES PEDIDOS DE VENDA" 
        [Key]
        public int InvoicesReceivableID { get; set; }
        [ForeignKey("Customer")]
        public int CostumerID { get; set; }
        public virtual Costumer Costumer { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        [ForeignKey("ShoppingCar")]
        public int ShoppingCarID { get; set; }
        public virtual ShoppingCar ShoppingCar { get; set; }
        [ForeignKey("MethodOfPayment")]
        public int MethodOfPaymentID { get; set; }
        public virtual MethodOfPayment MethodOfPayment { get; set; }
        public int AmountProduct { get; set; }
        public double PriceProduct { get; set; }
        public double WeightProduct { get; set; }
        public string Delete { get; set; }
        public double DiscountCoupon { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Stock.Product> Products { get; set; }

        #endregion

        #region "construtores PEDIDOS DE VENDA"
        public InvoicesReceivable()
        {

        }
        public InvoicesReceivable(int idInvoicesReceivable, int idCostumer, int idProduct, int idShoppingCar, int idMethodOfPayment, int amountProduct, double priceProduct, double weightProduct,
                        string delete, double discountCoupon, string status)
        {
            InvoicesReceivableID = idInvoicesReceivable;
            CostumerID = idCostumer;
            ProductID = idProduct;
            ShoppingCarID = idShoppingCar;
            MethodOfPaymentID = idMethodOfPayment;
            AmountProduct = amountProduct;
            PriceProduct = priceProduct;
            WeightProduct = weightProduct;
            Delete = delete;
            DiscountCoupon = discountCoupon;
            Status = status;

        }
        #endregion
    }
}
