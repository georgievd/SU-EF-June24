using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaApp.Data.Configuration
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cinema>()
                .HasData(
                    new Cinema()
                    {
                        Id = 1,
                        Name = "Arena Mladost",
                        Address = "Mladost 4, Sofia"
                    },
                    new Cinema()
                    {
                        Id = 2,
                        Name = "Cinema City",
                        Address = "Mall of Sofia"
                    },
                    new Cinema()
                    {
                        Id = 3,
                        Name = "Arena Varna",
                        Address = "Somehwere in Varna"
                    }
                );

            modelBuilder.ApplyConfiguration(new MovieConfiguration());

        }
    }
}
