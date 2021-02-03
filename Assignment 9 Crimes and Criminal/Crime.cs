using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_9_Crimes_and_Criminals
{
    class Crime
    {
        private DateTime Date;
        private string Location;
        private string Act;

        public Crime(DateTime Date, string Location, string Act)
        {
            this.Date = Date;
            this.Location = Location;
            this.Act = Act;
        }

        public string GetLocation()
        {
            return Location;
        }
        public string GetAct()
        {
            return Act;
        }
    }
}