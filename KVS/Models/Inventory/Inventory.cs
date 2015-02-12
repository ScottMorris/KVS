using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KVS.Models.Inventory
{
    public class Inventory
    {
	    public int ID { get; set; }
	    public InventoryItem InventoryItem { get; set; }
	    public Warehouse Warehouse { get; set; }
	    public int Quantity { get; set; }

		public DateTime CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
    }

    public class InventoryItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public uint Size { get; set; }
        public Unit Unit { get; set; }
        public decimal UnitCost { get; set; }
        public bool Active { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

	public class InventoryStatus
	{
		public int ID { get; set; }
		public string Name { get; set; }
	}
}