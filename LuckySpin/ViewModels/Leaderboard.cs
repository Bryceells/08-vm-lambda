using LuckySpin.Services;
namespace LuckySpin.ViewModels;

    public class LeaderBoard
    {
        public ICollection<LeaderBoardEntry> Entries { get; set; }

    }