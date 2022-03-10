using GolfersAppliaction.Controllers;
using GolfersAppliaction.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;

using Xunit;

namespace GolfersApplication.xUnitTests
{
    public class PlayersControllerTest
    {
        [Fact]
        public void GetCorrectWinner()
        {
            //Arrange
            var repository = new Mock<IPlayerRepository>();
            repository.Setup(repo => repo.GetAllPlayers());
            var controller = new PlayersController(repository.Object);
            //Act
            var result = controller.GetPlayers();
            //Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
