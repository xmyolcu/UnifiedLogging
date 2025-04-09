namespace Logging;

//Cümleleri dinamik şekilde oluşturmak için basit bir template engine

public static class LogTemplateEngine
{
    public static string Render(string template, Dictionary<string, string> values)
    {
        foreach (var kv in values)
            template = template.Replace($"{{{{{kv.Key}}}}}", kv.Value);

        return template;
    }
}