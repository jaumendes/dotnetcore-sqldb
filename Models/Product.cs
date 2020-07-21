using System;

namespace DotNetCoreSqlDb.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SmallPortionRatio { get; set; }
        public decimal MediumPortionRatio { get; set; }
        public decimal LargePortionRatio { get; set; }
        public int Kcals { get; set; }
        public decimal Protein { get; set; }
        public decimal Fat { get; set; }
        public decimal SaturatedFat { get; set; }
        public decimal CarboHidrate { get; set; }
        public decimal Sugar { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}

