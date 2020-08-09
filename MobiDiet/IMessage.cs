using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDiet
{
    public interface IMessage
    {


        int MessageID { get; set; }
        string MessageContent { get; set; }
        DateTime MessageDate { get; set; }

        void MessageSent(int MessageID, User destclient, string MessageContent, DateTime MessageDate);
            
            

        
    }
}
