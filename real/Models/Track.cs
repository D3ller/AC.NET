namespace real.Models;

public class Track
{
    public Guid Id { get; set; }
    public string? CoverUrl { get; set; }
    public string? FileUrl { get; set; }
    
    public bool IsVisible { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime ReleaseDate { get; set; }

    public ICollection<Artist> Artists { get; set; } = new List<Artist>();
    
    public Guid? AlbumId { get; set; }
    public Album? Album { get; set; }

}