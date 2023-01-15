namespace Baselayer.Functions
{
    public static class ShortDateTime
    {
        public static string YearMonthDay(DateTime dateTime)
        {
            return dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day;
        }

        public static string YearMonthDayHourseMinute(DateTime dateTime)
        {
            return dateTime.Year.ToString() + "-"
                + dateTime.Month.ToString() + "-"
                + dateTime.Day + " "
                + dateTime.Hour + ":"
                + dateTime.Minute;
        }

        public static string HourseMinute(DateTime dateTime)
        {
            return dateTime.Hour.ToString() +":"+ dateTime.Minute.ToString();
        }
    }
}
