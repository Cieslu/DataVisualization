﻿using System.ComponentModel.DataAnnotations;
#nullable disable


namespace najlepsze_filmy.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }


        public ICollection<Movie> Movies { get; set; }
    }
}
