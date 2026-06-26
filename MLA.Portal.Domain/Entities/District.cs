namespace MLA.Portal.Domain.Entities;

public class District : BaseEntity
{
    public string NameHi { get; set; } = string.Empty;
    public string NameEn { get; set; } = string.Empty;
    
    public ICollection<Assembly> Assemblies { get; set; } = new List<Assembly>();
}
