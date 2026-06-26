namespace MLA.Portal.Domain.Entities;

public class ReportCard : BaseEntity
{
    public int AssemblyId { get; set; }
    public Assembly Assembly { get; set; } = null!;

    public int TotalSurveys { get; set; }
    public int TotalVillages { get; set; }

    public double SatisfactionPercentage { get; set; }
    public double DissatisfactionPercentage { get; set; }
    public double VotingProbability { get; set; }
    public double DevelopmentScore { get; set; }

    public string MajorComplaintsJson { get; set; } = string.Empty;
    public string MajorExpectationsJson { get; set; } = string.Empty;

    public string OverallRating { get; set; } = string.Empty;
    public double OverallPerformancePercentage { get; set; }

    public DateTime GeneratedDate { get; set; } = DateTime.UtcNow;
}
