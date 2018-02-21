using ValidateMe.Errors;
using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Datetime
    {
        /// <summary>
        /// Check if value is a past Date
        /// </summary>
        public static bool IsPast(this DateTime @this)
        {
            return DateTime.Now.Date > @this.Date;
        }

        /// <summary>
        /// Ensure that value is a past Date
        /// </summary>
        public static DateTime MustBePast(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsPast())
                Notification.Add(Error.Create(ErrorData.IsNotInThePast, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value is a future Date
        /// </summary>
        public static bool IsFuture(this DateTime @this)
        {
            return DateTime.Now.Date < @this.Date;
        }

        /// <summary>
        /// Ensure that value is a future Date
        /// </summary>
        public static DateTime MustBeFuture(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsFuture())
                Notification.Add(Error.Create(ErrorData.IsNotInTheFuture, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value's Date is today
        /// </summary>
        public static bool IsToday(this DateTime @this)
        {
            return @this.Date == DateTime.Now.Date;
        }

        /// <summary>
        /// Ensure that value's Date is today
        /// </summary>
        public static DateTime MustBeToday(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsToday())
                Notification.Add(Error.Create(ErrorData.IsNotToday, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value's Date is yesterday
        /// </summary>
        public static bool IsYesterday(this DateTime @this)
        {
            return (DateTime.Now.Date.AddDays(-1) - @this.Date).Days == 0;
        }

        /// <summary>
        /// Ensure that value's Date is yesterday
        /// </summary>
        public static DateTime MustBeYesterday(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsYesterday())
                Notification.Add(Error.Create(ErrorData.IsNotYesterday, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value's Date is tomorrow
        /// </summary>
        public static bool IsTomorrow(this DateTime @this)
        {
            return (DateTime.Now.Date.AddDays(1) - @this.Date).Days == 0;
        }

        /// <summary>
        /// Ensure that value's Date is tomorrow
        /// </summary>
        public static DateTime MustBeTomorrow(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsTomorrow())
                Notification.Add(Error.Create(ErrorData.IsNotTomorrow, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value is in the last 365 days
        /// </summary>
        public static bool IsInLast365Days(this DateTime @this)
        {
            return (DateTime.Now.Date - @this.Date).Days <= 365 && (DateTime.Now.Date - @this.Date).Days > 0;
        }

        /// <summary>
        /// Ensure that value is in the last 365 days
        /// </summary>
        public static DateTime MustBeInLast365Days(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsInLast365Days())
                Notification.Add(Error.Create(ErrorData.IsNotInLast365Days, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value is in the next 365 days
        /// </summary>
        public static bool IsInNext365Days(this DateTime @this)
        {
            return (@this.Date - DateTime.Now.Date).Days <= 365 && (@this.Date - DateTime.Now.Date).Days > 0;
        }

        /// <summary>
        /// Ensure that value is in the next 365 days
        /// </summary>
        public static DateTime MustBeInNext365Days(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsInNext365Days())
                Notification.Add(Error.Create(ErrorData.IsNotInNext365Days, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value's Hour is dawn (midnight to 6am)
        /// </summary>
        public static bool IsDawn(this DateTime @this)
        {
            return @this.Hour >= 0 && @this.Hour < 6;
        }

        /// <summary>
        /// Ensure that value's Hour is dawn (midnight to 6am)
        /// </summary>
        public static DateTime MustBeDawn(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsDawn())
                Notification.Add(Error.Create(ErrorData.IsNotDawn, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value's Hour is morning (6am to midday)
        /// </summary>
        public static bool IsMorning(this DateTime @this)
        {
            return @this.Hour >= 6 && @this.Hour < 12;
        }

        /// <summary>
        /// Ensure that value's Hour is morning (6am to midday)
        /// </summary>
        public static DateTime MustBeMorning(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsMorning())
                Notification.Add(Error.Create(ErrorData.IsNotMorning, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value's Hour is afternoon (midday to 6pm)
        /// </summary>
        public static bool IsAfternoon(this DateTime @this)
        {
            return @this.Hour >= 12 && @this.Hour < 18;
        }

        /// <summary>
        /// Ensure that value's Hour is morning (midday to 6pm)
        /// </summary>
        public static DateTime MustBeAfternoon(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsAfternoon())
                Notification.Add(Error.Create(ErrorData.IsNotAfternoon, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value's Hour is evening (6pm to midnight)
        /// </summary>
        public static bool IsEvening(this DateTime @this)
        {
            return @this.Hour >= 18 && @this.Hour <= 23;
        }

        /// <summary>
        /// Ensure that value's Hour is evening (6pm to midnight)
        /// </summary>
        public static DateTime MustBeEvening(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsEvening())
                Notification.Add(Error.Create(ErrorData.IsNotEvening, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value's Year is a leap year
        /// </summary>
        public static bool IsLeapYear(this DateTime @this)
        {
            return DateTime.IsLeapYear(@this.Year);
        }

        /// <summary>
        /// Ensure that value's Year is a leap year
        /// </summary>
        public static DateTime MustBeLeapYear(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsLeapYear())
                Notification.Add(Error.Create(ErrorData.IsNotLeapYear, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value is more recent than X
        /// </summary>
        public static bool IsMoreRecentThan(this DateTime @this, DateTime X)
        {
            return @this.CompareTo(X) > 0;
        }

        /// <summary>
        /// Ensure that value is more recent than X
        /// </summary>
        public static DateTime MustBeMoreRecentThan(this DateTime @this, DateTime X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsMoreRecentThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotMoreRecentThan, propertyName, X.ToLongDateString()));
            return @this;
        }

        /// <summary>
        /// Check if value is older than X
        /// </summary>
        public static bool IsOlderThan(this DateTime @this, DateTime X)
        {
            return @this.CompareTo(X) < 0;
        }

        /// <summary>
        /// Ensure that value is older than X
        /// </summary>
        public static DateTime MustBeOlderThan(this DateTime @this, DateTime X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsOlderThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotOlderThan, propertyName, X.ToLongDateString()));
            return @this;
        }

        /// <summary>
        /// Check if value's Day is a weekday (monday to friday)
        /// </summary>
        public static bool IsWeekday(this DateTime @this)
        {
            return @this.DayOfWeek != DayOfWeek.Sunday && @this.DayOfWeek != DayOfWeek.Saturday;
        }

        /// <summary>
        /// Ensure that value's Day is a weekday (monday to friday)
        /// </summary>
        public static DateTime MustBeWeekday(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsWeekday())
                Notification.Add(Error.Create(ErrorData.IsNotWeekday, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if value's Day is a weekend day (saturday od sunday)
        /// </summary>
        public static bool IsWeekend(this DateTime @this)
        {
            return @this.DayOfWeek == DayOfWeek.Sunday || @this.DayOfWeek == DayOfWeek.Saturday;
        }

        /// <summary>
        /// Ensure that value's Day is a weekend day (saturday od sunday)
        /// </summary>
        public static DateTime MustBeWeekend(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsWeekend())
                Notification.Add(Error.Create(ErrorData.IsNotWeekend, propertyName));
            return @this;
        }

        /// <summary>
        /// Check if the difference between value's year and today's year is greater than X
        /// </summary>
        public static bool IsAtLeastYears(this DateTime @this, int X)
        {
            if (@this.IsMoreRecentThan(DateTime.Now))
                return @this.Year - DateTime.Now.Year >= X;

            return DateTime.Now.Year - @this.Year >= X;
        }

        /// <summary>
        /// Ensure that the difference between value's year and today's year is greater than X
        /// </summary>
        public static DateTime MustHasAtLeastYears(this DateTime @this, int X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsAtLeastYears(X))
                Notification.Add(Error.Create(ErrorData.HasNotEnoughYears, propertyName, X.ToString()));
            return @this;
        }

        /// <summary>
        /// Check if the difference between value's year and today's year is smaller than X
        /// </summary>
        public static bool IsUpToYears(this DateTime @this, int X)
        {
            if (@this.IsMoreRecentThan(DateTime.Now))
                return @this.Year - DateTime.Now.Year <= X;

            return DateTime.Now.Year - @this.Year <= X;
        }

        /// <summary>
        /// Ensure that the difference between value's year and today's year is smaller than X
        /// </summary>
        public static DateTime MustHasUpToYears(this DateTime @this, int X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsUpToYears(X))
                Notification.Add(Error.Create(ErrorData.HasMoreThanNeededYears, propertyName, X.ToString()));
            return @this;
        }

        /// <summary>
        /// Check if the difference between value's day and today is greater than X
        /// </summary>
        public static bool IsAtLeastDays(this DateTime @this, int X)
        {
            if (@this.IsMoreRecentThan(DateTime.Now))
                return (@this.Date - DateTime.Now.Date).Days >= X;

            return (DateTime.Now.Date - @this.Date).Days >= X;
        }

        /// <summary>
        /// Ensure that the difference between value's day and today is greater than X
        /// </summary>
        public static DateTime MustHasAtLeastDays(this DateTime @this, int X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsAtLeastDays(X))
                Notification.Add(Error.Create(ErrorData.HasNotEnoughDays, propertyName, X.ToString()));
            return @this;
        }

        /// <summary>
        /// Check if the difference between value's day and today is smaller than X
        /// </summary>
        public static bool IsUpToDays(this DateTime @this, int X)
        {
            if (@this.IsMoreRecentThan(DateTime.Now))
                return (@this.Date - DateTime.Now.Date).Days <= X;

            return (DateTime.Now.Date - @this.Date).Days <= X;
        }

        /// <summary>
        /// Ensure that the difference between value's day and today is smaller than X
        /// </summary>
        public static DateTime MustHasUpToDays(this DateTime @this, int X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsUpToDays(X))
                Notification.Add(Error.Create(ErrorData.HasMoreThanNeededDays, propertyName, X.ToString()));
            return @this;
        }
    }
}
