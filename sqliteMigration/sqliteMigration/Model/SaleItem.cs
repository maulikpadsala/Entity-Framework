using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sqliteMigration.Model
{
    public class SaleItem
    {
        [Key]
        public int saleItemId { get; set; }

        [Required(ErrorMessage = "Please enter saleName")]
        [StringLength(100)]
        public string saleName { get; set; }

        [DataType(DataType.Date)]
        public DateTime startDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime endDate { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal price { get; set; }

        public List<Product> Products { get; set; }
    }
}
