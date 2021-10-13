using System;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Plumber.Api.Controllers;
using Plumber.Api.Entities;
using Plumber.Api.Interfaces;
using Xunit;

namespace Plumber.Test
{
    public class RoomsControllerTests
    {
        private readonly Mock<ILogger<RoomsController>> _loggerStub = new();
        private readonly Mock<IRoomsRepository> _repositoryStub = new();

        [Fact]
        public async Task GetRoomAsync_WithUnexistingRoom_ReturnsNotFound()
        {
            // Arrange
            _repositoryStub.Setup(repo => repo.GetRoomAsync(It.IsAny<Guid>())).ReturnsAsync((Room)null);
            
            var controller = new RoomsController(_repositoryStub.Object, _loggerStub.Object);

            // Act
            var result = await controller.GetRoomAsync(Guid.NewGuid());

            // Assert
            result.Should().BeOfType<NotFoundResult>();
        }

        [Fact]
        public async Task GetRoomAsync_WithExistingRoom_ReturnsExpectedRoom()
        {
            // Arrange
            var expectedRoom = CreateRandomRoom();

            _repositoryStub.Setup(repo => repo.GetRoomAsync(It.IsAny<Guid>())).ReturnsAsync(expectedRoom);

            var controller = new RoomsController(_repositoryStub.Object, _loggerStub.Object);

            // Act
            var result = await controller.GetRoomAsync(Guid.NewGuid());

            // Assert
            result.Value.Should().BeEquivalentTo(
                expectedRoom, 
                options => options.ComparingByMembers<Room>());
        }

        private Room CreateRandomRoom()
        {
            return new()
            {
                Id = Guid.NewGuid(),
                Name = "Studio " + Random.Shared.Next(10)
            };
        }
}