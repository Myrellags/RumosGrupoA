using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock
{
    [Table("Warehouse")]
    public class Warehouse
    {

        #region "Propriedades Warehouse"
        public int WarehouseID { get; set; }
        public string DescriptionWarehouse { get; set; }

        public virtual ICollection<Stock.Product> Products { get; set; }
        #endregion

        #region "Construtores Warehouse"
        public Warehouse()
        {

        }

        public Warehouse(int idWarehouse, string descriptionWarehouse)
        {
            WarehouseID = idWarehouse;
            DescriptionWarehouse = descriptionWarehouse;
        }
        #endregion
    }
}
