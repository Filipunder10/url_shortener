namespace UrlShortener.Models;

public class ShortenedUrl
{
    public int Id { get; set; }
    public string OriginalUrl { get; set; }
    public string ShortCode { get; set; }
    public string SecretCode { get; set; }
    public DateTime CreatedAt { get; set; }
}