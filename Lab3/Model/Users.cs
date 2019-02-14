using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    public class Users
    {
        public List<results> results = new List<results>();
    }

    public class results
    {
        public string gender { get; set; }
        public name name { get; set; }

        public location location { get; set; }
       

    }
    public class name
    {
        public string title { get; set; }
        public string first { get; set; }
        public string last { get; set; }

    }
    public class location
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postcod { get; set; }

    }
}
