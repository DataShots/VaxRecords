using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaxRecords.Models
{
    public class Vaccine
    {
        public int VaccineId { get; set; } //Primary keys
        public string VaccineName { get; set; }
        public string Description { get; set; }
        public float Dosage { get; set; }
        public string Place { get; set; }

        //The Child property is a navigation property.A vaccine entity can be related to any number of Child entities.
        public ICollection<Child> Childs { get; set; }

        //Constructor
        public Vaccine(string vaccinename, string description, float dosage, string place)
        {
            VaccineName = vaccinename;
            Description = description;
            Dosage = dosage;
            Place = place;

        }
    }
}
