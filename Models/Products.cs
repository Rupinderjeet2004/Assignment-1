using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Products
    {
        //Changed this
        public Products()
        {
            Product_Name = "";
            Product_Description = "";
        }

        [Key]
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public double Price { get; set; }

        [ForeignKey("Manufacturers")]
        public int Manufacturer_ID { get; set; }

        //Changed this
        public virtual Manufacturers Manufacturers { get; set; }

    }
}
