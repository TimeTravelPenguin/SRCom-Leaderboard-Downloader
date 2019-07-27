#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: VariableModel.cs
// 
// Current Data:
// 2019-07-27 8:59 PM
// 
// Creation Date:
// 2019-07-27 8:47 PM

#endregion

using System.Collections.ObjectModel;
using SrcDownloader.Types;

namespace SrcDownloader.Models.SRC_Models
{
    internal class VariableModel : PropertyChangedBase
    {
        private string _category;
        private string _id;
        private bool _isSubCategory;
        private string _name;

        private ObservableCollection<VariableValueModel> _variableValues =
            new ObservableCollection<VariableValueModel>();

        public string Id
        {
            get => _id;
            set => SetValue(ref _id, value);
        }

        public string Name
        {
            get => _name;
            set => SetValue(ref _name, value);
        }

        public string Category
        {
            get => _category;
            set => SetValue(ref _category, value);
        }

        public ObservableCollection<VariableValueModel> VariableValues
        {
            get => _variableValues;
            set => SetValue(ref _variableValues, value);
        }

        public bool IsSubCategory
        {
            get => _isSubCategory;
            set => SetValue(ref _isSubCategory, value);
        }
    }
}