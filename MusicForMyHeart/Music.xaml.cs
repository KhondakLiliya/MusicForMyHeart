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

namespace MusicForMyHeart
{
    /// <summary>
    /// Логика взаимодействия для Music.xaml
    /// </summary>
    public partial class Music : Window
    {
        Context context = new Context();
        
        public Music()
        {
            InitializeComponent();
            context.SongData.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void NewPlaylistButton_Click(object sender, RoutedEventArgs e)
        {
            NewPlaylist newpl = new NewPlaylist();
            newpl.Show();
        }
    }
}
