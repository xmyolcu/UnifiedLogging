namespace Logging;

public class ActionLog : ActionLogBase
{
    public string ActionText { get; set; } = string.Empty;
    public DateTime? ActionEndDate { get; set; }

    public string AttachmentName { get; set; } = string.Empty;
    public string AttachmentType { get; set; } = string.Empty;

    public string DropExplanation { get; set; } = string.Empty;
    public string ActionStatus { get; set; } = string.Empty;

    public List<AttachmentActionLog> Attachments { get; set; } = new();

    public override string GetLogType() => "ActionLog";
}