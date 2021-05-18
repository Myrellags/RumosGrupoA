using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMVCEcommerce.Models.Stock
{
    [Table("Categorys")]
    public class Category
    {
        #region "Propriedades Category"

        [Key]
        public int CategoryID { get; set; }
        [Required] 
        [StringLength(150)]                    
        public string NameCategory { get; set; }

        
        #endregion

        #region "Construtores Category"
        public Category()
        {

        }

        public Category(int categoryID, string nameCategory)
        {
            CategoryID = categoryID;
            NameCategory = nameCategory;
        }
        #endregion
    }
}
