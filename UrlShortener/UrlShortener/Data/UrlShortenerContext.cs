using Microsoft.EntityFrameworkCore;
using UrlShortener.Models;

namespace UrlShortener.Data;

public class UrlShortenerContext : DbContext
{
    public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options) { }

    public DbSet<ShortenedUrl> ShortenedUrls { get; set; }
    public DbSet<Visit> Visits { get; set; }
}
