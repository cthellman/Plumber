using Plumber.Api.Entities;

namespace Plumber.Api.Extensions
{
    public static class RoomExtensions
    {
        public static RoomDto AsDto(this Room room)
        {
            return new RoomDto(room.Id, room.Name);
        }
    }
}
