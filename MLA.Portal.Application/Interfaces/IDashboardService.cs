using MLA.Portal.Application.DTOs;

namespace MLA.Portal.Application.Interfaces;

public interface IDashboardService
{
    Task<DashboardStatsDto> GetDashboardStatsAsync();
}
