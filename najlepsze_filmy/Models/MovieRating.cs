#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace najlepsze_filmy.Models
{
    public class MovieRating
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }

        [ForeignKey("Rating")]
        public int RatingId { get; set; }

        public Movie Movie { get; set; }

        public Rating Rating { get; set; }
    }
}
