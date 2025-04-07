namespace Logging;

public class GoalLog : ActionLogBase
{
    public string GoalText { get; set; } = string.Empty;
    public string DropExplanation { get; set; } = string.Empty;
    public string GoalStatus { get; set; } = string.Empty;
    public DateTime? ActionEndDate { get; set; }
    public override string GetLogType() => "GoalLog";
}