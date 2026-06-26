using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLA.Portal.Domain.Entities;

public class Msr_LocalBody
{
    [Key]
    [Column("LocalBodyId")]
    public int Id { get; set; }

    [Column("LocalBodyNameHindi")]
    public string NameHi { get; set; } = string.Empty;

    [Column("LocalBodyName")]
    public string NameEn { get; set; } = string.Empty;
    
    [Column("DistrictId")]
    public int DistrictId { get; set; }
    public Msr_District? District { get; set; }
    
    public bool IsActive { get; set; }
    
    public ICollection<Msr_Village> Villages { get; set; } = new List<Msr_Village>();
}
