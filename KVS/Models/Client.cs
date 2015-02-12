using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KVS.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}