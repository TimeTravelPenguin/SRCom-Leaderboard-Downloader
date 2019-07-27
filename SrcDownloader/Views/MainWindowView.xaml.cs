#region Title Header

// Name: Phillip Smith
// 
// Solution: SrcDownloader
// Project: SrcDownloader
// File Name: MainWindowView.xaml.cs
// 
// Current Data:
// 2019-07-27 7:35 PM
// 
// Creation Date:
// 2019-07-12 10:25 PM

#endregion

using System.Windows;
using SrcDownloader.ViewModels;

namespace SrcDownloader.Views
{
    /// <summary>
    ///     Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        private MainWindowViewModel ViewModel => DataContext as MainWindowViewModel;

        public MainWindowView()
        {
            InitializeComponent();
        }
    }
}