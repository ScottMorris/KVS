using KVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KVS.Models.Clients;
using KVS.Models.Inventory;

namespace KVS.Dal
{
    public class DatabaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            //base.Seed(context);
            var clients = new List<Client>
            {
                new Client {Created = DateTime.Now, EmailAddress = "a@b.com", Name = "John Smith"}
            };
	        context.Clients.AddRange(clients);
            context.SaveChanges();

	        var mainWarehouseType = new WarehouseType() {Name = "Main"};
	        var truckWarehouseType = new WarehouseType() {Name = "Truck"};
			var warehouseTypes = new List<WarehouseType>
	        {
		        mainWarehouseType,
		        truckWarehouseType,
	        };
			context.WarehouseTypes.AddRange(warehouseTypes);
			context.SaveChanges();

	        var warehouses = new List<Warehouse>
	        {
		        new Warehouse() {CreatedDate = DateTime.Now, Location = "Jeff's Hall in the Country", Name = "Hall", WarehouseType = mainWarehouseType},
		        new Warehouse() {CreatedDate = DateTime.Now, Location = "The Open Road", Name = "Kevin", WarehouseType = truckWarehouseType},
	        };
	        context.Warehouses.AddRange(warehouses);
	        context.SaveChanges();
        }
    }
}