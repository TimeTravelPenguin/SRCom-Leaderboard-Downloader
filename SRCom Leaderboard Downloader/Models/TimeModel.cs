using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
{
    public class TimeModel : PropertyChangedBase
    {
        private string _inGame;
        private float _inGame_t;
        private string _primary;
        private float _primary_t;
        private string _realtime;
        private string _realtime_noloads;
        private float _realtime_noloads_t;
        private float _realtime_t;

        public string Primary
        {
            get => _primary;
            set => SetValue(ref _primary, value);
        }

        public float Primary_t
        {
            get => _primary_t;
            set => SetValue(ref _primary_t, value);
        }

        public string Realtime
        {
            get => _realtime;
            set => SetValue(ref _realtime, value);
        }

        public float Realtime_t
        {
            get => _realtime_t;
            set => SetValue(ref _realtime_t, value);
        }

        public string Realtime_noloads
        {
            get => _realtime_noloads;
            set => SetValue(ref _realtime_noloads, value);
        }

        public float Realtime_noloads_t
        {
            get => _realtime_noloads_t;
            set => SetValue(ref _realtime_noloads_t, value);
        }

        public string InGame
        {
            get => _inGame;
            set => SetValue(ref _inGame, value);
        }

        public float InGame_t
        {
            get => _inGame_t;
            set => SetValue(ref _inGame_t, value);
        }

        public TimeModel()
        {
            Primary = null;
            Primary_t = 0;
            Realtime = null;
            Realtime_t = 0;
            Realtime_noloads = null;
            Realtime_noloads_t = 0;
            InGame = null;
            InGame_t = 0;
        }
    }
}