﻿using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MovieExample.Models
{
    public class Movie
    {
        public string Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price {  get; set; }
    }
}
