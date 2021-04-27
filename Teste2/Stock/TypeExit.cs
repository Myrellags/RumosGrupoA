using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock
{
    public class TypeExit

    {
        #region "PROPRIEDADES TYPEEXIT"
        public int ProductID { get; set; }
        public int WarehouseID { get; set; }
        public string Typeexit { get; set; }

        public List<Stock.Product> Products { get; set; }
        public List<Stock.Warehouse> Warehouses { get; set; }
        #endregion

        #region "CONSTRUTORES TYPEEXIT"
        public TypeExit()
        {

        }

        public TypeExit(int idProduct, int idWarehouse, string typeexit)
        {
            ProductID = idProduct;
            WarehouseID = idWarehouse;
            Typeexit = typeexit;
        }
        #endregion
    }


}
