using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
{
    public class VideoLinkModel : PropertyChangedBase
    {
        private string _uri;

        public string Uri
        {
            get => _uri;
            set => SetValue(ref value, value);
        }
    }
}