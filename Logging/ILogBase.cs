namespace Logging;

public interface ILogBase
{
    DateTime ActionTime { get; set; }
    string ActionTakenBy { get; set; }
    
    string GetLogType();
}

/*
 GetLogType() metodu, log nesnesinin tipini runtime'da (çalışma anında) anlamanı sağlar.
 
 Ne Zaman İşine Yarar?
   1. Log Ayrıştırma (Discriminator)
   Eğer loglar tek bir koleksiyonda veya tek bir listede tutuluyorsa, hangisinin GoalLog, hangisinin FormLog olduğunu bilmen gerekir.
   
   2. Logları Dinamik Olarak Yönetmek
   Logları log tipi üzerinden yönlendirebilirsin:
   
   Hangi log hangi UI'da nasıl gösterilecek
   
   Hangi loglar hangi role/senaryoya açık
   
   Hangi loglar hangi servise gönderilecek (Elastic, Azure Monitor, vb.)
   
   3. Search/Filter UI
   Bir admin panelinde şu soruları cevaplamak istersin:
   
   “Sadece Form loglarını getir”
   
   “Sadece Goal olanları filtrele”
   
   “Aksiyon loglarını ayrı göster”
   
   GetLogType() sayesinde bunları yapmak çok kolay olur.
   
   Olmasa Ne Olur?
   1. Tip Tespiti için Reflection/Karmaşık Kod Gerekir
   log.GetType().Name gibi reflection tabanlı işler yapmak zorunda kalırsın. Bu da:
   
   Performans düşürür
   
   Unit test’leri zorlaştırır
   
   Tip adı değişirse kırılabilir olur
   
   
   2. Loglar Tipinden Bağımsız Olur
   Tip bilgisi runtime'da kaybolursa (örneğin JSON deserialize edilirken interface'e map'lenirse), ne log tipidir anlamak zorlaşır.
   
 */

