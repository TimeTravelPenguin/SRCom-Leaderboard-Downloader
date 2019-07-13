using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
{
    internal class RunDataModel : PropertyChangedBase
    {
        private int _place;
        private PlayerModel _player;

        public int Place
        {
            get => _place;
            set => SetValue(ref _place, value);
        }

        public PlayerModel Player
        {
            get => _player;
            set => SetValue(ref _player, value);
        }

        public RunDataModel()
        {
            Place = -1;
            Player = new PlayerModel();
        }
    }
}