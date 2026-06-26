namespace MLA.Portal.Domain.Entities;

public class Village : BaseEntity
{
    public int GramPanchayatId { get; set; }
    public GramPanchayat GramPanchayat { get; set; } = null!;

    public string NameHi { get; set; } = string.Empty;
    public string NameEn { get; set; } = string.Empty;
}
