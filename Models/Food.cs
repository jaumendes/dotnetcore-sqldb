﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreSqlDb.Models
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Calories { get; set; }

        
         
         public double Proteins { get; set; }

        public double Fats { get; set; }

        public double SatFats { get; set; }

        public double Carbs { get; set; }

        
        public double Sugars { get; set; }
        public double Fibers { get; set; }

        public string Vitamins { get; set; }
        public string Minerals { get; set; }

        public string Source { get; set; }

        

        

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}

