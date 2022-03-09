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
        public ActionResult AddPlayerScore([FromBody] Player player)
        {
            try
            {
                if (player == null)
                    return BadRequest();
                var addPlayer = playerRepository.AddPlayerScore(player);
                return Ok(addPlayer);
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
