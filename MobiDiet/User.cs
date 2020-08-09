using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MobiDiet
{
    public abstract class User:IMessage, INotification
    {
        //Properties fo the User Class
        public string Text { get; set; }
        public int MessageID { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
        public int NotificationID { get; set; }
        public string NotificationDetail { get; set; }
        public DateTime CreateDate { get; set; }
        public string FullName { get; protected set; }
        public string PassWord { get; protected set; }
        public string UserName { get; protected set; }
        public string Email { get; protected set; }
        public User destclient { get; set; }

        //Constructor for the User Class
        public User(string username, string password, string email, string fullname)
        {
            this.PassWord = password;
            this.UserName = username;
            this.Email = email;
            this.FullName = fullname;
           
        }
                
        
        //Abstract functions for the User class
        public abstract User Register();
        
        public abstract User Login();


        public abstract User Logout();


        public abstract void MessageSent(int MessageID, User destclient, string MessageContent, DateTime MessageDate);

        public abstract void SendNotification(int NotificationID, string NotificationDetail, DateTime CreateDate);

       


    }
}
