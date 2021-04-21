using System;

namespace Stock
{
    public class Warehouse
    {
        #region "Atributos"
        private string _idWarehouse; //private string _idArmazem
        private string _descriptionWarehouse; //private string _descricaoArmazem
        #endregion

        #region "Propriedades"

        public string IdWarehouse
        {
            get { return _idWarehouse; }
            set { _idWarehouse = value; }
        }

        public string DescriptionWarehouse
        {
            get { return _descriptionWarehouse; }
            set { _descriptionWarehouse = value; }
        }

        #endregion

        #region "Construtores"
        public Warehouse()
        {

        }

        public Warehouse(string idWarehouse, string descriptionWarehouse)
        {
            _idWarehouse = idWarehouse;
            _descriptionWarehouse = descriptionWarehouse;
        }
        #endregion
    }
}
