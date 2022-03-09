using GolfersAppliaction.Models;
using GolfersAppliaction.Persistance;
using GolfersAppliaction.Repositories.Abstracts;
using System.Collections.Generic;
using System.Linq;

namespace GolfersAppliaction.Repositories.Concrets
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ApplicationDbContext context;

        public PlayerRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Player AddPlayerScore(Player player)
        {
            if (player != null)
            {
                double price = player.Score * 10;
                var playerScore = new Player
                {
                    Name = player.Name,
                    Score = player.Score,
                    Price = price
                };
                context.Players.Add(playerScore);
                context.SaveChanges();
            }

            return player;

        }

        public IEnumerable<Player> GetAllPlayers()
        {
            return context.Players.ToList().OrderBy(x => x.Score);
        }

        public Player GetPlayerById(int id)
        {
            return context.Players.FirstOrDefault(x => x.Id == id);
        }
    }
}
