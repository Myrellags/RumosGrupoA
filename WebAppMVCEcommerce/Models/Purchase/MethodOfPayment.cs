using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCEcommerce.Models.Purchase
{
    [Table("MethodOfPayments")]
    public class MethodOfPayment
    {
        #region "Propriedades"
        [Key]
        public int MethodOfPaymentID { get; set; }
        [Required]
        [StringLength(60)]
        public string NameMethodOfPayment { get; set; }
        [Required]
        public int TypeMethodOfPayment { get; set; }
        #endregion

        #region"Construtores MethodOfPayment"

        public MethodOfPayment()
        {

        }

        public MethodOfPayment(int idmethodofpayment, string namemethodofpayment, int typemethodofpayment)
        {
            MethodOfPaymentID = idmethodofpayment;
            NameMethodOfPayment = namemethodofpayment;
            TypeMethodOfPayment = typemethodofpayment;
        }
        #endregion
    }
}
