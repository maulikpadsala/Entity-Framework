using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sqliteMigration.Model
{
    public class Product
    {
        [Key]
        public int productId { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [StringLength(100)]
        public string name { get; set; }

        [StringLength(250)]
        public string description { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal price { get; set; }
    }
}

