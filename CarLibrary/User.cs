using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class User
    {
        public int userID { get; set; }
        public string carVIN { get; set; }
        public string email { get; set; }
        public string firstName {get;set;}
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}