using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class YYYTest
    {
        [TestMethod]
        public void ADayOfWeekCanBeHoliday()
        {
            var holidayCalendar = new HolidayCalendar();
            holidayCalendar.AddHolidayRules((new DayOfWeekHolidayRule(DayOfWeek.Saturday)));
            var aSaturday = new DateTime(2014, 3, 1);
            Assert.IsTrue(holidayCalendar.IsHoliday(aSaturday));
        }

        [TestMethod]
        public void DayOfWeekCanNotBeHoliday()
        {
            var holidayCalendar = new HolidayCalendar();
            holidayCalendar.AddHolidayRules((new DayOfWeekHolidayRule(DayOfWeek.Monday)));
            var aMonday = new DateTime(2014, 3, 4);
            Assert.IsFalse(holidayCalendar.IsHoliday(aMonday));
        }

        [TestMethod]
        public void MoreThanOneDayOfWeekCanBeHoliday()
        {
            var holidayCalendar = new HolidayCalendar();
            holidayCalendar.AddHolidayRules(new DayOfWeekHolidayRule(DayOfWeek.Sunday));
            holidayCalendar.AddHolidayRules(new DayOfWeekHolidayRule(DayOfWeek.Monday));
            var aSunday = new DateTime(2014, 3, 21);
            var aMonday = new DateTime(2014, 3, 19);
            Assert.IsFalse(holidayCalendar.IsHoliday(aSunday));
            Assert.IsFalse(holidayCalendar.IsHoliday(aMonday));
        }

        [TestMethod]
        public void Test1()
        {
            var holidayCalendar = new HolidayCalendar();
            holidayCalendar.AddHolidayRules(new DayOfMonthHolidayRule(1, 1));
            var aJanuaryFirst = new DateTime(2014, 1, 1);
            Assert.IsTrue(holidayCalendar.IsHoliday(aJanuaryFirst));
        }

        [TestMethod]
        public void Test2()
        {
            var holidayCalendar = new HolidayCalendar();
            holidayCalendar.AddHolidayRules(new DayOfMonthHolidayRule(1,1));
            var aChristmas = new DateTime(2014, 12, 1);
            Assert.IsFalse(holidayCalendar.IsHoliday(aChristmas));
        }

        [TestMethod]
        public void Test3()
        {
            var holidayCalendar = new HolidayCalendar();
            holidayCalendar.AddHolidayRules(new DayOfMonthHolidayRule(12, 25));
            var aChristmas = new DateTime(2014, 12, 25);
            Assert.IsTrue(holidayCalendar.IsHoliday(aChristmas));

            holidayCalendar.AddHolidayRules(new DayOfMonthHolidayRule(12, 1));
            var aJanuaryFirst = new DateTime(2014, 1, 1);
            Assert.IsTrue(holidayCalendar.IsHoliday(aJanuaryFirst));
        }

        [TestMethod]
        public void Test4()
        {
            var holidayCalendar = new HolidayCalendar();
            var aDate = new DateTime(2014, 1, 1);
            holidayCalendar.AddHolidayRules(new DateHolidayRule(aDate));
            Assert.IsTrue(holidayCalendar.IsHoliday(aDate));
        }

        [TestMethod]
        public void Test5()
        {
            var holidayCalendar = new HolidayCalendar();
            var aDate = new DateTime(1998, 3, 2);
            holidayCalendar.AddHolidayRules(new CompoundHolyDay(new DateTime(1990, 1, 1), new DateTime(1999, 12, 31), new DayOfWeekHolidayRule(DayOfWeek.Monday)));
            Assert.IsTrue(holidayCalendar.IsHoliday(aDate));
        }
    }
}
