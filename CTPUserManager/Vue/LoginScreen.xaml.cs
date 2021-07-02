using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Net.Http;
using MySql.Data.MySqlClient.Memcached;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CTPUserManager.Controller;

namespace CTPUserManager.Vue
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private static readonly HttpClient client = new HttpClient();


        private async void BtnConnect_Click(object sender, RoutedEventArgs e)
        {
            TokenManager tknman = new TokenManager();

            try
            {
                tknman.ConnectUser(usrname.Text, usrpsw.Password);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'email, l'identifiant ou le mot de passe est incorrect");
                return;
            }

            OpenAfterLogin();

            
        }

        private void OpenAfterLogin()
        {
            MainWindow dashboard = new MainWindow();
            dashboard.Show();

            this.Close();
        }
    }
}
