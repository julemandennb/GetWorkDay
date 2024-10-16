using GetWorkDay.model;
using Model;

namespace MakeReport
{
    public class Report
    {

        private string paht;
        private RetuneValFindWorkDays retuneValFindWorkDays;
        private DateTime stratDato;
        private DateTime endDato;

        public Report(string paht, RetuneValFindWorkDays retuneValFindWorkDays, DateTime stratDato, DateTime endDato)
        {
            this.paht = paht;
            this.retuneValFindWorkDays = retuneValFindWorkDays;
            this.stratDato = stratDato;
            this.endDato = endDato;
        }

        public bool Make(ReportType.Type reportType)
        {
            switch(reportType)
            {
                case ReportType.Type.Text: return true;

                default: return false;
            }
        }



    }
}