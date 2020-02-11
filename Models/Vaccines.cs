using System;
using System.Collections.Generic;

namespace VaxRecords.Models
{
    public partial class Vaccines
    {
        public int VaccineId { get; set; }
        public string Vaccine { get; set; }
        public string Date { get; set; }
        public string Dose { get; set; }
        public string Method { get; set; }
        public string Clinician { get; set; }
        public string Notes { get; set; }
    }
}
