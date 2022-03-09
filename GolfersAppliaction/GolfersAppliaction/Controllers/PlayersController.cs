using GolfersAppliaction.Models;
using GolfersAppliaction.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GolfersAppliaction.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerRepository playerRepository;

        public PlayersController(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Just Testing");
        }
        [HttpGet]
        public ActionResult GetPlayers()
        {
            try
            {
                return Ok(playerRepository.GetAllPlayers());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost]
        public ActionResult AddPlayerScore(Player player)
        {
            try
            {
                return Ok(playerRepository.AddPlayerScore(player));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("{id:int}")]
        public ActionResult GetPlayerById(int id)
        {
            try
            {
                var playerId = playerRepository.GetPlayerById(id);
                if (playerId == null)
                    return NotFound();
                return Ok(playerId);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
