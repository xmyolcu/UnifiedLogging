namespace Logging;

public class FormLogBase : LogBase
{
    public UserFormModel ActionTakenBy { get; set; } = new();

    public override string GetLogType()
    {
        return "FormLogBase";
    }
}

public class FormChangeLogNameModel : FormLogBase
{
    public override string GetLogType()
    {
        return "FormChangeLogNameModel";
    }
}

public class FormChangeTemplateNameModel : FormChangeLogNameModel
{
    public bool IsCreatedFromTemplate { get; set; }

    public string TemplateName { get; set; } = string.Empty;

    public string TemplateId { get; set; } = string.Empty;

    public override string GetLogType()
    {
        return "FormChangeTemplateNameModel";
    }
}

public class FormChangeActionToUserModel : FormChangeLogNameModel
{
    public List<UserFormModel> ActionTakenTo { get; set; } = [];

    public override string GetLogType()
    {
        return "FormChangeActionToUserModel";
    }
}

public class FormChangeReassignActionModel : FormChangeLogNameModel
{
    public List<long> ReassignedQuestions { get; set; } = [];

    public override string GetLogType()
    {
        return "FormChangeReassignActionModel";
    }
}

//Değişmedi, sadece model bazlı log objelerini içeriyor
public class FormChangeLog
{
    public FormChangeTemplateNameModel? CreatedFromTemplateAt { get; set; }

    public FormChangeLogNameModel? FormCreatedAt { get; set; }

    public List<FormChangeLogNameModel> UpdatedAt { get; set; } = new();

    public FormChangeLogNameModel? PendingAt { get; set; }

    public FormChangeLogNameModel? ApprovedAt { get; set; }

    public FormChangeLogNameModel? PublishedAt { get; set; }

    public FormChangeLogNameModel? RejectedAt { get; set; }

    public List<FormChangeReassignActionModel>? ReassignedAt { get; set; }

    public int ReassignCount => ReassignedAt?.Count ?? 0;

    public FormChangeLogNameModel? CompletedAt { get; set; }

    public FormChangeLogNameModel? CancelledAt { get; set; }

    public FormChangeLogNameModel? DeletedAt { get; set; }

    public FormChangeLogNameModel? DoneAt { get; set; }
}

//Değişmedi, sadece model türleri artık ILogBase uyumlu
public class FormQuestionChangeLog
{
    public FormChangeLogNameModel? AddedAt { get; set; }

    public List<FormChangeLogNameModel>? UpdatedAt { get; set; }

    public List<FormChangeActionToUserModel>? AssignedAsCheckerAt { get; set; }

    public List<FormChangeActionToUserModel>? AssignedAsApproverAt { get; set; }

    public List<FormChangeActionToUserModel>? AssignedAt { get; set; }

    public List<FormChangeLogNameModel>? ReassignedAt { get; set; }

    public List<FormChangeLogNameModel>? AnsweredAt { get; set; }

    public List<FormChangeLogNameModel>? ScoredAt { get; set; }

    public FormChangeLogNameModel? DoneAt { get; set; }

    public FormChangeLogNameModel? SubmittedAt { get; set; }
}