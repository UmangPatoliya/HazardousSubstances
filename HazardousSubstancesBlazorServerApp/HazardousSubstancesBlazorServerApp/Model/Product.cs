namespace HazardousSubstancesBlazorServerApp.Model
{
    /// <summary>
    /// Product information
    /// Information to display on UI
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product ID
        /// Folder of images and pdf created with ID of product
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name of product
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Contact number
        /// </summary>
        public string ContactNo { get; set; }

        /// <summary>
        /// Carousel images
        /// </summary>
        public List<string> Images { get; set; } = new List<string>();

        /// <summary>
        /// Description - 1
        /// </summary>
        public string Description_1 { get; set; }

        /// <summary>
        /// Description - 2
        /// </summary>
        public string Description_2 { get; set; }

        /// <summary>
        /// Description - 3
        /// </summary>
        public string Description_3 { get; set; }

        /// <summary>
        /// List of informations
        /// </summary>
        public List<DescListData> Info { get; set; }

        /// <summary>
        /// Name of PDF to view
        /// </summary>
        public string Pdf { get; set; }

        /// <summary>
        /// Data to show on Chart
        /// </summary>
        public List<HazardNessLevel> HazardNessLevels { get; set;}

        /// <summary>
        /// Data to display in gridview
        /// </summary>
        public List<Record> Records { get; set; }
    }

    /// <summary>
    /// Information list model
    /// </summary>
    public class DescListData
    {
        /// <summary>
        /// Name of icon
        /// </summary>
        public string IconSrc { get; set; }

        /// <summary>
        /// String value
        /// </summary>
        public string Information { get; set; }
    }

    /// <summary>
    /// Class for chart data
    /// </summary>
    public class HazardNessLevel
    {
        /// <summary>
        /// Name of chart item
        /// </summary>
        public string HazardNessName { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        public int Intensity { get; set; }
    }

    /// <summary>
    /// Record to display in gridview
    /// </summary>
    public class Record
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// Department (Group)
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Name of document
        /// </summary>
        public string Dokument { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime Datum { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }
    }
}
