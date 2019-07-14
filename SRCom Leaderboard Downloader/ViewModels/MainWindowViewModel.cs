using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Data;
using Microsoft.Expression.Interactivity.Core;
using Newtonsoft.Json;
using SRCom_Leaderboard_Downloader.Models;
using SRCom_Leaderboard_Downloader.Types;

namespace SRCom_Leaderboard_Downloader.ViewModels
{
    internal class MainWindowViewModel : PropertyChangedBase
    {
        private bool _downloadEnabled;

        private LeaderboardModel _leaderboard = new LeaderboardModel();

        private ICollectionView _leaderboardCollection;

        private ObservableCollection<OutputModel> _outputCollection;

        public ActionCommand CommandTempFunction { get; }

        public ICollectionView LeaderboardCollection
        {
            get => _leaderboardCollection;
            set => SetValue(ref _leaderboardCollection, value);
        }


        public LeaderboardModel Leaderboard
        {
            get => _leaderboard;
            set => SetValue(ref _leaderboard, value);
        }

        public bool DownloadEnabled
        {
            get => _downloadEnabled;
            set => SetValue(ref _downloadEnabled, value);
        }

        public ObservableCollection<OutputModel> OutputCollection
        {
            get => _outputCollection;
            set => SetValue(ref _outputCollection, value);
        }

        public MainWindowViewModel()
        {
            CommandTempFunction = new ActionCommand(() => DemoSrcTest());
            DownloadEnabled = true;

            RefreshLeaderboardView();
        }

        private void RefreshLeaderboardView()
        {
            LeaderboardCollection = CollectionViewSource.GetDefaultView(Leaderboard.Runs);
        }

        public void DemoSrcTest()
        {
            DownloadEnabled = false;

            var uri = new Uri(@"https://www.speedrun.com/api/v1/leaderboards/sm64/category/120_star?embed=players");

            var client = new WebClient();

            client.DownloadStringCompleted += (sender, e) =>
            {
                var pageSourceCode = e.Result;
                Clipboard.SetText(pageSourceCode);

                SRComData data = JsonConvert.DeserializeObject<SRComData>(pageSourceCode);
               // Leaderboard.UpdateData(data);

                RefreshLeaderboardView();

                MessageBox.Show($"Done! String length: {pageSourceCode.Length}");

                DownloadEnabled = true;
            };

            client.DownloadStringAsync(uri);
        }

        private void ConstructCollection()
        {
            OutputCollection.Clear();


        }
    }
}