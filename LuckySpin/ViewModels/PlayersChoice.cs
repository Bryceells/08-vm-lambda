using LuckySpin.Models;
namespace LuckySpin.ViewModels
{
    public class PlayersChoice
    {
        //TODO: Add properties needed to pre-fill the PlayersChoice View.
        public Player Player { get; set; }
        public ICollection<Game> Games { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}