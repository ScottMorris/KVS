using KVS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();
        }
    }
}