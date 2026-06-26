using Microsoft.EntityFrameworkCore;
using MLA.Portal.Application.Interfaces;
using MLA.Portal.Domain.Entities;
using MLA.Portal.Infrastructure.Data;

namespace MLA.Portal.Infrastructure.Services;

public class MasterDataService : IMasterDataService
{
    private readonly ApplicationDbContext _context;

    public MasterDataService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<District>> GetDistrictsAsync()
    {
        return await _context.Districts.ToListAsync();
    }

    public async Task<IEnumerable<Assembly>> GetAssembliesByDistrictAsync(int districtId)
    {
        return await _context.Assemblies.Where(a => a.DistrictId == districtId).ToListAsync();
    }

    public async Task<IEnumerable<GramPanchayat>> GetGramPanchayatsByAssemblyAsync(int assemblyId)
    {
        return await _context.GramPanchayats.Where(g => g.AssemblyId == assemblyId).ToListAsync();
    }

    public async Task<IEnumerable<Village>> GetVillagesByGramPanchayatAsync(int gramPanchayatId)
    {
        return await _context.Villages.Where(v => v.GramPanchayatId == gramPanchayatId).ToListAsync();
    }
}
