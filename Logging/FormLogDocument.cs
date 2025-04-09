namespace Logging;

public class FormLogDocument
{
    public Guid Id { get; set; }
    public Guid FormId { get; set; }

    public List<FormChangeLog> FormLogs { get; set; } = new();

    public List<FormQuestionChangeLog> QuestionLogs { get; set; } = new();

    public List<GoalChangeLog> GoalLogs { get; set; } = new();

    public List<ActionChangeLog> ActionLogs { get; set; } = new();

    public List<AttachmentActionLog> ActionAttachmentLogs { get; set; } = new();
}