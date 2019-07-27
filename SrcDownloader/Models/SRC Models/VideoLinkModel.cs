using SrcDownloader.Types;

namespace SrcDownloader.Models.SRC_Models
{
    public class VideoLinkModel : PropertyChangedBase
    {
        private string _uri;

        public string Uri
        {
            get => _uri;
            set => SetValue(ref _uri, value);
        }
    }
}