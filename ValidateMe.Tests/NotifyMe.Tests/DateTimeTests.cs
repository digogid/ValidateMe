using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidateMe.Tests
{
    [TestClass]
    public class DateTimeTests
    {
        [TestMethod]
        public void Must_ValidateDateTime()
        {
            DateTime testedDateTime = DateTime.Now.AddDays(-1);
            var returned = testedDateTime.MustBePast();
            Assert.IsTrue(returned);

            testedDateTime = DateTime.Now.AddDays(1);
            returned = testedDateTime.MustBeFuture();
            Assert.IsTrue(returned);

            testedDateTime = DateTime.Now;
            returned = testedDateTime.MustBeToday();
            Assert.IsTrue(returned);

            testedDateTime = DateTime.Now.AddDays(1);
            returned = testedDateTime.MustBeTomorrow();
            Assert.IsTrue(returned);

            testedDateTime = DateTime.Now.AddDays(-1);
            returned = testedDateTime.MustBeYesterday();
            Assert.IsTrue(returned);

            testedDateTime = DateTime.Now.AddDays(-364);
            returned = testedDateTime.MustBeInLast365Days();
            Assert.IsTrue(returned);

            testedDateTime = DateTime.Now.AddDays(364);
            returned = testedDateTime.MustBeInNext365Days();
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2017, 2, 1, 0, 0, 0);
            returned = testedDateTime.MustBeDawn();
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2017, 2, 1, 6, 0, 0);
            returned = testedDateTime.MustBeMorning();
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2017, 2, 1, 12, 0, 0);
            returned = testedDateTime.MustBeAfternoon();
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2017, 2, 1, 18, 0, 0);
            returned = testedDateTime.MustBeEvening();
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2016, 2, 1, 18, 0, 0);
            returned = testedDateTime.MustBeLeapYear();
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2016, 2, 1, 18, 0, 0);
            returned = testedDateTime.MustBeMoreRecentThan(new DateTime(2016, 1, 1, 0, 0, 0));
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2016, 2, 1, 18, 0, 0);
            returned = testedDateTime.MustBeOlderThan(new DateTime(2016, 2, 1, 20, 0, 0));
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2017, 12, 4, 18, 0, 0);
            returned = testedDateTime.MustBeWeekday();
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2017, 12, 3, 18, 0, 0);
            returned = testedDateTime.MustBeWeekend();
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2007, 12, 3, 18, 0, 0);
            returned = testedDateTime.MustHasAtLeastYears(10);
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2008, 12, 3, 18, 0, 0);
            returned = testedDateTime.MustHasUpToYears(10);
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2017, 11, 23, 18, 0, 0);
            returned = testedDateTime.MustHasAtLeastDays(10);
            Assert.IsTrue(returned);

            testedDateTime = new DateTime(2017, 11, 28, 18, 0, 0);
            returned = testedDateTime.MustHasUpToDays(10);
            Assert.IsTrue(returned);
        }
    }
}
