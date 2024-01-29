using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifference
{
    public  class DateModifier
    {
        public static int DateDifference(string startDateAsString, string endDateAsString)
        {
            DateTime startDate = DateTime.Parse(startDateAsString);
            DateTime endDate = DateTime.Parse(endDateAsString);

            TimeSpan difference = endDate - startDate;

            return Math.Abs(difference.Days);
        }
    }
}
