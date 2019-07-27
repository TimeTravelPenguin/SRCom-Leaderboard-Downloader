#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: SystemModel.cs
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
    public class SystemModel : PropertyChangedBase
    {
        private bool _emulated;
        private string _platform;
        private string _region;

        public string Platform
        {
            get => _platform;
            set => SetValue(ref _platform, value);
        }

        public bool Emulated
        {
            get => _emulated;
            set => SetValue(ref _emulated, value);
        }

        public string Region
        {
            get => _region;
            set => SetValue(ref _region, value);
        }

        public SystemModel()
        {
            Platform = "";
            Emulated = false;
            Region = null;
        }
    }
}