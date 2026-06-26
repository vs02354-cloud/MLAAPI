using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MLA.Portal.Application.Interfaces;
using MLA.Portal.Domain.Entities;

namespace MLA.Portal.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MsrMasterDataController : ControllerBase
{
    private readonly IMsrMasterDataService _masterDataService;

    public MsrMasterDataController(IMsrMasterDataService masterDataService)
    {
        _masterDataService = masterDataService;
    }

    [HttpGet("districts")]
    public async Task<ActionResult<IEnumerable<Msr_District>>> GetDistricts()
    {
        var districts = await _masterDataService.GetDistrictsAsync();
        return Ok(districts);
    }

    [HttpGet("localbodies/{districtId}")]
    public async Task<ActionResult<IEnumerable<Msr_LocalBody>>> GetLocalBodies(int districtId)
    {
        var localBodies = await _masterDataService.GetLocalBodiesByDistrictAsync(districtId);
        return Ok(localBodies);
    }

    [HttpGet("villages/{localBodyId}")]
    public async Task<ActionResult<IEnumerable<Msr_Village>>> GetVillages(int localBodyId)
    {
        var villages = await _masterDataService.GetVillagesByLocalBodyAsync(localBodyId);
        return Ok(villages);
    }

    [HttpGet("debug/schema/{tableName}")]
    public async Task<IActionResult> GetSchema(String tableName, [FromServices] MLA.Portal.Infrastructure.Data.ApplicationDbContext db)
    {
        using var command = db.Database.GetDbConnection().CreateCommand();
        command.CommandText = "SELECT column_name FROM information_schema.columns WHERE table_name = '" + tableName + "' OR table_name = '" + tableName.ToLower() + "'";
        await db.Database.OpenConnectionAsync();
        using var result = await command.ExecuteReaderAsync();
        var columns = new List<string>();
        while (await result.ReadAsync())
        {
            columns.Add(result.GetString(0));
        }
        return Ok(columns);
    }
}
