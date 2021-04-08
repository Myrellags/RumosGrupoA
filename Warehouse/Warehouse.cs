using System;

namespace Warehouse
{
    public class Warehouse
    {
        #region "Atributos"
        private string _idWarehouse; //private string _idArmazem
        private string _descritionWarehouse; //private string _descricaoArmazem
        #endregion

        #region "Propriedades"

        public string IdWarehouse
        {
            get { return _idWarehouse; }
            set { _idWarehouse = value; }
        }

        public string DescriptionWarehouse
        {
            get { return _descritionWarehouse; }
            set { _descritionWarehouse = value; }
        }

        #endregion

        #region "Construtores"
        public Warehouse()
        {

        }

        public Warehouse(string idWarehouse, string descriptionWarehouse)
        {
            _idWarehouse = idWarehouse;
            _descritionWarehouse = descriptionWarehouse;
        }
        #endregion
    }
}
