using CinemaApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaApp.Data.Configuration
{
    internal class HallConfiguration :IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder
                .HasData(new Hall
                    {
                        Id = 1,
                        Name = "Grand Hall",
                        CinemaId = 1
                    },
                    new Hall()
                    {
                        Id = 2,
                        Name = "IMAX Hall",
                        CinemaId = 1
                    },
                    new Hall()
                    {
                        Id = 3,
                        Name = "Launge Hall",
                        CinemaId = 2
                    },
                    new Hall()
                    {
                        Id = 4,
                        Name = "Big Hall",
                        CinemaId = 2
                    },
                    new Hall()
                    {
                        Id = 5,
                        Name = "The Small Hall",
                        CinemaId = 3
                    },
                    new Hall()
                    {
                        Id = 6,
                        Name = "The Small Hall",
                        CinemaId = 3
                    },
                    new Hall()
                    {
                        Id = 7,
                        Name = "VIP Hall",
                        CinemaId = 3
                    });
        }
    }
}
