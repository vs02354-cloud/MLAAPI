using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MLA.Portal.Application.Interfaces;

namespace MLA.Portal.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MasterDataController : ControllerBase
{
    private readonly IMasterDataService _masterDataService;

    public MasterDataController(IMasterDataService masterDataService)
    {
        _masterDataService = masterDataService;
    }

    [HttpGet("districts")]
    public async Task<IActionResult> GetDistricts()
    {
        var districts = await _masterDataService.GetDistrictsAsync();
        return Ok(districts);
    }

    [HttpGet("assemblies/{districtId}")]
    public async Task<IActionResult> GetAssemblies(int districtId)
    {
        var assemblies = await _masterDataService.GetAssembliesByDistrictAsync(districtId);
        return Ok(assemblies);
    }

    [HttpGet("grampanchayats/{assemblyId}")]
    public async Task<IActionResult> GetGramPanchayats(int assemblyId)
    {
        var gramPanchayats = await _masterDataService.GetGramPanchayatsByAssemblyAsync(assemblyId);
        return Ok(gramPanchayats);
    }

    [HttpGet("villages/{gramPanchayatId}")]
    public async Task<IActionResult> GetVillages(int gramPanchayatId)
    {
        var villages = await _masterDataService.GetVillagesByGramPanchayatAsync(gramPanchayatId);
        return Ok(villages);
    }
}
