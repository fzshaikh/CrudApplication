using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudApplication.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public DateTime DOM { get; set; }

        public DateTime DOE { get; set; }

        public bool IsAvailable { get; set; }

        public int Quantity { get; set; }


    }
}