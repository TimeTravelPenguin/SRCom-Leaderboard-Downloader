using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
{
    public class SystemModel : PropertyChangedBase
    {
        private bool _emulated;
        private string _platform;
        private string _region;

        public string Platform
        {
            get => _platform;
            set => SetValue(ref _platform, value);
        }

        public bool Emulated
        {
            get => _emulated;
            set => SetValue(ref _emulated, value);
        }

        public string Region
        {
            get => _region;
            set => SetValue(ref _region, value);
        }

        public SystemModel()
        {
            Platform = "";
            Emulated = false;
            Region = null;
        }
    }
}