using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dot_Net_Project.Models
{
    public class Item
    {
        public Int64 Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Decimal Price { get; set; }
                // Foreign key property
        public Int64 CategoryId { get; set; }
/*
        // Navigation property
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
  */  }
}