using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
using MiniTorrent;
using MiniTorrent.Models;
using MiniTorrent.Services;

namespace MiniTorrentUserInterface
{
    /// <summary>
    /// Interaction logic for UserMainFileSystem.xaml
    /// </summary>
    public partial class UserMainFileSystem : Window
    {

        public UserMainFileSystem()
        {
            InitializeComponent();
            tbName.Text = "";

        }

        private void btSearch_Click(object sender, RoutedEventArgs e)
        {
            FileManagerService service = new FileManagerService();
            List<MyFile> mySearch = service.FindFile(tbName.Text.Trim());
            dtGrid.ItemsSource = mySearch;
           
            

        }

        private void BtDownload_Click_1(object sender, RoutedEventArgs e)
        {
            string directortyPath;
            if (dtGrid.SelectedCells.Count > 0)
            {
                try
                {

                    MyFile toDownload = (MyFile)dtGrid.SelectedItem;
                    MessageBox.Show(toDownload.name);
                    OpenFileDialog sfd = new OpenFileDialog();
                    if (sfd.ShowDialog() == DialogResult)
                    {

                    }
                catch
                {
                    
                }
                
            }
        }
    }
}
