using Mission7_ajames26.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mission7_ajames26.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please select a genre.")]
        public int MovieCategoryId { get; set; }

        [DisplayName("Movie Category")]
        public MovieCategory MovieCategory { get; set; }

        [Required]
        public uint Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        [MaxLength(5)]
        public string Rating { get; set; }

        public bool Edited { get; set; } = false;

        [DisplayName("Lent To")]
        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }

        

    }
}
