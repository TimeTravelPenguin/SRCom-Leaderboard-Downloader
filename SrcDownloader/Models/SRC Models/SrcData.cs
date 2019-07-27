#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: SrcData.cs
// 
// Current Data:
// 2019-07-27 7:35 PM
// 
// Creation Date:
// 2019-07-27 6:29 PM

#endregion

using SrcDownloader.Types;

namespace SrcDownloader.Models.SRC_Models
{
    internal class SrcData : PropertyChangedBase
    {
        private LeaderboardModel _leaderboard;

        public LeaderboardModel Leaderboard
        {
            get => _leaderboard;
            set => SetValue(ref _leaderboard, value);
        }
    }
}