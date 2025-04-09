namespace Logging;

public class ActionChangeLog : ActionLogBase
{
    public string GoalId { get; set; }
    public long QuestionId { get; set; }
    public string GoalActionId { get; set; }
    public string ActionText { get; set; } = string.Empty;
    public DateTime? ActionEndDate { get; set; }

    public string AttachmentName { get; set; } = string.Empty;
    public string AttachmentType { get; set; } = string.Empty;

    public string DropExplanation { get; set; } = string.Empty;
    public string ActionStatus { get; set; } = string.Empty;

    public override string GetLogType()
    {
        return "ActionLog";
    }
}