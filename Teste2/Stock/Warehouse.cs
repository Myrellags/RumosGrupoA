using System;

namespace Ecommerce.Stock
{
    public class Warehouse
    {
        // private string _idWarehouse; //private string _idArmazem
        // private string _descriptionWarehouse; //private string _descricaoArmazem

        #region "Propriedades"
        public int WarehouseID { get; set; }
        public string DescriptionWarehouse { get; set; }
        #endregion

        #region "Construtores"
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
