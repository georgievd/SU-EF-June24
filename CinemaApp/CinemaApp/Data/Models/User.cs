using System.ComponentModel.DataAnnotations;

namespace CinemaApp.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(64)]
        public string Username { get; set; } = null!;

        [Required] 
        [MaxLength(64)]
        public string FirstName { get; set; } = null!;

        [Required] 
        [MaxLength(64)]
        public string LastName { get; set; } = null!;

        public string? Address { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
