using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock
{
    [Table("Categorys")]
    public class Category
    {
        #region "Propriedades Category"

        [Key]
        public int CategoryID { get; set; }
        [Required] // => na BD a coluna vai ser gerada com nullable: false
        [StringLength(60)] // => na BD a coluna vai ser gerada com tipo de dados nvarchar(60)
        public string NameCategory { get; set; }

        public Ecommerce.Stock.Category Category1
        {
            get => default;
            set
            {
            }
        }
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