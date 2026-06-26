namespace MLA.Portal.Domain.Entities;

public class QuestionMaster : BaseEntity
{
    public string QuestionText { get; set; } = string.Empty;
    public string QuestionType { get; set; } = string.Empty; // e.g., Dropdown, Radio, Text
    public string OptionsJson { get; set; } = string.Empty; // JSON array of options
    public int Order { get; set; }
    public bool IsActive { get; set; } = true;
}
