namespace Logging;


public class ActionLog
{
    public string GoalId { get; set; }
    public long QuestionId { get; set; }
    public string GoalActionId { get; set; }
    public List<ActionChangeLog> Logs { get; set; } = new();
    
    public List<AttachmentActionLog> ActionAttachmentLogs { get; set; } = new();

}
public class ActionChangeLog : ActionLogBase
{
    public string ActionText { get; set; } = string.Empty;
    public DateTime? ActionEndDate { get; set; }

    public string AttachmentName { get; set; } = string.Empty;
    public string AttachmentType { get; set; } = string.Empty;

    public string DropExplanation { get; set; } = string.Empty;
    public string ActionStatus { get; set; } = string.Empty;
    public override string GetLogType() => "ActionLog";
}