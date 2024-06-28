using P02_FootballBetting.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace P02_FootballBetting.Data.Models;
public class Position
{
    public Position()
    {
        Players = new HashSet<Player>();
    }
    public int PositionId { get; set; }

    [MaxLength(ValidationConstants.PositionNameLength)]
    public string Name { get; set; }

    public virtual ICollection<Player> Players { get; set; }
}
