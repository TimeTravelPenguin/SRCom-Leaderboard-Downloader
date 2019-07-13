using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
{
    internal class RunModel : PropertyChangedBase
    {
        private string _id;

        private string _webLink;

        public string ID
        {
            get => _id;
            set => SetValue(ref _id, value);
        }

        public string WebLink
        {
            get => _webLink;
            set => SetValue(ref _webLink, value);
        }
    }
}

// https://github.com/speedruncomorg/api/blob/master/version1/runs.md