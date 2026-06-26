using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MLA.Portal.Application.DTOs;
using MLA.Portal.Application.Interfaces;
using MLA.Portal.Domain.Entities;
using MLA.Portal.Infrastructure.Data;

namespace MLA.Portal.Infrastructure.Services;

public class SurveyService : ISurveyService
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<SurveyService> _logger;

    public SurveyService(ApplicationDbContext context, ILogger<SurveyService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<(bool Success, string ErrorMessage)> SubmitSurveyAsync(SubmitSurveyDto request)
    {
        // Check if mobile number already exists
        var existingSurvey = await _context.Surveys.FirstOrDefaultAsync(s => s.MobileNumber == request.MobileNumber);
        if (existingSurvey != null)
        {
            return (false, "यह मोबाइल नंबर पहले से ही दर्ज है। कृपया दूसरे नंबर का उपयोग करें।"); // This mobile number is already registered. Please use another number.
        }

        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            var survey = new Survey
            {
                DistrictId = request.DistrictId,
                LocalBodyId = request.LocalBodyId,
                VillageId = request.VillageId,
                RespondentName = request.RespondentName,
                Age = request.Age,
                Gender = request.Gender,
                MobileNumber = request.MobileNumber,
                
                DevelopmentWorks = request.DevelopmentWorks,
                Road = request.Road,
                Electricity = request.Electricity,
                Water = request.Water,
                Health = request.Health,
                Education = request.Education,
                GovtSchemes = request.GovtSchemes,

                Satisfaction = request.Satisfaction,
                WillVote = request.WillVote,
                BiggestProblem = request.BiggestProblem,
                Expectation = request.Expectation,
                Suggestion = request.Suggestion,
                
                SurveyDate = DateTime.UtcNow
            };

            _context.Surveys.Add(survey);
            var result = await _context.SaveChangesAsync();
            
            await transaction.CommitAsync();
            return (result > 0, result > 0 ? string.Empty : "Failed to save survey to database.");
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync();
            _logger.LogError(ex, "An error occurred while submitting the survey for {RespondentName}", request.RespondentName);
            return (false, "An internal server error occurred while saving the survey.");
        }
    }
}
