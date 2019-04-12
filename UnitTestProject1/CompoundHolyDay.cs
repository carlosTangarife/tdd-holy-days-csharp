using System;

namespace UnitTestProject1
{
    internal class CompoundHolyDay : IHolidayRule
    {
        private readonly DateTime from;
        private readonly DateTime to;
        private readonly DayOfWeekHolidayRule holidayRule;

        public CompoundHolyDay(DateTime _from, DateTime _to, DayOfWeekHolidayRule holidayRule)
        {
            this.from = _from;
            this.to = _to;
            this.holidayRule = holidayRule;
        }

        public bool IsHoliday(DateTime aDate)
        {
            return aDate >= this.from && aDate <= this.to && holidayRule.IsHoliday(aDate);
        }
    }
}