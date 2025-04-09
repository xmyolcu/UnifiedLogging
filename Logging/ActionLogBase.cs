namespace Logging;

public class ActionLogBase : LogBase
{
    public string? TemplateKey { get; set; }

    public Dictionary<string, string>? TemplateValues { get; set; }

    public override string GetLogType() => "ActionLogBase";

    public async Task<string> GetLocalizedMessageAsync(string language, ILogTemplateRepository templateRepo)
    {
        if (string.IsNullOrWhiteSpace(TemplateKey) || TemplateValues == null)
            return "[Tanımsız log girdisi]";

        var template = await templateRepo.GetTemplateAsync(TemplateKey, language);
        return LogTemplateEngine.Render(template.Template, TemplateValues);
    }
}