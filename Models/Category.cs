using System.ComponentModel.DataAnnotations;

namespace Dot_Net_Project.Models
{
    public class Category
    {
        public Int64 Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
                // Collection property for navigation
        //public ICollection<Item> Items { get; set; }
    }
}