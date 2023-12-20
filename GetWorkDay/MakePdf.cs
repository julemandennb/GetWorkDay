using Ical.Net.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWorkDay
{
    internal class MakePdf
    {

        private icalRead icalRead;



        internal MakePdf(icalRead icalRead) { 
            this.icalRead = icalRead;
        }

        internal void StartGernarePdf(DateTime start, DateTime end,List<DateTime> dateNotWorks,List<string> NameNotWorks, List<string> WorkHomes,List<bool> weekDay)
        {

            var Event = this.icalRead.calendarEvent.Where(i => i.DtStart.Date <= start && i.DtEnd.Date >= end);

            var NameNotWorksDato = Event.Where(i => NameNotWorks.Contains(i.Name)).Select(o => new ObjListStartEnd { Start = Convert.ToDateTime(o.DtStart), End = Convert.ToDateTime(o.DtEnd) }).ToList();

            var WorkHomesDato = Event.Where(i => WorkHomes.Contains(i.Name)).Select(o => new ObjListStartEnd { Start = Convert.ToDateTime(o.DtStart), End = Convert.ToDateTime(o.DtEnd) }).ToList();

            List<DateTime> BusinessDays = GetBusinessDaysBetween(start, end, weekDay, dateNotWorks);

            List<DateTime> WorkDay = GetAllDayWork(BusinessDays, NameNotWorksDato);

        }

        internal List<DateTime> GetBusinessDaysBetween(DateTime startDate, DateTime endDate, List<bool> weekDay, List<DateTime> dateNotWorks)
        {
            List<DateTime> businessDaysBetween = new List<DateTime>();

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (weekDay[(byte)date.DayOfWeek] && !dateNotWorks.Contains(date))
                {
                    businessDaysBetween.Add(date);
                }
            }

            return businessDaysBetween;
        }

        internal List<DateTime> GetAllDayWork(List<DateTime> BusinessDays, List<ObjListStartEnd> ObjListStartEnd)
        {
            List<DateTime> WorkDay = new List<DateTime>();

            WorkDay = BusinessDays.Where(dt => !ObjListStartEnd.Any(dr => dt >= dr.Start && dt <= dr.End)).ToList();

            return WorkDay;
        }

    }
}


class ObjListStartEnd
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}
