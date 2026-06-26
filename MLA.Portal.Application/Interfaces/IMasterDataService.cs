using MLA.Portal.Domain.Entities;

namespace MLA.Portal.Application.Interfaces;

public interface IMasterDataService
{
    Task<IEnumerable<District>> GetDistrictsAsync();
    Task<IEnumerable<Assembly>> GetAssembliesByDistrictAsync(int districtId);
    Task<IEnumerable<GramPanchayat>> GetGramPanchayatsByAssemblyAsync(int assemblyId);
    Task<IEnumerable<Village>> GetVillagesByGramPanchayatAsync(int gramPanchayatId);
}
