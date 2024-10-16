using GetWorkDay.model;
using MakeReport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeReport.Text
{
    internal class TxtReport
    {
        private string paht;
        private RetuneValFindWorkDays retuneValFindWorkDays;
        private DateTime stratDato;
        private DateTime endDato;
        private List<YearMonth> yearMonths;
        private string line = "-------------------------------------------";

        public TxtReport(string paht, RetuneValFindWorkDays retuneValFindWorkDays, DateTime stratDato, DateTime endDato, List<YearMonth> yearMonths)
        { 
            this.paht = paht;
            this.retuneValFindWorkDays = retuneValFindWorkDays;
            this.stratDato = stratDato;
            this.endDato = endDato;
            this.yearMonths = yearMonths;
        }

        public bool makeTxt()
        {
            try
            {
                List<string> list = new List<string>();

                string startDate = stratDato.ToString("dd/MM - yyyy");
                string endDate = endDato.ToString("dd/MM - yyyy");

                string reportTitle = $"Report Title: Work Day from {startDate} to {endDate}";
                list.Add(reportTitle);
                list.Add(line);
                list.Add(Environment.NewLine);

                string reportTotal = $"Report total: " + Environment.NewLine +
                    $"Your hav total work {retuneValFindWorkDays.WorkDay.Count}. " + Environment.NewLine +
                    $"Your hav total work in office {retuneValFindWorkDays.totalOnOff}. " + Environment.NewLine +
                    $"Your hav total work from home {retuneValFindWorkDays.WorkHomesDatos.Count}." + Environment.NewLine;

                list.Add(reportTotal);
                list.Add(line);
                list.Add(Environment.NewLine);

                foreach (YearMonth yearMonth in yearMonths)
                {
                    list = ReportMonth(list, yearMonth.Month, yearMonth.Year);

                }

                string filePath = paht + "ReportWork.txt";

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var line in list)
                    {
                        writer.WriteLine(line);  // WriteLine automatically adds a newline at the end
                    }
                }

                return true;
            }
            catch (Exception ex) { return false; }
        }


        private List<string> ReportMonth(List<string> list, int month, int year)
        {

            List<DateTime> workHomesDatosMonth = retuneValFindWorkDays.GetWorkHomesDatosMonth(month, year);

            List<DateTime> workDayMonth = retuneValFindWorkDays.GetWorkDayMonth(month, year);

            string reportTitleMonth = $"Report from this month {month} of this year {year}";
            list.Add(reportTitleMonth);
            list.Add(Environment.NewLine);

            string reportMonth = $"Your hav total work {workDayMonth.Count}. " + Environment.NewLine +
                $"Your hav total work in office {workDayMonth.Count - workHomesDatosMonth.Count}. " + Environment.NewLine +
                $"Your hav total work from home {workHomesDatosMonth.Count}." + Environment.NewLine;

            list.Add(reportMonth);
            list.Add(line);
            list.Add(Environment.NewLine);

            return list;
        }





    }
}
