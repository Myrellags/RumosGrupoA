using System;

namespace Ecommerce.Stock
{
    public class Warehouse
    {

        #region "Propriedades Warehouse"
        public int WarehouseID { get; set; }
        public string DescriptionWarehouse { get; set; }
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
