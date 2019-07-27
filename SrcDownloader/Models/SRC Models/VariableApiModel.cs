#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: VariableApiModel.cs
// 
// Current Data:
// 2019-07-27 9:13 PM
// 
// Creation Date:
// 2019-07-27 9:12 PM

#endregion

using SrcDownloader.Types;

namespace SrcDownloader.Models.SRC_Models
{
    internal class VariableApiModel : PropertyChangedBase
    {
        private string _id;
        private string _value;

        public string Id
        {
            get => _id;
            set => SetValue(ref _id, value);
        }

        public string Value

        {
            get => _value;
            set => SetValue(ref _value, value);
        }
    }
}