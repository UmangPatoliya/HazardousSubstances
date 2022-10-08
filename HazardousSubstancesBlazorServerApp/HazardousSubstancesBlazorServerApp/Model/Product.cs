namespace HazardousSubstancesBlazorServerApp.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<string> Images { get; set; } = new List<string>();
        public string Description { get; set; }
        public List<string> Warning { get; set; }
        public List<string> Info { get; set; }
        public string Pdf { get; set; }
        public List<HazardNessLevel> HazardNessLevels { get; set;}
    }

    public class HazardNessLevel
    {
        public string HazardNessName { get; set; }
        public int Intensity { get; set; }
    }
}
