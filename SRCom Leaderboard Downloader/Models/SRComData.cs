using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
{
    internal class SRComData : PropertyChangedBase
    {
        private LeaderboardModel _leaderboard;

        public LeaderboardModel Leaderboard
        {
            get => _leaderboard;
            set => SetValue(ref _leaderboard, value);
        }
    }
}