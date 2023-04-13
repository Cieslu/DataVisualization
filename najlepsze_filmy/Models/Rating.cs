#nullable disable
using System.ComponentModel.DataAnnotations;

namespace najlepsze_filmy.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<MovieRating> MovieRatings { get; set; }
    }
}
