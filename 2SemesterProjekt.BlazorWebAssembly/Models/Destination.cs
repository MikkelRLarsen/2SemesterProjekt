namespace _2SemesterProjekt.BlazorWebAssembly.Models
{
    public class Destination
    {
        public string EndLocation { get; set; }
        public string DistanceKm { get; set; }
        public string LocationImage { get; set; }

        public Destination(string endLocation, string distanceKm, string image)
        {
            EndLocation = endLocation;
            DistanceKm = distanceKm;
            LocationImage = image;
        }
    }
}
