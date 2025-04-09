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

/*
   { "user", "Kullanıcı" },
   { "date", "2025-04-09" }
   { "confirm-status", 3 },
   { "process-status", 4 },
   { "new-text", "Lorem ipsum dolar sit amet"},
   { "last-text", "Lorem ipsum dolar sit amet"},
   
   Hedef {{user}} tarafından {{date}} tarihinde Hedef Metni Düzenlendi. Onay Status : {{confirm-status}} , Durum Status {{process-status}}
   Yeni Hedef Metni : {{new-text}}
   Eski Hedef Metni : {{last-text}}
*/