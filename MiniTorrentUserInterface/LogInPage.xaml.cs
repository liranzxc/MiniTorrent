using System.Diagnostics;
using System.Net;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using MiniTorrent;


namespace MiniTorrentUserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btRegister_Click(object sender, RoutedEventArgs e)
        {

            Process.Start("http://localhost:31058/WebPortal/Register.aspx");
        }

        private void btLogIn_Click(object sender, RoutedEventArgs e)
        {
            UserMainFileSystem user = new UserMainFileSystem();
            user.Show();
            this.Close();
        }
    }
}
