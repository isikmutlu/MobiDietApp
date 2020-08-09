using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDiet
{
    interface IReport
    {
       
        public int ReportID
        {
            get;
        }
        public string ReportType
        {
            get;
            set;
        }
        public DateTime ReportDate
        {
            get;
            
        }
        public void CreateWeeklyReport(int clientID, string reportType)
        {

        }
        public void CreateMonthlyReport(int clientID, string reportType)
        {

        }
        
        
    }
}
