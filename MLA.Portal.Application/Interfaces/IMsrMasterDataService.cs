using MLA.Portal.Domain.Entities;

namespace MLA.Portal.Application.Interfaces;

public interface IMsrMasterDataService
{
    Task<IEnumerable<Msr_District>> GetDistrictsAsync();
    Task<IEnumerable<Msr_LocalBody>> GetLocalBodiesByDistrictAsync(int districtId);
    Task<IEnumerable<Msr_Village>> GetVillagesByLocalBodyAsync(int localBodyId);
}
