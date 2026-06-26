using MLA.Portal.Application.DTOs;

namespace MLA.Portal.Application.Interfaces;

public interface ISurveyService
{
    Task<(bool Success, string ErrorMessage)> SubmitSurveyAsync(SubmitSurveyDto request);
}
