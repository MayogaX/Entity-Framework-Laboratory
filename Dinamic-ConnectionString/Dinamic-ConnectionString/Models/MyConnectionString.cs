using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dinamic_ConnectionString.Models
{
    public class MyConnectionString
    {
        public int Id { get; set; }
        public string ConnectionString { get; set; }
        public string UserName { get; set; }
    }
}