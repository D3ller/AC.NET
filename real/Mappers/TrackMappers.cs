using real.Dtos.Track;
using real.Models;

namespace real.Mappers;

public static class TrackMappers
{
    public static TrackDto GetTrack(this Track trackModel)
    {
        return new TrackDto
        {
            Id = trackModel.Id,
            FileUrl = trackModel.FileUrl,
            CoverUrl = trackModel.CoverUrl,
            ReleaseDate = trackModel.ReleaseDate,
            Artists = trackModel.Artists,
            AlbumId = trackModel.AlbumId,
            Album = trackModel.Album
        };
    }
}