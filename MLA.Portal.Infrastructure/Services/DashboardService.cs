using Microsoft.EntityFrameworkCore;
using MLA.Portal.Application.DTOs;
using MLA.Portal.Application.Interfaces;
using MLA.Portal.Infrastructure.Data;

namespace MLA.Portal.Infrastructure.Services;

public class DashboardService : IDashboardService
{
    private readonly ApplicationDbContext _context;

    public DashboardService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<DashboardStatsDto> GetDashboardStatsAsync()
    {
        var totalSurveys = await _context.Surveys.CountAsync();
        var totalVillages = await _context.Villages.CountAsync();
        var totalGramPanchayats = await _context.GramPanchayats.CountAsync();
        var totalAssemblies = await _context.Assemblies.CountAsync();

        // Dummy calculations for percentages (In a real scenario, this would aggregate actual survey answers)
        // Here we just mock the percentage data for the UI as the actual question mapping might be complex
        double satisfaction = 75.5; 
        double dissatisfaction = 24.5;
        double votingProbability = 80.0;
        double avgDevScore = 4.2;

        return new DashboardStatsDto
        {
            TotalSurveys = totalSurveys,
            TotalVillages = totalVillages,
            TotalGramPanchayats = totalGramPanchayats,
            TotalAssemblies = totalAssemblies,
            TotalRespondents = totalSurveys, // Assuming 1 respondent per survey
            SatisfactionPercentage = satisfaction,
            DissatisfactionPercentage = dissatisfaction,
            VotingProbability = votingProbability,
            AvgDevelopmentScore = avgDevScore
        };
    }
}
