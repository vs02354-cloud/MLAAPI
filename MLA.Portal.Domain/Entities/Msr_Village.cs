using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MLA.Portal.Domain.Entities;

public class Msr_Village
{
    [Key]
    [Column("VillageId")]
    public int Id { get; set; }

    [Column("VillageNameHindi")]
    public string NameHi { get; set; } = string.Empty;

    [Column("VillageName")]
    public string NameEn { get; set; } = string.Empty;
    
    [Column("LocalBodyId")]
    public int LocalBodyId { get; set; }
    public Msr_LocalBody? LocalBody { get; set; }
    
    public bool IsActive { get; set; }
}
