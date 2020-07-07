using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MVCFlowerShopLab2.Models
{
    public class Flower
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [Display(Name ="Name of Flower")]
        [StringLength(60, MinimumLength =6)]
        public string FlowerName { get; set; }

        [Required]
        [Display(Name = "Date of Production")]
        [DataType(DataType.Date)]
        public DateTime FlowerProducedDate { get; set; }

        [Required]
        [Display(Name = "Flower Type")]//Rose
        [RegularExpression(@"[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Type { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        
        public string Rating { get; set; }
    }
}
