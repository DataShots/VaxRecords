using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaxRecords.Models
{
    public class User
    {
        public int UserId { get; set; }//Primary key
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        private static int nextId = 1;
        //Constructour for user class
        public User(string name, string password, string email) : this()
        {
            Name = name;
            Password = password;
            Email = email;
        }
        /*The Childs property is a navigation property. 
        Navigation properties hold other entities that are 
        related to this entity. In this case, the Childs
        property of a User entity will hold all of the child
        entities that are related to that user entity.*/
        public ICollection<Child> Childs { get; set; }
        
        //Need to work on this function
        public User()
        {
            UserId = nextId;
            nextId++;
        }

    }
}


   

