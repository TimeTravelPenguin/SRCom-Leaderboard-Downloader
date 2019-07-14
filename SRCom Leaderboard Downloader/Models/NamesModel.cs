using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
{
    public class NamesModel : PropertyChangedBase
    {
        private string _international;

        private string _japanese;

        public string International
        {
            get => _international;
            set => SetValue(ref _international, value);
        }

        public string Japanese
        {
            get => _japanese;
            set => SetValue(ref _japanese, value);
        }

        public NamesModel()
        {
            International = null;
            Japanese = null;
        }
    }
}