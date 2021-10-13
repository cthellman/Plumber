using Microsoft.AspNetCore.Mvc;
using Plumber.Api.Entities;
using Plumber.Api.Extensions;
using Plumber.Api.Interfaces;

namespace Plumber.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomsRepository _roomsRepository;
        private readonly ILogger<RoomsController> _logger;

        public RoomsController(IRoomsRepository roomsRepository, ILogger<RoomsController> logger)
        {
            _logger = logger;
            _roomsRepository = roomsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomDto>>> GetRoomsAsync()
        {
            var rooms = (await _roomsRepository.GetRoomsAsync()).Select(room => room.AsDto());
        }

        // GET /rooms/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomDto>> GetRoomAsync(Guid id)
        {
            var room = await _roomsRepository.GetRoomAsync(id);
            return room is null ? NotFound() : room.AsDto();
        }
    }
}