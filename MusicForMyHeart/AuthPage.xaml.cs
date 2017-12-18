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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MusicForMyHeart
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository repository = new Repository();  //дописать конструктор
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            repository.Read();
            MessageBox.Show("Correct!");
            Music musicwindow = new Music();
            musicwindow.Show();
            this.Close();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            repository.Create(Int32.Parse(IDTextBox.Text), logintextbox.Text, passwordbox.Password);
            MessageBox.Show("Saved");
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            repository.Delete(Int32.Parse(IDTextBox.Text), logintextbox.Text, passwordbox.Password);
            MessageBox.Show("Saved");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            repository.Update(Int32.Parse(IDTextBox.Text), logintextbox.Text, passwordbox.Password);
            MessageBox.Show("Saved");
        }
    }
}
