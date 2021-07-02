using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CTPUserManager.Controller;
using CTPUserManager.Model;
using CTPUserManager.Vue;

namespace CTPUserManager
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {

        private ObservableCollection<AllUsers> MyUsers = new ObservableCollection<AllUsers>();
        public MainWindow()
        {

            InitializeComponent();
            this.DataContext = this;



            this.lstUsers.ItemsSource = MyUsers;

            

        }

        public void refreshMW()
        {
            this.lstUsers.ItemsSource = MyUsers;
        }


        private void Button_GetAllUsers(object sender, RoutedEventArgs e)
        {
            TokenManager tknMan = new TokenManager();

            

            tknMan.getAllUsers();

            this.MyUsers = tknMan.MyUsers;

            Console.WriteLine(MyUsers);

            this.lstUsers.ItemsSource = MyUsers;

            int count = this.lstUsers.Items.Count;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Button_DeleteUser(object sender, RoutedEventArgs e)
        {
            TokenManager tknMan = new TokenManager();

            int idToDelete = ((AllUsers)lstUsers.SelectedItem).Id;

            tknMan.deleteUser(idToDelete);

        }

        private void Button_EditUser(object sender, RoutedEventArgs e)
        {
            
        }
        private void Button_AddUser(object sender, RoutedEventArgs e)
        {
            AddUserView AUV = new AddUserView();
            AUV.Show();
        }
    }
}
