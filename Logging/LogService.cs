namespace Logging;

public class LogService
{
    private readonly ILogTemplateRepository _templateRepo;

    public LogService(ILogTemplateRepository templateRepo)
    {
        _templateRepo = templateRepo;
    }

    //Belirtilen log girdisini, seçilen dile göre string'e dönüştürür.
    public async Task<string> RenderLogAsync(ActionLogBase log, string language)
    {
        if (string.IsNullOrWhiteSpace(log.TemplateKey))
            return "[Şablon anahtarı tanımsız]";

        if (log.TemplateValues == null || !log.TemplateValues.Any())
            return "[Şablon değerleri eksik]";

        var template = await _templateRepo.GetTemplateAsync(log.TemplateKey, language);

        if (template == null || string.IsNullOrWhiteSpace(template.Template))
            return $"[{language} dili için şablon bulunamadı: {log.TemplateKey}]";

        return LogTemplateEngine.Render(template.Template, log.TemplateValues);
    }
}