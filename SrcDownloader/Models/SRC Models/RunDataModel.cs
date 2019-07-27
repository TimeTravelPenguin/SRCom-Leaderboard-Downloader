#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: RunDataModel.cs
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
    internal class RunDataModel : PropertyChangedBase
    {
        private string _id;
        private string _name;
        private int _place;
        private string _rel;
        private string _url;

        public int Place
        {
            get => _place;
            set => SetValue(ref _place, value);
        }

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

        public RunDataModel()
        {
            Place = -1;
            Rel = null;
            ID = null;
            Name = null;
            Uri = null;
        }
    }
}