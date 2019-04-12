using System;

namespace UnitTestProject1
{
    public class DayOfWeekHolidayRule: IHolidayRule
    {
        public DayOfWeek ADayOfWeek { get; set; }

        public DayOfWeekHolidayRule(DayOfWeek aDayOfWeek)
        {
            ADayOfWeek = aDayOfWeek;
        }

        public bool IsHoliday(DateTime aDate)
        {
            return aDate.DayOfWeek.Equals(ADayOfWeek);
        }
    }
}
