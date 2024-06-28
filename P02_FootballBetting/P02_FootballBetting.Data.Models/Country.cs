using P02_FootballBetting.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace P02_FootballBetting.Data.Models;
public class Country
{
    public Country()
    {
        Towns = new HashSet<Town>();
    }
    public int CountryId { get; set; }

    [MaxLength(ValidationConstants.CountryNameLength)]
    public string Name { get; set; }

    public virtual ICollection<Town> Towns { get; set; }
}
