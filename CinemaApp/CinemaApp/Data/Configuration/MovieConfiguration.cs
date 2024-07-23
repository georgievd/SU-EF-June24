using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaApp.Data.Configuration
{
    internal class MovieConfiguration : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.HasData(new Film()
            {
                Id = 1,
                Title = "Snatch"
            },
            new Film()
            {
                Id = 2,
                Title = "Lock, Stock and Two Smoking Barrels"
            },
            new Film()
            {
                Id = 3,
                Title = "Rock n Rolla"
            });
        }
    }
}
