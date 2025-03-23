using real.Models;

namespace real.Dtos.Track;

public class TrackDto
{
    public Guid Id { get; set; }
    public string? CoverUrl { get; set; }
    public string? FileUrl { get; set; }
    
    public DateTime ReleaseDate { get; set; }

    public ICollection<Artist> Artists { get; set; } = new List<Artist>();
    
    public Guid? AlbumId { get; set; }
    public Album? Album { get; set; }
}