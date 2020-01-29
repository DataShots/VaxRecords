using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaxRecords.Models
{
    public class Vaccine
    {
        public string VaccineName { get; set; }
        public string Description { get; set; }
        public float Dosage { get; set; }
        public string Place { get; set; }


        public Vaccine(string vaccinename, string description, float dosage, string place)
        { 
            VaccineName = vaccinename;
            Description = description;
            Dosage = dosage;
            Place = place;

        }
    }
    
    

}
