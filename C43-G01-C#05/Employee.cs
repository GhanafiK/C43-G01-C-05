using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_C_05
{
    internal class Employee
    {
        public string fname {  get; set; }
        public string lname {  get; set; }
        public Department department { get; set; }

    }

    internal class Department
    {
        public string name { get; set; }
        public int code { get; set; }
    }
}

