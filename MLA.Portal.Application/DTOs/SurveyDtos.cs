namespace MLA.Portal.Application.DTOs;

public class SurveySubmitRequest
{
    public int DistrictId { get; set; }
    public int AssemblyId { get; set; }
    public int GramPanchayatId { get; set; }
    public int VillageId { get; set; }

    public string RespondentName { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Gender { get; set; } = string.Empty;
    public string MobileNumber { get; set; } = string.Empty;

    public string BiggestProblem { get; set; } = string.Empty;
    public string Expectation { get; set; } = string.Empty;
    public string Suggestion { get; set; } = string.Empty;

    public List<SurveyAnswerDto> Answers { get; set; } = new List<SurveyAnswerDto>();
}

public class SurveyAnswerDto
{
    public int QuestionId { get; set; }
    public string AnswerValue { get; set; } = string.Empty;
}
