using CTPUserManager.Controller;
using CTPUserManager.Model;
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

namespace CTPUserManager.Vue
{
    /// <summary>
    /// Logique d'interaction pour AddUserView.xaml
    /// </summary>
    public partial class AddUserView : Window
    {

        private AllUsers UserToAdd = new AllUsers();

        public AddUserView()
        {
            InitializeComponent();
        }

        private void Button_AddUser(object sender, RoutedEventArgs e)
        {

            TokenManager tknMan = new TokenManager();

            UserToAdd.Email = this.usrname.Text;
            UserToAdd.Password = this.usrpsw.Text;
            UserToAdd.Firstname = this.usrfirstname.Text;
            UserToAdd.Lastname = this.usrlastname.Text;
            UserToAdd.RoleId = this.usrroleid.Text;

            if(this.usrissuspended.Text == "Faux")
            {
                UserToAdd.IsSuspended = false;
            }
            else
            {
                UserToAdd.IsSuspended = true;
            }


            //if (this.usrroleid.Text == "1")
            //{
            //    UserToAdd.RoleId = "";
            //}
            //else if (this.usrroleid.Text == "2")
            //{
            //    UserToAdd.RoleId = 2;
            //}
            //else if (this.usrroleid.Text == "3")
            //{
            //    UserToAdd.RoleId = 3;
            //}
            //else if (this.usrroleid.Text == "4")
            //{
            //    UserToAdd.RoleId = 4;
            //}
            //else if (this.usrroleid.Text == "5")
            //{
            //    UserToAdd.RoleId = 5;
            //}

            tknMan.addUser(UserToAdd);

            this.Close();
        }
    }
}
