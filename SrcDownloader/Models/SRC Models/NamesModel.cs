#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: NamesModel.cs
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