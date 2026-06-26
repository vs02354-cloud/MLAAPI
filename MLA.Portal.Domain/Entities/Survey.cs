namespace MLA.Portal.Domain.Entities;

public class Survey : BaseEntity
{
    public DateTime SurveyDate { get; set; } = DateTime.UtcNow;

    public int DistrictId { get; set; }
    public Msr_District District { get; set; } = null!;

    public int LocalBodyId { get; set; }
    public Msr_LocalBody LocalBody { get; set; } = null!;

    public int VillageId { get; set; }
    public Msr_Village Village { get; set; } = null!;

    public string RespondentName { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Gender { get; set; } = string.Empty;
    public string MobileNumber { get; set; } = string.Empty;

    // Survey Questions
    public string DevelopmentWorks { get; set; } = string.Empty;
    public string Road { get; set; } = string.Empty;
    public string Electricity { get; set; } = string.Empty;
    public string Water { get; set; } = string.Empty;
    public string Health { get; set; } = string.Empty;
    public string Education { get; set; } = string.Empty;
    public string GovtSchemes { get; set; } = string.Empty;

    // Feedback
    public string Satisfaction { get; set; } = string.Empty;
    public string WillVote { get; set; } = string.Empty;
    public string BiggestProblem { get; set; } = string.Empty;
    public string Expectation { get; set; } = string.Empty;
    public string Suggestion { get; set; } = string.Empty;
}
