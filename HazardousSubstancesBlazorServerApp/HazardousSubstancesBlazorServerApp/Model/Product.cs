namespace HazardousSubstancesBlazorServerApp.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ContactNo { get; set; }

        public List<string> Images { get; set; } = new List<string>();
        public string Description { get; set; }
        public List<string> Warning { get; set; }
        public List<string> Info { get; set; }
        public string Pdf { get; set; }
        public List<HazardNessLevel> HazardNessLevels { get; set;}

        public List<Record> Records { get; set; }
    }

    public class HazardNessLevel
    {
        public string HazardNessName { get; set; }
        public int Intensity { get; set; }
    }

    public class Record
    {
        public string ID { get; set; }
        public string Department { get; set; }
        public string Dokument { get; set; }
        public DateTime Datum { get; set; }
        public string Status { get; set; }
    }
}
