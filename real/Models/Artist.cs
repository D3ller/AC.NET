using System.Collections;

namespace real.Models;

public class Artist
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Bio { get; set; }
    public string? AvatarUrl { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsVisible { get; set; } = false;

    public ICollection<Track> Tracks { get; set; } = new List<Track>();
    public ICollection<Album> Albums { get; set; } = new List<Album>();

}