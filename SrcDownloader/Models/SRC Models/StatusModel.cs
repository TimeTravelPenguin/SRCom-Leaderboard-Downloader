#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: StatusModel.cs
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
    public class StatusModel : PropertyChangedBase
    {
        private string _examiner;
        private string _reason;
        private string _status;
        private string _verifyDate;

        public string Status
        {
            get => _status;
            set => SetValue(ref _status, value);
        }

        public string Examiner
        {
            get => _examiner;
            set => SetValue(ref _examiner, value);
        }

        public string Reason
        {
            get => _reason;
            set => SetValue(ref _reason, value);
        }

        public string VerifyDate
        {
            get => _verifyDate;
            set => SetValue(ref _verifyDate, value);
        }

        public StatusModel()
        {
            Status = null;
            Examiner = null;
            Reason = null;
            VerifyDate = null;
        }
    }
}