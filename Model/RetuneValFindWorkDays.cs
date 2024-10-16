using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWorkDay.model
{
    public class RetuneValFindWorkDays
    {
        /// <summary>
        /// Work from office dato
        /// </summary>
        public List<DateTime> WorkDay { get; set; }

        /// <summary>
        /// Work from Homes dato
        /// </summary>
        public List<DateTime> WorkHomesDatos { get; set; }

        /// <summary>
        /// get total of day in office
        /// </summary>
        public int totalOnOff { get { return WorkDay.Count - WorkHomesDatos.Count; } }

        /// <summary>
        /// get Work from Homes Months
        /// </summary>
        public List<int> GetWorkHomesDatosMonths { get { return WorkHomesDatos.Select(date => date.Month).Distinct().OrderBy(month => month).ToList(); }}

        /// <summary>
        /// get Work from office Months
        /// </summary>
        public List<int> GetWorkDayMonths { get { return WorkDay.Select(date => date.Month).Distinct().OrderBy(month => month).ToList(); } }

        /// <summary>
        /// to get all dato from Work from Homes from this month and year
        /// </summary>
        /// <param name="month">get dato from this month</param>
        /// <param name="year">get dato from this year</param>
        /// <returns>list of dato </returns>
        public List<DateTime> GetWorkHomesDatosMonth(int month,int year)
        {
            List<DateTime> result = WorkHomesDatos.Where(x=> x.Month == month && x.Year == year).ToList();

            return result;

        }

        /// <summary>
        /// to get all dato from Work from office from this month and year
        /// </summary>
        /// <param name="month">get dato from this month</param>
        /// <param name="year">get dato from this year</param>
        /// <returns>list of dato </returns>
        public List<DateTime> GetWorkDayMonth(int month,int year)
        {
            List<DateTime> result = WorkDay.Where(x => x.Month == month && x.Year == year).ToList();

            return result;

        }

    }
}
