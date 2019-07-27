#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: PlayerModel.cs
// 
// Current Data:
// 2019-07-27 7:35 PM
// 
// Creation Date:
// 2019-07-27 6:27 PM

#endregion

using SrcDownloader.Types;

namespace SrcDownloader.Models.SRC_Models
{
    public class PlayerModel : PropertyChangedBase
    {
        private string _id;
        private NamesModel _names;
        private RegionModel _region;
        private string _role;
        private string _webLink;

        public string Role
        {
            get => _role;
            set => SetValue(ref _role, value);
        }

        public string ID
        {
            get => _id;
            set => SetValue(ref _id, value);
        }

        public NamesModel Names
        {
            get => _names;
            set => SetValue(ref _names, value);
        }

        public string WebLink
        {
            get => _webLink;
            set => SetValue(ref _webLink, value);
        }

        public RegionModel Region
        {
            get => _region;
            set => SetValue(ref _region, value);
        }

        public PlayerModel()
        {
            Role = null;
            ID = null;
            Names = new NamesModel();
            WebLink = null;
            Region = new RegionModel();
        }
    }
}