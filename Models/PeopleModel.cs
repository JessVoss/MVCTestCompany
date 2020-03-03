using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTestCompany.Models
{
    public class PeopleModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public string depNumber { get; set; }
        public char type { get; set; } = 's';
        public bool isActive { get; set; } = true;
    }
}