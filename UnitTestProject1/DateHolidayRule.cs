using System;

namespace UnitTestProject1
{
    public class DateHolidayRule : IHolidayRule
    {
        public DateTime ADate { get; set; }

        public DateHolidayRule(DateTime _aDate)
        {
            ADate = _aDate;
        }

        public bool IsHoliday(DateTime aDate)
        {
            return ADate.Equals(aDate);
        }
    }
}
