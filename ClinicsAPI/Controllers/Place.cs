namespace ClinicsAPI.Controllers
{
    public class Place
    {
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Phone { get; set; }
        public double Rate { get; set; }
        public string AddressClinic { get; set; }
        public double? Distance { get; set; }
    }
}
