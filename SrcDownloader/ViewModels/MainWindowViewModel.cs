#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: MainWindowViewModel.cs
// 
// Current Data:
// 2019-07-27 9:00 PM
// 
// Creation Date:
// 2019-07-12 10:08 PM

#endregion

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using AutoUpdaterDotNET;
using Microsoft.Expression.Interactivity.Core;
using SrcDownloader.Models;
using SrcDownloader.Models.SRC_Models;
using SrcDownloader.Types;
using SRCom_Leaderboard_Downloader.Models;

namespace SrcDownloader.ViewModels
{
    internal class MainWindowViewModel : PropertyChangedBase
    {
        private bool _downloadEnabled;

        private LeaderboardModel _leaderboard = new LeaderboardModel();

        private ICollectionView _leaderboardCollection;

        private ObservableCollection<OutputDataModel> _outputCollection;

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

        public ObservableCollection<OutputDataModel> OutputCollection
        {
            get => _outputCollection;
            set => SetValue(ref _outputCollection, value);
        }

        private SrcProcessor SrcProcessor { get; } = new SrcProcessor();

        public MainWindowViewModel()
        {
            ApiHelper.InitializeClient();

            //CommandTempFunction = new ActionCommand(GetUpdate);
            CommandTempFunction = new ActionCommand(DemoSrcTest);
            DownloadEnabled = true;

            RefreshLeaderboardView();
        }

        private void RefreshLeaderboardView()
        {
            LeaderboardCollection = CollectionViewSource.GetDefaultView(Leaderboard.Runs);
        }

        public void GetUpdate()
        {
            AutoUpdater.Start(
                @"https://raw.githubusercontent.com/TimeTravelPenguin/SRCom-Leaderboard-Downloader/master/testXML.xml");
            MessageBox.Show("Done");
        }

        public void DemoSrcTest()
        {
            DownloadEnabled = false;

            /* Old code

            var uri = new Uri(@"https://www.speedrun.com/api/v1/leaderboards/sm64/category/120_star?embed=players");

            var client = new WebClient();

            client.DownloadStringCompleted += (sender, e) =>
            {
                var pageSourceCode = e.Result;
                Clipboard.SetText(pageSourceCode);

                SrcData data = JsonConvert.DeserializeObject<SrcData>(pageSourceCode);
               // Leaderboard.UpdateData(data);

                RefreshLeaderboardView();

                MessageBox.Show($"Done! String length: {pageSourceCode.Length}");

                DownloadEnabled = true;
            };

            client.DownloadStringAsync(uri);

            */

            var variables = new ObservableCollection<VariableApiModel>()
            {
                new VariableApiModel()
                {
                    Id = "id001",
                    Value = "val01"
                },
                new VariableApiModel()
                {
                    Id = "id002",
                    Value = "val02"
                }
            };
            var data = SrcProcessor.LoadSrcGameData("sm64", "120_star", variables.ToArray());
            
            DownloadEnabled = true;
        }

        private void ConstructCollection()
        {
            OutputCollection.Clear();
        }
    }
}