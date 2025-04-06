namespace Logging;

public abstract class LogBase : ILogBase
{
    public DateTime ActionTime { get; set; }
    
    public string ActionTakenBy { get; set; } = string.Empty;
    
    public abstract string GetLogType();
}

/*
LogBase sınıfı, kendisi doğrudan kullanılmasın ama tüm log türleri için ortak bir temel sağlasın diye abstract. 
Zorunlu olarak GetLogType() gibi metotlar alt sınıflarda override edilmek zorunda kalır.
NOT => Neden GetLogType a ihtiyacımız olabileceği veya var olması veya kaldırılması durumları ILogBase.cs içerisinde eklenmiştir.
*/