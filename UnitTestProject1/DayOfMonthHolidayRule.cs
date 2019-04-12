using System;

namespace UnitTestProject1
{
    public class DayOfMonthHolidayRule : IHolidayRule
    {
        public int aDayNumber{ get; set; }
        public int aMonthNumber { get; set; }

        public DayOfMonthHolidayRule(int monthNumber, int dayNumber)
        {
            aDayNumber = dayNumber;
            aMonthNumber = monthNumber;
        }

        public bool IsHoliday(DateTime aDate)
        {
            return aDate.Month.Equals(aMonthNumber) && aDate.Day.Equals(aDayNumber);
        }
    }
}
