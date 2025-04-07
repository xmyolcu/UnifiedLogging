namespace Logging;


public class GoalLog
{
    public string GoalId { get; set; }
    
    public long QuestionId { get; set; }

    public List<GoalChangeLog> Logs { get; set; } = new();

}
public class GoalChangeLog : ActionLogBase
{
    public string GoalText { get; set; } = string.Empty;
    public string DropExplanation { get; set; } = string.Empty;
    public string GoalStatus { get; set; } = string.Empty;
    public DateTime? ActionEndDate { get; set; }
    public override string GetLogType() => "GoalLog";
}