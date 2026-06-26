using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLA.Portal.Domain.Entities;

public class Msr_District
{
    [Key]
    [Column("DistrictId")]
    public int Id { get; set; }

    [Column("DistrictNameHindi")]
    public string NameHi { get; set; } = string.Empty;

    [Column("DistrictName")]
    public string NameEn { get; set; } = string.Empty;
    
    public bool IsActive { get; set; }
    
    public ICollection<Msr_LocalBody> LocalBodies { get; set; } = new List<Msr_LocalBody>();
}
