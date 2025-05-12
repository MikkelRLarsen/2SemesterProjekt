using _2SemesterProjekt.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2SemesterProjekt.Domain.Models
{
    public class Medicine
    {
        public int MedicineID { get; init; }
        public string Name { get; private set; }
        public string Type { get; private set; }
        public int DoseMiligram { get; private set; }
        public int DosesTake24Hours { get; private set; }
        public int DoseDurationDays { get; private set; }
        public DateTime? StartDate { get; private set; }
        public List<Examination> Examinations { get; }

        public Medicine(string name, string type, int doseMiligram, int dosesTake24Hours, int doseDurationDays)
        {
            Name = name;
            Type = type;
            DoseMiligram = doseMiligram;
            DosesTake24Hours = dosesTake24Hours;
            DoseDurationDays = doseDurationDays;
        }
        public void UpdateMedicineStartDate(DateTime newDate)
        {
            string displayMessage = "Dato er ikke gyldig.";
            try
            {
                if (newDate < DateTime.Now)
                {
                    StartDate = newDate;
                }
            }
            catch (Exception ex)
            {
                displayMessage += $"{ex}";
            }
        }
    }

}
