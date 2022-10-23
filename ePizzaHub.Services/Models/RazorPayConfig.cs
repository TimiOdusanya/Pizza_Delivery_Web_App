using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaHub.Services.Models
{
    public class RazorPayConfig
    {
        public string Key { get; set; }
        public string Secret { get; set; }

    }

    public class Response 
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public string Error { get; set; }
    }
}
