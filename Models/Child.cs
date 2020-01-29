using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaxRecords.Models 
{
    public class Child
    {
        public string ChildName { get; set;}
        public int Age { get; set;}

        public Child(string childname, int age)
        {
            ChildName = childname;
            Age = age;
        }
    }
}
