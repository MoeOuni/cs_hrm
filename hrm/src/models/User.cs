using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrm
{
    internal class User
    {
        public int Id { get; set; }
        public string regNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string post { get; set; }
        public int cin { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public int leaveBalance { get; set; }
        public Boolean status { get; set; }

    }
}
