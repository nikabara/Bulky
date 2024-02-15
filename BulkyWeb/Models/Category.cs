using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [MinLength(1), MaxLength(25), Required, DisplayName("Genre")]
        public string Name { get; set; }

        [DisplayName("Display Number")]
        public int DisplayOrder { get; set; }
    }
}
