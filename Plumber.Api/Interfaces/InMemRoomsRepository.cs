using Plumber.Api.Entities;

namespace Plumber.Api.Interfaces;

public class InMemRoomsRepository : IRoomsRepository
{
        private readonly List<Room> _rooms = new()
        {
            new Room { Id = Guid.NewGuid(), Name = "Studio 1"},
            new Room { Id = Guid.NewGuid(), Name = "Studio 2" },
            new Room { Id = Guid.NewGuid(), Name = "Studio 3" }
        };

        public async Task<IEnumerable<Room>> GetRoomsAsync()
        {
            return await Task.FromResult(_rooms);
        }

        public async Task<Room?> GetRoomAsync(Guid id)
        {
            var room = _rooms.SingleOrDefault(room => room.Id == id);
            return await Task.FromResult(room);
        }

        public async Task CreateRoomAsync(Room room)
        {
            _rooms.Add(room);
            await Task.CompletedTask;
        }

        public async Task UpdateRoomAsync(Room room)
        {
            var index = _rooms.FindIndex(existingRoom => existingRoom.Id == room.Id);
            _rooms[index] = room;
            await Task.CompletedTask;
        }

        public async Task DeleteRoomAsync(Guid id)
        {
            var index = _rooms.FindIndex(existingRoom => existingRoom.Id == id);
            _rooms.RemoveAt(index);
            await Task.CompletedTask;
        }
}