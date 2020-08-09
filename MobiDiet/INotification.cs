using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDiet
{
    public interface INotification
    {
        int NotificationID { get; set; }
        string NotificationDetail { get; set; }
        DateTime CreateDate { get; set; }
        void SendNotification(int NotificationID, string NotificationDetail, DateTime CreateDate);
    }
}
