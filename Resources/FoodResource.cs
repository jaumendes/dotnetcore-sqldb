using System;

namespace DotNetCoreSqlDb.Resources
{
    public class FoodResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }

        public double Proteins { get; set; }

        public double Fats { get; set; }

        public double SatFats { get; set; }

        public double Carbs { get; set; }

        public double Sugars { get; set; }

        public string Vitamins { get; set; }

        public string Source { get; set; }


        public DateTime CreatedDate { get; set; }
    }
}