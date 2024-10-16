using GetWorkDay.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWorkDay
{
    internal class findWorkDays
    {
        private icalRead icalRead;

        internal findWorkDays(icalRead icalRead)
        {
            this.icalRead = icalRead;
        }


        internal RetuneValFindWorkDays GetDays(DateTime start, DateTime end, List<DateTime> dateNotWorks, List<string> NameNotWorks, List<string> WorkHomes, List<bool> weekDay)
        {

            var calendarEvent = this.icalRead.calendarEvent.Where(i => i.DtEnd != null);

            var noEndDate = this.icalRead.calendarEvent.Where(i => i.DtEnd == null && i.DtStart.Date >= start).Select(o => new ObjListStartEnd { Start = Convert.ToDateTime(o.DtStart.Date), End = Convert.ToDateTime(o.DtStart.Date) }).ToList();

            var Event = calendarEvent.Where(i => i.DtEnd.Date >= start && i.DtStart.Date <= end);

            List<ObjListStartEnd> NameNotWorksDato = Event.Where(i => NameNotWorks.Contains(i.Summary)).Select(o => new ObjListStartEnd { Start = Convert.ToDateTime(o.DtStart.Date), End = Convert.ToDateTime(!o.IsAllDay ? o.DtEnd.Date.AddDays(-1) : o.DtEnd.Date.AddDays(-1)) }).ToList();

            NameNotWorksDato.AddRange(noEndDate);

            List<ObjListStartEnd> WorkHomesDato = Event.Where(i => WorkHomes.Contains(i.Summary)).Select(o => new ObjListStartEnd { Start = Convert.ToDateTime(o.DtStart.Date), End = Convert.ToDateTime(!o.IsAllDay ? o.DtEnd.Date.AddDays(-1) : o.DtEnd.Date.AddDays(-1)) }).ToList();

            List<DateTime> BusinessDays = GetBusinessDaysBetween(start, end, weekDay, dateNotWorks);

            List<DateTime> WorkDay = GetAllDayWork(BusinessDays, NameNotWorksDato);

            RetuneValFindWorkDays retuneValFindWorkDays = new RetuneValFindWorkDays
            {
                WorkDay = WorkDay,
                WorkHomesDatos = GetAllDatesBetweenWorkHomesDato(WorkHomesDato)
            };

            return retuneValFindWorkDays;

        }

        private List<DateTime> GetBusinessDaysBetween(DateTime startDate, DateTime endDate, List<bool> weekDay, List<DateTime> dateNotWorks)
        {
            List<DateTime> businessDaysBetween = new List<DateTime>();

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {

                date = new DateTime(date.Year, date.Month, date.Day);


                if (weekDay[(byte)date.DayOfWeek] && !dateNotWorks.Contains(date))
                {
                    businessDaysBetween.Add(date);
                }
            }

            return businessDaysBetween;
        }

        private List<DateTime> GetAllDayWork(List<DateTime> BusinessDays, List<ObjListStartEnd> ObjListStartEnd)
        {
            List<DateTime> WorkDay = new List<DateTime>();

            WorkDay = BusinessDays.Where(dt => !ObjListStartEnd.Any(dr => dt >= dr.Start && dt <= dr.End)).ToList();

            return WorkDay;
        }

        private List<DateTime> GetAllDatesBetweenWorkHomesDato(List<ObjListStartEnd> WorkHomesDato)
        {
            List<DateTime> dates = new List<DateTime>();

            foreach (ObjListStartEnd item in WorkHomesDato)
            {
                for (DateTime date = item.Start; date <= item.End; date = date.AddDays(1))
                {
                    dates.Add(date);
                }

            }

            return dates;
        }

    }


    class ObjListStartEnd
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }

   
}
