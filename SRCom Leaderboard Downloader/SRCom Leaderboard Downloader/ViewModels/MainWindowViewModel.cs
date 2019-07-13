using SRCom_Leaderboard_Downloader.Models;
using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.ViewModels
{
    internal class MainWindowViewModel : PropertyChangedBase
    {
        private LeaderboardModel _leaderboard = new LeaderboardModel();

        public LeaderboardModel Leaderboard
        {
            get => _leaderboard;
            set => SetValue(ref _leaderboard, value);
        }
    }
}