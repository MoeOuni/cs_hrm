using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrm
{
    internal class Request
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string type { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string motif { get; set; }
        public DateTime requestedAt { get; set; }
        public string status { get; set; }
        public int requestedBy { get; set; }

        public override string ToString()
        {
            return $"ID: {id}\n" +
                   $"First Name: {firstName}\n" +
                   $"Last Name: {lastName}\n" +
                   $"Type: {type}\n" +
                   $"Start Date: {startDate}\n" +
                   $"End Date: {endDate}\n" +
                   $"Motif: {motif}\n" +
                   $"Requested At: {requestedAt}\n" +
                   $"Status: {status}";
        }
    }
}
