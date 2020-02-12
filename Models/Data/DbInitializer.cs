using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaxRecords.Models;

namespace VaxRecords.Data
{
    public class DbInitializer
    {
        public static void Initialize(VaccineContext context)
        {
            context.Database.EnsureCreated();
            // Look for any user
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }
            var users = new User[]
            {
            new User{UserId=1050,Name="Alexander Touch",Password="Touchmoney$" ,Email="touchisreal@aol.com"},
            new User{UserId=4022,Name="Chester Top",Password="TopChester!" ,Email="topchester@aol.com"},
            new User{UserId=4041,Name="Lisa Wall",Password="WallsofCash#" ,Email="lisahaswallsofcash@gmail.com"},
            new User{UserId=1045,Name="Sally Hemings",Password="HemingsismyDad$" ,Email="sallyhemings@call.com"}
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();
            var children = new Child[]
            {
            new Child{ChildId=2290,ChildName="Jill Touch",Age=3},
            new Child{ChildId=7805,ChildName="Tommy Top",Age=7},
            new Child{ChildId=3450,ChildName="Hector Wall",Age=6},
            new Child{ChildId=1778,ChildName="Sal Hemings",Age=12},
            };
            foreach (Child c in children)
            {
                context.Childs.Add(c);
            }
            context.SaveChanges();
            var vaccines = new Vaccine[]
            {
            new Vaccine{VaccineId=1,VaccineName="Measles",Description="A highly contagious viral infection in lungs.",Dosage=0.5f,Clinician="Holy Pedi"},
            new Vaccine{VaccineId=2,VaccineName="Whooping Cough",Description="A lung infection that makes it hard to breathe due to severe coughing.",Dosage=0.75f,Clinician="Pediatrics Home"},
            new Vaccine{VaccineId=3,VaccineName="Tetanus",Description=" A bacterial disease that causes lockjaw, breathing problems, muscle spasms, paralysis, and death.",Dosage=0.15f,Clinician="Dr. Khan Medical"},
            new Vaccine{VaccineId=4,VaccineName="Meningitis",Description=" Causes infection and swelling of the brain and spinal cord.",Dosage=0.05f,Clinician="Holy Pedi"},
            };
            foreach (Vaccine v in vaccines)
            {
                context.Vaccines.Add(v);
            }
            context.SaveChanges();
        }
    }
}
