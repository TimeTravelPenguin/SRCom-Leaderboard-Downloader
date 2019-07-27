#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: VariableValueModel.cs
// 
// Current Data:
// 2019-07-27 8:56 PM
// 
// Creation Date:
// 2019-07-27 8:53 PM

#endregion

using SrcDownloader.Types;

namespace SrcDownloader.Models.SRC_Models
{
    internal class VariableValueModel : PropertyChangedBase
    {
        private string _id;
        private string _label;
        private string _rules;

        public string Id
        {
            get => _id;
            set => SetValue(ref _id, value);
        }

        public string Label
        {
            get => _label;
            set => SetValue(ref _label, value);
        }

        public string Rules
        {
            get => _rules;
            set => SetValue(ref _rules, value);
        }
    }
}