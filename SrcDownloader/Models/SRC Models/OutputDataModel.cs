#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: OutputDataModel.cs
// 
// Current Data:
// 2019-07-27 7:35 PM
// 
// Creation Date:
// 2019-07-27 6:29 PM

#endregion

using SrcDownloader.Types;

namespace SrcDownloader.Models.SRC_Models
{
    internal class OutputDataModel : PropertyChangedBase
    {
        private string _name;

        private float _time;

        public string Name
        {
            get => _name;
            set => SetValue(ref _name, value);
        }

        public float Time
        {
            get => _time;
            set => SetValue(ref _time, value);
        }

        public OutputDataModel()
        {
            Name = "";
            Time = 0;
        }
    }
}