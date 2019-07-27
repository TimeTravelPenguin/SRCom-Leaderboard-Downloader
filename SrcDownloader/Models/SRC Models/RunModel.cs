#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: RunModel.cs
// 
// Current Data:
// 2019-07-27 7:43 PM
// 
// Creation Date:
// 2019-07-27 6:27 PM

#endregion

using System.Collections.ObjectModel;
using SrcDownloader.Types;

namespace SrcDownloader.Models.SRC_Models
{
    internal class RunModel : PropertyChangedBase
    {
        private string _category;
        private string _comment;
        private string _date;
        private string _game;
        private string _id;
        private string _level;
        private ObservableCollection<PlayerModel> _players;
        private StatusModel _status;
        private string _submitted;
        private SystemModel _system;
        private TimeModel _times;
        private ObservableCollection<VideoModel> _videos;
        private string _webLink;

        public string ID
        {
            get => _id;
            set => SetValue(ref _id, value);
        }

        public string WebLink
        {
            get => _webLink;
            set => SetValue(ref _webLink, value);
        }

        public string Game
        {
            get => _game;
            set => SetValue(ref _game, value);
        }

        public string Level
        {
            get => _level;
            set => SetValue(ref _level, value);
        }

        public string Category
        {
            get => _category;
            set => SetValue(ref _category, value);
        }

        public ObservableCollection<VideoModel> Videos
        {
            get => _videos;
            set => SetValue(ref _videos, value);
        }

        public string Comment
        {
            get => _comment;
            set => SetValue(ref _comment, value);
        }

        public StatusModel Status
        {
            get => _status;
            set => SetValue(ref _status, value);
        }

        public ObservableCollection<PlayerModel> Players
        {
            get => _players;
            set => SetValue(ref _players, value);
        }

        public string Date
        {
            get => _date;
            set => SetValue(ref _date, value);
        }

        public string Submitted
        {
            get => _submitted;
            set => SetValue(ref _submitted, value);
        }

        public TimeModel Times
        {
            get => _times;
            set => SetValue(ref _times, value);
        }

        public SystemModel System
        {
            get => _system;
            set => SetValue(ref _system, value);
        }

        public RunModel()
        {
            ID = "";
            WebLink = "";
            Game = "";
            Level = null;
            Category = "";
            Videos = new ObservableCollection<VideoModel>();
            Comment = "";
            Status = new StatusModel();
            Players = new ObservableCollection<PlayerModel>();
            Date = "";
            Submitted = null;
            Times = new TimeModel();
            System = new SystemModel();
        }
    }
}