namespace MLA.Portal.Application.DTOs;

public class DashboardStatsDto
{
    public int TotalSurveys { get; set; }
    public int TotalVillages { get; set; }
    public int TotalGramPanchayats { get; set; }
    public int TotalAssemblies { get; set; }
    public int TotalRespondents { get; set; }

    public double SatisfactionPercentage { get; set; }
    public double DissatisfactionPercentage { get; set; }
    public double VotingProbability { get; set; }
    public double AvgDevelopmentScore { get; set; }
}
