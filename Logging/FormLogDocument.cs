namespace Logging;

public class FormLogDocument
{
    public Guid Id { get; set; }
    public Guid FormId { get; set; }

    public List<FormChangeLog> FormLogs { get; set; } = new();
    
    public List<QuestionLog> QuestionLogs { get; set; } = new();
    
    public List<GoalLog> GoalLogs { get; set; } = new();
    
    public List<ActionLog> ActionLogs { get; set; } = new();
}