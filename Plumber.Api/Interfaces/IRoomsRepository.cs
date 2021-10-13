using Plumber.Api.Entities;

namespace Plumber.Api.Interfaces;

public interface IRoomsRepository
{
    Task<IEnumerable<Room>> GetRoomsAsync();
    Task<Room?> GetRoomAsync(Guid id);
    Task CreateRoomAsync(Room room);
    Task UpdateRoomAsync(Room room);
    Task DeleteRoomAsync(Guid id);
}