using P02_FootballBetting.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models;
public class Town
{
    public Town()
    {
        Teams = new HashSet<Team>();
        Players = new HashSet<Player>();
    }

    public int TownId { get; set; }

    [MaxLength(ValidationConstants.TownNameLength)]
    public string Name { get; set; }

    public virtual ICollection<Team> Teams { get; set; }

    public virtual ICollection<Player> Players { get; set; }

    [ForeignKey(nameof(Country))]
    public int CountryId { get; set; }
    public virtual Country Country { get; set; }
}
