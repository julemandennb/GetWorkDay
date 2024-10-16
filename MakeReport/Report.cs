using GetWorkDay.model;
using MakeReport.Model;
using MakeReport.Text;
using Model;

namespace MakeReport
{
    public class Report
    {

        public string paht;
        public RetuneValFindWorkDays retuneValFindWorkDays;
        public DateTime stratDato;
        public DateTime endDato;


        public Report(string paht, RetuneValFindWorkDays retuneValFindWorkDays, DateTime stratDato, DateTime endDato)
        {
            this.paht = paht;
            this.retuneValFindWorkDays = retuneValFindWorkDays;
            this.stratDato = stratDato;
            this.endDato = endDato;
        }

        public bool Make(ReportType.Type reportType)
        {
            switch (reportType)
            {
                case ReportType.Type.Text:
                    return new TxtReport(paht,retuneValFindWorkDays,stratDato,endDato,GetYearMonthPairs()).makeTxt();
                     

                default: return false;
            }
        }


        private List<YearMonth> GetYearMonthPairs()
        {
            List<YearMonth> yearMonthList = new List<YearMonth>();

            DateTime current = new DateTime(stratDato.Year, stratDato.Month, 1);

            while (current <= endDato)
            {

                YearMonth yearMonth = new YearMonth{ 
                    Month = current.Month,
                    Year = current.Year,
                };

                yearMonthList.Add(yearMonth);
                current = current.AddMonths(1); // Move to the next month
            }

            return yearMonthList;
        }






    }


    internal class MonthYear
    {
        public int Month { get; set; }
        public int yaer { get; set; }
    }


}