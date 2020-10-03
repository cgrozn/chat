using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CagriSignalR.Models
{
    public class Messages
    {
        public int ID { get; set; }
        public string UserName { get; set; }

        public string Message { get; set; }
    }
}