using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrm
{
    internal class Request
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string type { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string motif { get; set; }
        public DateTime requestedAt { get; set; }
        public string status { get; set; }
    }
}
