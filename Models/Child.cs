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
        private static int nextId = 1;
        //public User User { get; set; }For navigation
        //public Vaccine Vaccine { get; set; }
        //Constuctor
        public Child(int childId,string childname, int age)
        {
            ChildId = childId;
            ChildName = childname;
            Age = age;
        }
        public Child()
        {
           ChildId = nextId;
            nextId++;
        }
    }
}

