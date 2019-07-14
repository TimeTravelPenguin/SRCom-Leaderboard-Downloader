using System.Collections.ObjectModel;
using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.Models
{
    internal class LeaderboardModel : PropertyChangedBase
    {
        private string _category;

        private bool? _emulators;

        private string _game;

        private string _level;

        private string _platform;

        private string _region;

        private ObservableCollection<RunDataModel> _runs;

        private string _timing;

        private bool _videoOnly;

        private string _webLink;

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

        public string Category
        {
            get => _category;
            set => SetValue(ref _category, value);
        }

        public string Level
        {
            get => _level;
            set => SetValue(ref _level, value);
        }

        public string Platform
        {
            get => _platform;
            set => SetValue(ref _platform, value);
        }

        public string Region
        {
            get => _region;
            set => SetValue(ref _region, value);
        }

        public bool? Emulators
        {
            get => _emulators;
            set => SetValue(ref _emulators, value);
        }

        public bool VideoOnly
        {
            get => _videoOnly;
            set => SetValue(ref _videoOnly, value);
        }

        public string Timing
        {
            get => _timing;
            set => SetValue(ref _timing, value);
        }

        public ObservableCollection<RunDataModel> Runs
        {
            get => _runs;
            set => SetValue(ref _runs, value);
        }

        public LeaderboardModel()
        {
            Runs = new ObservableCollection<RunDataModel>();
            SetDefaults();
        }

        private void SetDefaults()
        {
            Category = "";
            Emulators = null;
            Game = "";
            Level = "";
            Platform = "";
            Region = "";
            Runs.Clear();
            Timing = "realtime";
            VideoOnly = false;
            WebLink = @"https://www.speedrun.com/";
        }

        internal void UpdateData(LeaderboardModel leaderboardModel)
        {
            Category = leaderboardModel.Category;
            Emulators = leaderboardModel.Emulators;
            Game = leaderboardModel.Game;
            Level = leaderboardModel.Level;
            Platform = leaderboardModel.Platform;
            Region = leaderboardModel.Region;
            Timing = leaderboardModel.Timing;
            VideoOnly = leaderboardModel.VideoOnly;
            WebLink = leaderboardModel.WebLink;

            Runs.Clear();
            foreach (var run in leaderboardModel.Runs)
            {
                Runs.Add(new RunDataModel
                {
                    Place = run.Place,
                    Name = run.Name,
                    ID = run.ID,
                    Rel = run.Rel,
                    Uri = run.Uri
                });
            }
        }
    }
}