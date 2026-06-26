using System.ComponentModel.DataAnnotations;

namespace MLA.Portal.Application.DTOs;

public class SubmitSurveyDto
{
    [Required(ErrorMessage = "District is required.")]
    public int DistrictId { get; set; }

    [Required(ErrorMessage = "Local Body is required.")]
    public int LocalBodyId { get; set; }

    [Required(ErrorMessage = "Village is required.")]
    public int VillageId { get; set; }

    [Required(ErrorMessage = "Respondent Name is required.")]
    [StringLength(100, ErrorMessage = "Respondent Name cannot exceed 100 characters.")]
    public string RespondentName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Age is required.")]
    [Range(18, 120, ErrorMessage = "Age must be at least 18.")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    public string Gender { get; set; } = string.Empty;

    [Required(ErrorMessage = "Mobile Number is required.")]
    [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Mobile Number must be a 10-digit number.")]
    public string MobileNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Development Works feedback is required.")]
    public string DevelopmentWorks { get; set; } = string.Empty;

    [Required(ErrorMessage = "Road feedback is required.")]
    public string Road { get; set; } = string.Empty;

    [Required(ErrorMessage = "Electricity feedback is required.")]
    public string Electricity { get; set; } = string.Empty;

    [Required(ErrorMessage = "Water feedback is required.")]
    public string Water { get; set; } = string.Empty;

    [Required(ErrorMessage = "Health feedback is required.")]
    public string Health { get; set; } = string.Empty;

    [Required(ErrorMessage = "Education feedback is required.")]
    public string Education { get; set; } = string.Empty;

    [Required(ErrorMessage = "Government Schemes feedback is required.")]
    public string GovtSchemes { get; set; } = string.Empty;

    [Required(ErrorMessage = "Satisfaction rating is required.")]
    public string Satisfaction { get; set; } = string.Empty;

    [Required(ErrorMessage = "Will Vote response is required.")]
    public string WillVote { get; set; } = string.Empty;

    [Required(ErrorMessage = "Biggest Problem is required.")]
    public string BiggestProblem { get; set; } = string.Empty;

    public string Expectation { get; set; } = string.Empty;

    public string Suggestion { get; set; } = string.Empty;
}
