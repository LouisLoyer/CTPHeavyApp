 using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CTPUserManager.Model;
using System.Collections.ObjectModel;

namespace CTPUserManager.Controller
{
    class TokenManager
    {
        private static User user = new User();

        private static readonly HttpClient client = new HttpClient();


        public async void ConnectUser(string usrname, string usrpsw)
        {
            var values = new Dictionary<string, string>
        {
            { "email", usrname },
            { "password", usrpsw }
        };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://localhost:3000/api/user-connect", content);


            var responseString = await response.Content.ReadAsStringAsync();


            Console.WriteLine(responseString);

            var data = (JObject)JsonConvert.DeserializeObject(responseString);
            string result = data["result"].Value<string>();
            string token = data["token"].Value<string>();

            user.Settoken(token);

            Console.WriteLine(user);
        }

        public ObservableCollection<AllUsers> MyUsers = new ObservableCollection<AllUsers>();
        public async void getAllUsers()
        {

            var url = "http://localhost:3000/api/user/all";

           /* var httpRequest = (HttpWebRequest)WebRequest.Create(url);


            //httpRequest.Accept = "application/json";
            //eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyIjoxLCJpYXQiOjE2MjM5MjEyNTYsImV4cCI6MTYyMzkyNDg1Nn0.zmZ6P4N_MetaLbQjcSjyZQ4KmDp6-EECjVLZWMMx63M
            httpRequest.Headers["Authorization"] = "Bearer " + user.Gettoken() + "";
            //httpRequest.Headers["Authorization"] = "Bearer " + User.Gettoken() + "";

            

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {


                string result = streamReader.ReadToEnd();
                
                result = result.Remove(result.Length - 1);
                result = result.Remove(0, 1);
                Console.WriteLine(result);

                var data = JsonConvert.DeserializeObject<AllUsers>(result.Replace("\"","\'"));


                /*string email = data["email"].Value<string>();
                string password = data["password"].Value<string>();
                int id = data["id"].Value<int>();
                string firstname = data["firstname"].Value<string>();
                string lastname = data["lastname"].Value<string>();
                bool isSuspended = data["isSuspended"].Value<bool>();
                int roleId = data["roleId"].Value<int>();

                MyUsers.Add(new AllUsers { Email = email, Password = password, Id = id, Firstname = firstname, Lastname = lastname, IsSuspended = isSuspended, RoleId = roleId });
           
            }*/
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + user.Gettoken());
            var content = httpClient.GetStringAsync(url).Result;

            //var result = content.Remove(content.Length - 1);
            //result = result.Remove(0, 1);

            var data = JsonConvert.DeserializeObject<List<AllUsers>>(content);

            foreach(AllUsers dat in data)
            {
                string email = dat.Email;
                string password = dat.Password;
                int id = dat.Id;
                string firstname = dat.Firstname;
                string lastname = dat.Lastname;
                bool isSuspended = dat.IsSuspended;
                string roleId = dat.RoleId;

                MyUsers.Add(new AllUsers { Email = email, Password = password, Id = id, Firstname = firstname, Lastname = lastname, IsSuspended = isSuspended, RoleId = roleId });
            }

            //Console.WriteLine(httpResponse.StatusCode);

        }

        public void editUser(int id)
        {
            //using (var client = new HttpClient())
            //{

            //    //client.BaseAddress = new Uri("http://localhost:3000/");

                

            //    client.BaseAddress = new Uri("http://localhost:1565/");

            //    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + user.Gettoken());

            //    var response = client.PutAsJsonAsync("api/person", p).Result;
            //    if (response.IsSuccessStatusCode)
            //    {
            //        Console.Write("Success");
            //    }
            //    else
            //        Console.Write("Error");
            //}
        }

        public void deleteUser(int id)
        {
            using (var client = new HttpClient())
            {

                //client.BaseAddress = new Uri("http://localhost:3000/");

                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + user.Gettoken());

                var response = client.DeleteAsync("http://localhost:3000/api/user/delete/" + id + "").Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Success");
                }
                else { 
                    Console.WriteLine("Error");
                }
            }
        }

        public async void addUser(AllUsers user)
        {
            var userToAdd = JsonConvert.SerializeObject(user);

            string email = user.Email;
            string password = user.Password;
            int id = user.Id;
            string firstname = user.Firstname;
            string lastname = user.Lastname;
            bool isSuspended = user.IsSuspended;
            string roleId = user.RoleId;

            var values = new Dictionary<string, string>
        {
            { "email", email },
            { "password", password },
            { "firstname", firstname },
            { "lastname", lastname },
            { "roleId", roleId }
        };

            var content = new FormUrlEncodedContent(values);          

            var response = await client.PostAsync("http://localhost:3000/user-register", content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }



    }
}
