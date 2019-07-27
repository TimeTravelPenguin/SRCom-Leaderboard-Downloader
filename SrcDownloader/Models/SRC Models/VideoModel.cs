using System.Collections.ObjectModel;
using SrcDownloader.Types;

namespace SrcDownloader.Models.SRC_Models
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