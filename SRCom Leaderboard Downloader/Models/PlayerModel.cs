using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
{
    public class PlayerModel : PropertyChangedBase
    {
        private string _id;
        private string _name;
        private string _rel;
        private string _url;

        public string Rel
        {
            get => _rel;
            set => SetValue(ref _rel, value);
        }

        public string ID
        {
            get => _id;
            set => SetValue(ref _id, value);
        }

        public string Name
        {
            get => _name;
            set => SetValue(ref _name, value);
        }

        public string Uri
        {
            get => _url;
            set => SetValue(ref _url, value);
        }

        public PlayerModel()
        {
            Rel = null;
            ID = null;
            Name = null;
            Uri = null;
        }
    }
}