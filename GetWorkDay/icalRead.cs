﻿using Ical.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Security.Policy;
using Ical.Net.CalendarComponents;
using System.Net.Http.Json;

namespace GetWorkDay
{
    internal class icalRead
    {

        

        public List<CalendarEvent> ReadGoogle(string url) {
          
            string icl = "";

            using (WebClient client = new WebClient()) { 

                icl = client.DownloadString(url);
            }

            if (icl.Length > 0)
            {

                var iclList = icl.Split("BEGIN:VEVENT", 2);

                string newicl = iclList.Length > 0 ? "BEGIN:VEVENT" + Environment.NewLine + iclList[1] : icl;

                newicl = newicl.Replace("END:VCALENDAR", "");

                List<CalendarEvent> calendarEvent = Calendar.Load<CalendarEvent>(newicl).ToList<CalendarEvent>();

                return calendarEvent;

            }
            return null;

        }



    }
}
