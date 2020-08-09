using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MobiDiet
{
    public class Dietitian :User

    {
        
        public Dietitian(string username, string password, string email, string fullname):base(username, password, email, fullname)
        {

        }

        public override User Register()
        {
            throw new Exception();
        }

        public override User Login()
        {
            throw new Exception();
        }

        public override User Logout()
        {
            throw new Exception();
        }
        public override void SendNotification(int NotificationID, string NotificationDetail, DateTime CreateDate)
        {

        }
        public void getNotification(INotification notification)

        {
           notification.SendNotification(NotificationID, NotificationDetail, CreateDate);
          
   
        }
        public void viewClientProfile(int clientID)
        {

        }
        
        public override void MessageSent(int MessageID, User destclient, string MessageContent, DateTime MessageDate)
        {

        }
        public void sendMessage(IMessage message)
        {
            message.MessageSent(MessageID, destClient, MessageContent, MessageDate);
        }
    }
}
