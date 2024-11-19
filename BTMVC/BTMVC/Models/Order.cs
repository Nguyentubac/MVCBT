using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTMVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        // Foreign key
        public int CustomerId { get; set; }
        // Navigation properties
        public virtual Customer Customer { get; set; }

    }
}