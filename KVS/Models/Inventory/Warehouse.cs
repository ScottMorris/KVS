using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KVS.Models.Inventory
{
    public class Warehouse
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public WarehouseType WarehouseType { get; set; }
        
		public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

    public class WarehouseType
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}