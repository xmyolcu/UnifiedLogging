namespace Logging;

public class GoalChangeLog : ActionLogBase
{
    public string GoalId { get; set; }

    public long QuestionId { get; set; }
    public string GoalText { get; set; } = string.Empty;
    public string DropExplanation { get; set; } = string.Empty;
    public string GoalStatus { get; set; } = string.Empty;
    public DateTime? ActionEndDate { get; set; }

    public override string GetLogType()
    {
        return "GoalLog";
    }
}