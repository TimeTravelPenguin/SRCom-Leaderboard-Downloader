using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
{
    internal class OutputModel : PropertyChangedBase
    {
        private string _name;

        private float _time;

        public string Name
        {
            get => _name;
            set => SetValue(ref _name, value);
        }

        public float Time
        {
            get => _time;
            set => SetValue(ref _time, value);
        }

        public OutputModel()
        {
            Name = "";
            Time = 0;
        }
    }
}