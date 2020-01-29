using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaxRecords.Models
{
    public class User
    {
            public string Name { get; set; }
            public string Password { get; set; }

            public string Email { get; set; }
            public int UserId { get; set; }
            private static int nextId = 1;

            public User(string name,string password,string email) : this()
            {
                Name = name;
                Password= password;
                Email = email; 
            }

            public User()
            {
                UserId = nextId;
                nextId++;
            }

            // override object.Equals
            /*public override bool Equals(object obj)
            {

                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                return UserId == (obj as User).UserId;
            }*/

            // override object.GetHashCode
            public override int GetHashCode()
            {
                return UserId;
            }
        }
    }


