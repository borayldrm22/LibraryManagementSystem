using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Kutuphane2.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [DisplayName("İsim")]
        public string Name { get; set; } = "";
        public string Brand { get; set; } = "";


        [MaxLength(100)]
        public string Category { get; set; } = "";

        [Precision(16, 2)]
        public decimal Price { get; set; }

        public string Description { get; set; } = "";

        [MaxLength(100)]
        public string ImageFileName { get; set; } = "";

        public DateTime CreatedAt { get; set; }

    }
}
