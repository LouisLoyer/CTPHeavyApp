using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CTPUserManager.Model
{
    public class AllUsers : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set {

                id = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { 
                if(email != value)
                    {
                    email = value;
                        OnPropertyChanged();
                    }
                }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }

        private string firstname;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private bool isSuspended;

        public bool IsSuspended
        {
            get { return isSuspended; }
            set { isSuspended = value; }
        }

        private string roleId;

        public string RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }

        private string createdAt;

        public string CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        private string updatedAt;
        public string UpdatedAt
        {
            get { return updatedAt; }
            set { updatedAt = value; }
        }

        private Role role;
        public Role Role
        {
            get => role;
            set => role = value;
        }

        public AllUsers()
        {
            Role = new Role();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
