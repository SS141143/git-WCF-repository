using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceTask
{
    
    public class Service1 : IService1
    {
        public string SayHello(string name)
        {
            var msg = string.Empty;
            if (DateTime.Now.Hour < 12)
            {
                msg = "Good Morning";
            }
            else if (DateTime.Now.Hour < 17)
            {
                msg = "Good Afternoon";
            }
            else
            {
                msg = "Good Evening";
            }
            return string.Format("Hi {0} - {1}", name, msg);
        }

        public string TodayProgram(string name)
        {
            var msg = string.Empty;
            if (DateTime.Today.DayOfWeek.Equals("Saturday") || DateTime.Today.DayOfWeek.Equals("Sunday"))
            {
                msg = "Happy Weekend";
            }
            else
            {
                msg = "Enjoy Working day";
            }
            return string.Format("Hi {0} - {1}", name, msg);
        }
    }
}
