using System.ComponentModel.DataAnnotations;

namespace Plumber.Api.Entities
{
    public record RoomDto(Guid Id, string Name);
    public record CreateRoomDto([Required] string Name);
    public record UpdateRoomDto([Required] string Name);
}