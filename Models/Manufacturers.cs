using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Manufacturers
    {

        [Key]
        public int Manufacturer_ID { get; set; }
        public string Manufacturer_Name { get; set; }
        public string WebsiteName { get; set; }
        public DateTime Founded { get; set; }

    }
}