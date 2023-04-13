using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable


namespace najlepsze_filmy.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Date { get; set; }

        [ForeignKey("Genre")]
        public int GenreId { get; set; }


        public Genre Genre { get; set; }
        public ICollection<MovieRating> MovieRatings { get; set; }
    }
}
