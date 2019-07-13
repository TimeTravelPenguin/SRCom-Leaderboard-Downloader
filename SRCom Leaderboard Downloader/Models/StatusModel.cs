using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
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