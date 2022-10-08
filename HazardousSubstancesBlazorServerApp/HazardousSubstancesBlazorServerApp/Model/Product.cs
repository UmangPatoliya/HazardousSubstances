﻿namespace HazardousSubstancesBlazorServerApp.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        List<string> Images { get; set; } = new List<string>();
        public string Description { get; set; }
        public List<string> Warning { get; set; }
        public List<string> Info { get; set; }
        
        public string Pdf { get; set; }
    }
}
