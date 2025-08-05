namespace UrlShortener.Models;

public class Visit
{
    public int Id { get; set; }
    public string ShortCode { get; set; }
    public string ClientIp { get; set; }
    public DateTime VisitedAt { get; set; }
}