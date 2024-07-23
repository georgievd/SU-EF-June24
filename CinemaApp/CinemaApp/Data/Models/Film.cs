﻿using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Data.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; } = null!;

        [StringLength(500)]
        public string? Description { get; set; }

        public Genre Genre { get; set; }

        public List<Schedule> Schedules { get; set; } = new List<Schedule>();
    }

    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Fantasy,
        SciFi,
        Horror,
        Thriller,
        NotClassified
    }
}
