namespace MLA.Portal.Domain.Entities;

public class GramPanchayat : BaseEntity
{
    public int AssemblyId { get; set; }
    public Assembly Assembly { get; set; } = null!;

    public string NameHi { get; set; } = string.Empty;
    public string NameEn { get; set; } = string.Empty;

    public ICollection<Village> Villages { get; set; } = new List<Village>();
}
