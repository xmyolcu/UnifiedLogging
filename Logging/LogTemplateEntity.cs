namespace Logging;

public class LogTemplateEntity
{
    public string Key { get; set; } = string.Empty; // Örn: "Goal.Progress.Updated"
    public string Language { get; set; } = "tr"; // "tr", "en", vs.

    public string Template { get; set; } =
        string.Empty; // Örn: "{{user}} tarafından {{goalId}} id'li hedefin ilerlemesi {{oldValue}} → {{newValue}} olarak değiştirildi"
}