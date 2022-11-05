
using System;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static double GetDifferenceInDaysBetweemTwoDates(string firstDate, string secondDate)
        {
            DateTime startdate = DateTime.Parse(firstDate);
            DateTime endDate = DateTime.Parse(secondDate);

            double diff = (endDate - startdate).TotalDays;
            double absolutevalue = Math.Abs(diff);

            return absolutevalue;
        }
    }
}
