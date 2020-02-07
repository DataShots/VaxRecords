using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaxRecords.Models
{
    public class Child
    {
        public int ChildId { get; set; }//Primary key
        public string ChildName { get; set; }
        public int Age { get; set; }
        //public User User { get; set; }For navigation
        //public Vaccine Vaccine { get; set; }
        //Constuctor
        public Child(string childname, int age)
        {
            ChildName = childname;
            Age = age;
        }
    }
}

