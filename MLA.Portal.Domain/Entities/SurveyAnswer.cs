namespace MLA.Portal.Domain.Entities;

public class SurveyAnswer : BaseEntity
{
    public int SurveyId { get; set; }
    public Survey Survey { get; set; } = null!;

    public int QuestionId { get; set; }
    public QuestionMaster Question { get; set; } = null!;

    public string AnswerValue { get; set; } = string.Empty;
}
