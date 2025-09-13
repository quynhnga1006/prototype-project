using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrototypePattern.Models
{
    public class Report
    {
        public string ReportType { get; set; }
        public Order OrderDetails { get; set; }
        public string UserName { get; set; }
    }
}