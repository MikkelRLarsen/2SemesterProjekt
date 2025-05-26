using _2SemesterProjekt.BlazorWebAssembly.Models;

namespace _2SemesterProjekt.BlazorWebAssembly.Services
{
    public class DestinationService
    {
        private List<Destination> _destinations = new();

        /// <summary>
        /// Initializes the service by loading destinations from local storage,
        /// or falling back to default data if none exists
        /// </summary>
        /// <returns></returns>
        public async Task InitializeAsync()
        {
            // Use default data if nothing is saved in local storage
            string content = GetDefaultDestinationString();

            await LoadFromStringAsync(content);
        }

        public List<Destination> GetAllDestinations()
        {
            return _destinations;
        }

        /// <summary>
        /// Loads destinations from default
        /// </summary>
        public async Task LoadFromStringAsync(string content)
        {
            // Splits by \n and removes if lines between splits are empty
            var lines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            var newList = new List<Destination>();

            foreach (var line in lines)
            {
                var split = line.Split(';');

                if (split.Length >= 3)
                {
                    // Create new destination from split data
                    newList.Add(new Destination(split[0], split[1], split[2]));
                }
            }

            _destinations = newList;
        }

        /// <summary>
        /// Proof of concept database
        /// </summary>
        private string GetDefaultDestinationString()
        {
            return "Harald Nyborg;6.5;HaraldNyborg.png\n" +
                   "Posthus (Strandgade);5.3;Posthus.png\n" +
                   "Silvan;10.9;Silvan.png\n" +
                   "Ugleapoteket;6.5;Ugleapoteket.png\n" +
                   "Kennel;13.1;Kennel.png\n" +
                   "Maxi Zoo;17.5;MaxiZoo.png\n" +
                   "Krematorie;30.8;Krematorie.png\n" +
                   "Angiv destination;ANGIV KILOMETER;Ukendt.png";
        }
    }
}
