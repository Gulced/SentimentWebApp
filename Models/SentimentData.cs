namespace SentimentWebApp.Models
{
    // Kullanıcının girdiği yorum
    public class SentimentData
    {
        public string Text { get; set; } = "";
    }

    // ML.NET modeli tarafından döndürülen sonuç
    public class SentimentPrediction : SentimentData
    {
        public bool Prediction { get; set; }           // true: pozitif, false: negatif
        public float Probability { get; set; }         // Tahminin olasılığı (0.0 - 1.0 arası)
        public float Score { get; set; }               // Modelin skoru (pozitif için +, negatif için -)
    }
}
