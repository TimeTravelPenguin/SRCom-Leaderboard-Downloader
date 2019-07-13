using System.Collections.ObjectModel;
using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
{
    public class VideoModel : PropertyChangedBase
    {
        private ObservableCollection<VideoLinkModel> _links;
        private int _text;

        public int Text
        {
            get => _text;
            set => SetValue(ref _text, value);
        }

        public ObservableCollection<VideoLinkModel> Links
        {
            get => _links;
            set => SetValue(ref _links, value);
        }
    }
}