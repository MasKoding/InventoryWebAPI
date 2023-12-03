using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryWebAPI.Model
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public Decimal UnitPrice { get; set; }

        public int AvailableQuantity { get; set; }


    }
}
