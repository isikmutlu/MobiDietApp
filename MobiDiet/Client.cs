using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MobiDiet
{
    class Client : User, IReport, IDailyFoodEaten
    {

        
        public int ClientID { get; }
        public string SubscriptionType { get; set; }
        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public int Init_Weight { get; set; }
        public int Curr_Weight { get; set; }
        public int Height { get; set; }
        public string ActivityLevel { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Allergy { get; set; }
        public string Gender { get; }
        public int ReportID{ get;}
        public string ReportType{get;set;}
        public DateTime ReportDate{get;}



        Client(string username, string password, string email, int clientID, string fullName, string subscriptionType) : base(username, password, email, fullName)
        {
            this.ClientID = clientID;
            this.SubscriptionType = subscriptionType;
            Console.WriteLine("Welcome {0}", this.UserName);
        }
        public Client ClientInfo(string username, string password)
        {
            this.UserName = username;
            this.PassWord = password;

        }

        public override User Register()
        {
            throw new Exception();
        }
        public override User Login()
        {
            return ClientInfo(UserName, PassWord);
        }

        public override User Logout()
        {
            throw new Exception();
        }

        public int Age(DateTime birthDate)
        {
            this.BirthDate = birthDate;
            int age = (Int32.Parse(DateTime.Today.ToString("yyyyMMdd")) - Int32.Parse(birthDate.ToString("yyyyMMdd"))) / 10000;
            return age;
        }
        public double BMR(int currentWeight, int height, int age, string gender)
        {
            this.Height = height;
            this.Curr_Weight = currentWeight;

            if (gender == "women")
            {
                return (447.593 + (9.247 * currentWeight) + (3.098 * height) - (4.330 * age));
            }
            else
            {
                return (88.362 + (13.397 * currentWeight) + (4.799 * height) - (5.677 * age));

            }
        }
        public void viewProfile()
        {
            Console.WriteLine("Profile of {0}", UserName);
            Console.WriteLine("Initial Weight: {0}", Init_Weight);
            Console.WriteLine("Current Weight: {0}", Curr_Weight);
            Console.WriteLine("You lost {0}kg", (Curr_Weight - Init_Weight));
            Console.WriteLine("Your Basal Metabolic Rate: {0}", BMR(this.Curr_Weight, this.Height, this.Age(this.BirthDate), Gender));

        }
        public void editProfile()
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
        public void MessageSent()
        {
            throw new NotImplementedException();
        }
        public override void MessageSent(int MessageID, User destclient, string MessageContent, DateTime MessageDate)
        {

        }
        public void viewMessage(IMessage message)
        {
            message.MessageSent(MessageID, destclient, MessageContent, MessageDate);
        }
        public void viewReport(string reportType)
        {
            throw new Exception();
        }
        public void SaveDailyFoodEaten()
        {

        }

        public void SubmitDailyFoodEaten()
        {

        }

        public void createDailyFood(IDailyFoodEaten foodEaten)
        {
            foodEaten.SaveDailyFoodEaten();

            foodEaten.SubmitDailyFoodEaten();
        }
    }
}
