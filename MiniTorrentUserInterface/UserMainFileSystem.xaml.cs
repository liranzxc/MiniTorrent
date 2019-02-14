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
using MiniTorrent;

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
            DataGridTextColumn NameColum = new DataGridTextColumn();
            DataGridTextColumn SizeColum = new DataGridTextColumn();
            DataGridTextColumn NumberOfResourceColum = new DataGridTextColumn();
            NameColum.Header = "File Name";
            SizeColum.Header = "File Size";
            NumberOfResourceColum.Header = "Number Of Active Resources";
            dtGrid.Columns.Add(NameColum);
            dtGrid.Columns.Add(SizeColum);
            dtGrid.Columns.Add(NumberOfResourceColum);
        }

        private void btSearch_Click(object sender, RoutedEventArgs e)
        {

        }

    
    }
}
