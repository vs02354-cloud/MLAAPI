using Microsoft.EntityFrameworkCore;
using MLA.Portal.Application.Interfaces;
using MLA.Portal.Domain.Entities;
using MLA.Portal.Infrastructure.Data;

namespace MLA.Portal.Infrastructure.Services;

public class MsrMasterDataService : IMsrMasterDataService
{
    private readonly ApplicationDbContext _context;

    public MsrMasterDataService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Msr_District>> GetDistrictsAsync()
    {
        return await _context.Msr_Districts
            .Where(d => d.IsActive)
            .OrderBy(d => d.NameHi)
            .ToListAsync();
    }

    public async Task<IEnumerable<Msr_LocalBody>> GetLocalBodiesByDistrictAsync(int districtId)
    {
        return await _context.Msr_LocalBodies
            .Where(lb => lb.DistrictId == districtId)
            .OrderBy(lb => lb.NameHi)
            .ToListAsync();
    }

    public async Task<IEnumerable<Msr_Village>> GetVillagesByLocalBodyAsync(int localBodyId)
    {
        return await _context.Msr_Villages
            .Where(v => v.LocalBodyId == localBodyId)
            .OrderBy(v => v.NameHi)
            .ToListAsync();
    }
}
