using System.Windows;
using SRCom_Leaderboard_Downloader.ViewModels;

namespace SRCom_Leaderboard_Downloader.Views
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