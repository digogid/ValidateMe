using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValidateMe.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateIntValue()
        {
            var obj = new TestObject();

            obj.intValue = 102;
            Assert.IsTrue(Notification.Count == 4); // not odd, not negative, not zero, not equals to 200
            Notification.Clear();

            obj.intValue = 200;
            Assert.IsTrue(Notification.Count == 3); // not odd, not negative, not zero, not equals to 200
            Notification.Clear();

            obj.intValue = 99;
            Assert.IsTrue(Notification.Count == 5); // not even, not greater than 100, not negative, not zero, not equals to 200
            Notification.Clear();

            obj.intValue = 1002;
            Assert.IsTrue(Notification.Count == 5); // not smaller than 1000, not negative, not zero, not equals to 200, not odd
            Notification.Clear();

            obj.intValue = 999;
            Assert.IsTrue(Notification.Count == 4); // not negative, not zero, not equals to 200, not even
            Notification.Clear();

            obj.intValue = 1003;
            Assert.IsTrue(Notification.Count == 5); // not even, not smaller than 1000, not negative, not zero, not equals to 200
            Notification.Clear();

            obj.intValue = -1;
            Assert.IsTrue(Notification.Count == 5); // not even, not positive, not greater than 100, not zero, not equals to 200
            Notification.Clear();

            obj.intValue = 0;
            Assert.IsTrue(Notification.Count == 5); // not odd, not positive, not negative, not greater than 100, not equals to 200
            Notification.Clear();
        }

        [TestMethod]
        public void ValidateStringValue()
        {
            var obj = new TestObject();

            obj.StringValue = "Hello";
            Assert.IsTrue(Notification.Count == 6);
            // does not have at least two words, is not alphanumeric, is not an email, is not a guid, has no special characters, is not numeric
            Notification.Clear();

            obj.StringValue = "Hello World";
            Assert.IsTrue(Notification.Count == 7);
            // is not alphanumeric, is not an email, is not a guid, not smaller than 10 chars, has no special characters, is not numeric, has not exact length
            Notification.Clear();

            obj.StringValue = "Hello <World> babe";
            Assert.IsTrue(Notification.Count == 9);
            // does not have only letters, is not safe, is not alphanumeric, is misformatted, not smaller than 10 chars, is not an email, is not a guid, is not numeric, has not exact length
            Notification.Clear();

            obj.StringValue = "H3llo World";
            Assert.IsTrue(Notification.Count == 8);
            // does not have only letters, is not an email, is not a guid, is not numeric, not smaller than 10 chars, has not exact length, misformatted
            Notification.Clear();

            obj.StringValue = "Hello@World.com";
            Assert.IsTrue(Notification.Count == 8);
            // is not alphabetic only, is not alphanumeric, is not numeric only, misformatted, is not guid, has not exact length, is not smaller than 10, has not two words at least
            Notification.Clear();
        }

        [TestMethod]
        public void ValidateDateTimeValue()
        {
            var obj = new TestObject();

            obj.DateTimeValue = new DateTime(2021, 2, 2, 2, 0, 0, 0);
            Assert.IsTrue(Notification.Count == 14);
            /*
            value.MustBeAfternoon(); NOK
            value.MustBeDawn(); OK
            value.MustBeEvening(); NOK
            value.MustBeMorning(); NOK
            value.MustBeFuture(); OK
            value.MustBePast(); NOK
            value.MustBeInLast365Days(); NOK
            value.MustBeInNext365Days(); NOK
            value.MustBeLeapYear(); NOK
            value.MustBeMoreRecentThan(DateTime.Now); OK
            value.MustBeOlderThan(DateTime.Now); NOK
            value.MustBeToday(); NOK
            value.MustBeTomorrow(); NOK
            value.MustBeWeekday(); OK
            value.MustBeWeekend(); NOK
            value.MustBeYesterday(); NOK
            value.MustHasAtLeastDays(10); OK
            value.MustHasUpToDays(10); NOK
            value.MustHasAtLeastYears(2); OK
            value.MustHasUpToYears(2); NOK
             */
            Notification.Clear();


            obj.DateTimeValue = new DateTime(2018, 2, 20, 7, 0, 0, 0);
            Assert.IsTrue(Notification.Count == 12);
            /*
            value.MustBeAfternoon(); NOK
            value.MustBeDawn(); NOK
            value.MustBeEvening(); NOK
            value.MustBeMorning(); OK
            value.MustBeFuture(); NOK
            value.MustBePast(); OK
            value.MustBeInLast365Days(); OK
            value.MustBeInNext365Days(); NOK
            value.MustBeLeapYear(); NOK
            value.MustBeMoreRecentThan(DateTime.Now); NOK
            value.MustBeOlderThan(DateTime.Now); OK
            value.MustBeToday(); NOK
            value.MustBeTomorrow(); NOK
            value.MustBeWeekday(); OK
            value.MustBeWeekend(); NOK
            value.MustBeYesterday(); OK
            value.MustHasAtLeastDays(10); NOK
            value.MustHasUpToDays(10); OK
            value.MustHasAtLeastYears(2); NOK
            value.MustHasUpToYears(2); OK
             */
            Notification.Clear();


            obj.DateTimeValue = DateTime.Now;
            Assert.IsTrue(Notification.Count == 14);
            /*
            value.MustBeAfternoon(); N/OK
            value.MustBeDawn(); N/OK
            value.MustBeEvening(); N/OK
            value.MustBeMorning(); N/OK
            value.MustBeFuture(); NOK
            value.MustBePast(); NOK
            value.MustBeInLast365Days(); NOK
            value.MustBeInNext365Days(); NOK
            value.MustBeLeapYear(); N/OK
            value.MustBeMoreRecentThan(DateTime.Now); NOK
            value.MustBeOlderThan(DateTime.Now); OK
            value.MustBeToday(); OK
            value.MustBeTomorrow(); NOK
            value.MustBeWeekday(); N/OK
            value.MustBeWeekend(); N/OK
            value.MustBeYesterday(); NOK
            value.MustHasAtLeastDays(10); NOK
            value.MustHasUpToDays(10); OK
            value.MustHasAtLeastYears(2); NOK
            value.MustHasUpToYears(2); OK
             */
            Notification.Clear();


            obj.DateTimeValue = new DateTime(2030, 1, 1, 18, 0, 0);
            Assert.IsTrue(Notification.Count == 14);
            /*
            value.MustBeAfternoon(); NOK
            value.MustBeDawn(); NOK
            value.MustBeEvening(); OK
            value.MustBeMorning(); NOK
            value.MustBeFuture(); OK
            value.MustBePast(); NOK
            value.MustBeInLast365Days(); NOK
            value.MustBeInNext365Days(); NOK
            value.MustBeLeapYear(); NOK
            value.MustBeMoreRecentThan(DateTime.Now); OK
            value.MustBeOlderThan(DateTime.Now); NOK
            value.MustBeToday(); NOK
            value.MustBeTomorrow(); NOK
            value.MustBeWeekday(); N/OK
            value.MustBeWeekend(); N/OK
            value.MustBeYesterday(); NOK
            value.MustHasAtLeastDays(10); OK
            value.MustHasUpToDays(10); NOK
            value.MustHasAtLeastYears(2); OK
            value.MustHasUpToYears(2); NOK
             */
            Notification.Clear();
        }
    }

    public class TestObject
    {
        private int _intValue;
        public int intValue
        {
            get { return _intValue; }
            set
            {
                Validator.SetValidations((_) =>
                {
                    value.MustBePositive();
                    value.MustBeNegative();
                    value.MustBeZero();
                    value.MustBeEven();
                    value.MustBeOdd();
                    value.MustBeEqualTo(200);
                    value.MustBeGreaterThan(100);
                    value.MustBeSmallerThan(1000);
                });
                if (this.CheckValidations())
                    _intValue = value;
            }
        }

        private string _stringValue;
        public string StringValue
        {
            get { return _stringValue; }
            set
            {
                Validator.SetValidations((_) =>
                {
                    value.MayBeAlphanumeric();
                    value.MustBeAlphanumeric();
                    value.MustBeAlphabetic();
                    value.MustBeEmail();
                    value.MustBeExactLength(5);
                    value.MustBeFormatted(@"^\p{L}+(?: \p{L}+)*$");
                    value.MustBeGreaterThan(4);
                    value.MustBeGuid();
                    value.MustBeNumeric();
                    value.MustBeSmallerThan(10);
                    value.MustContainsAtLeastWords(2);
                    value.MustContainSpecialCharacters();
                    value.MustHasValue();
                    value.MustBeSafe();
                });

                if (this.CheckValidations())
                    _stringValue = value;
            }
        }

        private DateTime _dateTimeValue;
        public DateTime DateTimeValue
        {
            get
            {
                return _dateTimeValue;
            }
            set
            {
                Validator.SetValidations((_) =>
                {
                    value.MustBeAfternoon();
                    value.MustBeDawn();
                    value.MustBeEvening();
                    value.MustBeMorning();
                    value.MustBeFuture();
                    value.MustBePast();
                    value.MustBeInLast365Days();
                    value.MustBeInNext365Days();
                    value.MustBeLeapYear();
                    value.MustBeMoreRecentThan(DateTime.Now);
                    value.MustBeOlderThan(DateTime.Now);
                    value.MustBeToday();
                    value.MustBeTomorrow();
                    value.MustBeWeekday();
                    value.MustBeWeekend();
                    value.MustBeYesterday();
                    value.MustHasAtLeastDays(10);
                    value.MustHasUpToDays(10);
                    value.MustHasAtLeastYears(2);
                    value.MustHasUpToYears(2);
                });

                if (this.CheckValidations())
                    _dateTimeValue = value;
            }
        }
    }
}
