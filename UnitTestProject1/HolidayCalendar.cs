using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    internal class HolidayCalendar: IHolidayRule
    {
        private readonly IList<IHolidayRule> holidayRules = new List<IHolidayRule>();

        public bool IsHoliday(DateTime aDate)
        {
            return holidayRules.Any(_rule => _rule.IsHoliday(aDate));
        }

        internal void AddHolidayRules(IHolidayRule _holidayRule)
        {
            holidayRules.Add(_holidayRule);
        }
    }
}
