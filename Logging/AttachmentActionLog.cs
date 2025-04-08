namespace Logging;


public class AttachmentActionLog
{
    public string GoalId { get; set; }
    public long QuestionId { get; set; }
    public string GoalActionId { get; set; }
    public string AttachmentName { get; set; } = string.Empty;
    public string AttachmentType { get; set; } = string.Empty;

    public DateTime ActionTime { get; set; }
    public string ActionTakenBy { get; set; } = string.Empty;
    
    public string ActionType { get; set; } = string.Empty;  // Upload, Delete, Download

    public string GetLogType() => "AttachmentActionLog";
}