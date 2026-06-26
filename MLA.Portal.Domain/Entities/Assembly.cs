namespace MLA.Portal.Domain.Entities;

public class Assembly : BaseEntity
{
    public int DistrictId { get; set; }
    public District District { get; set; } = null!;

    public string NameHi { get; set; } = string.Empty;
    public string NameEn { get; set; } = string.Empty;
    public string MLAName { get; set; } = string.Empty;

    public ICollection<GramPanchayat> GramPanchayats { get; set; } = new List<GramPanchayat>();
}
