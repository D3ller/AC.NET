using System.Collections;

namespace real.Models;

public class Album
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public string? CoverUrl { get; set; }
    
    public DateTime ReleaseDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public bool IsVisible { get; set; } = false;

    public ICollection<Track> Tracks { get; set; } = new List<Track>();
    public ICollection<Artist> Artists { get; set; } = new List<Artist>();
}