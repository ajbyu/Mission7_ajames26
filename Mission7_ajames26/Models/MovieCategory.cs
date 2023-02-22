using System.ComponentModel.DataAnnotations;

namespace Mission7_ajames26.Models
{
    public class MovieCategory
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
