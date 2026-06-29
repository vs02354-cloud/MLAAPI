using Microsoft.AspNetCore.Mvc;
using MLA.Portal.Application.DTOs;
using MLA.Portal.Application.Interfaces;

namespace MLA.Portal.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SurveyController : ControllerBase
{
    private readonly ISurveyService _surveyService;
    private readonly ILogger<SurveyController> _logger;

    public SurveyController(ISurveyService surveyService, ILogger<SurveyController> logger)
    {
        _surveyService = surveyService;
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> SubmitSurvey([FromBody] SubmitSurveyDto request)
    {
        _logger.LogInformation("Received survey submission: {@Request}", request);
        var (success, errorMessage) = await _surveyService.SubmitSurveyAsync(request);
        if (success)
        {
            return Ok(new { Message = "Survey submitted successfully." });
        }
        return BadRequest(new { Message = errorMessage });
    }

    [HttpGet("check-mobile/{mobileNumber}")]
    public async Task<IActionResult> CheckMobile(string mobileNumber)
    {
        var isRegistered = await _surveyService.IsMobileNumberRegisteredAsync(mobileNumber);
        return Ok(new { isRegistered });
    }
}
