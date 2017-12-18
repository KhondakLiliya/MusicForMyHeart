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
            bool loginsuccess = false;
            //foreach(User user in repository.users)
            //{
                if(logintextbox.Text=="Liliya" && passwordbox.Password=="liliya")
                {
                    MessageBox.Show("Correct Password");
                    //repository.currentuser = new User(user.UserID, logintextbox.Text, passwordbox.Password);
                    Music musicwindow = new Music();
                    musicwindow.Show();
                    this.Close();
                    loginsuccess = true;
                    //break;
                }
                if (logintextbox.Text == "Vanya" && passwordbox.Password == "vanya")
                {
                    MessageBox.Show("Correct Password");
                    //repository.currentuser = new User(user.UserID, logintextbox.Text, passwordbox.Password);
                    Music musicwindow = new Music();
                    musicwindow.Show();
                    this.Close();
                    loginsuccess = true;
                    //break;
                }
                if (logintextbox.Text == "Polina" && passwordbox.Password == "polina")
                {
                    MessageBox.Show("Correct Password");
                    //repository.currentuser = new User(user.UserID, logintextbox.Text, passwordbox.Password);
                    Music musicwindow = new Music();
                    musicwindow.Show();
                    this.Close();
                    loginsuccess = true;
                    //break;
                }
            //}
            if (!loginsuccess)
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
