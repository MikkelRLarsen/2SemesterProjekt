using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2SemesterProjekt.Domain.Models;

namespace _2SemesterProjekt.Pages.UserControls.UIModels
{
    internal static class VeterinarianListBuilder
    {
        /// <summary>
        /// Returns a new list of veterinarians with the primary veterinarian placed first,
        /// followed by the remaining veterinarians in their original order (excluding the primary).
        /// </summary>
        /// <param name="veterinarians"></param>
        /// <param name="primaryVetId"></param>
        /// <returns></returns>
        public static List<Employee> GetVeterinariansWithPrimaryFirst(IEnumerable<Employee> veterinarians, int? primaryVetId)
        {
            // Creates _employees to a manupilative list
            var vetList = veterinarians.ToList();

            // Gets the primary vet by ID
            Employee primaryVet = veterinarians.First(e => e.EmployeeID == primaryVetId);

            // Removes the primary vet from the list so we can add it as range
            vetList.Remove(primaryVet);

            // Creates a new list with primary vet on index 0
            var listWithPrimaryVetOnTop = new List<Employee>() { primaryVet };

            // Adds the other vets to the new list
            listWithPrimaryVetOnTop.AddRange(vetList);

            return listWithPrimaryVetOnTop;
        }
    }
}
