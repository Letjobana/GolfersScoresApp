using GolfersAppliaction.Models;
using System.Collections.Generic;

namespace GolfersAppliaction.Repositories.Abstracts
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> GetAllPlayers();
        Player GetPlayerById(int Id);
        Player AddPlayerScore(Player player);
    }
}
