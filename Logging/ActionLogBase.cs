namespace Logging;

public class ActionLogBase : LogBase
{
    public string ActionDetails { get; set; } = string.Empty;

    public override string GetLogType() => "ActionLogBase";
}