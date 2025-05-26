using _2SemesterProjekt.BlazorWebAssembly.Models;

namespace _2SemesterProjekt.BlazorWebAssembly.Services
{
    public class MailService
    {
        // Default email recipient address used when generating mail
        private readonly string _defaultReciever;

        // Constructor injecting the default recipient email address (configured in Program.cs)
        public MailService(string defaultReciever)
        {
            _defaultReciever = defaultReciever;
        }

        /// <summary>
        /// Generates a "mailto" link based on the given employee and destination
        /// </summary>
        public string GenerateMail(Employee employee, Destination destination)
        {
            // Null-check to ensure both employee and destination are selected before generating the mail link
            if (employee == null || destination == null)
            {
                return string.Empty;
            }

            DateTime date = DateTime.Now;

            // Format content
            string content = $"Chauffør: {employee.Name}\n" +
                             $"Destination: {destination.EndLocation}\n" +
                             $"Antal km kørt: {destination.DistanceKm} km\n" +
                             $"Dato for kørsel: {date:dd-MM-yyyy}";

            // Format subject
            string subject = $"Kørselsregistrering {date:dd-MM-yyyy}";

            // Contruct the mailto, Uri.EscapeDataString ensures proper encoding (line breaks)
            string mailto = $"mailto:{_defaultReciever}?subject={subject}&body={Uri.EscapeDataString(content)}";

            return mailto;
        }
    }
}
