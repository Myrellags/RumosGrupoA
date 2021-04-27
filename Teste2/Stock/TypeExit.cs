using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Stock
{
    public class TypeExit

    {
        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }
        public string Typeexit { get; set; }

        public TypeExit()
        {

        }

        public TypeExit(int idProduct, int idWarehouse, string typeexit)
        {
            ProductID = idProduct;
            WarehouseID = idWarehouse;
            Typeexit = typeexit;
        }

    }

   
}
