using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    public class Address
    {
        public int EmpId { get; set; }
        public string empFirstName { get; set; }
        public string empLastName { get; set; }
        public string Adress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string Zip { get; set; }
        public string email { get; set; }
        public int contact { get; set; }
    }
}