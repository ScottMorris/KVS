using System;
using System.ComponentModel;

namespace KVS.Models.Clients
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}