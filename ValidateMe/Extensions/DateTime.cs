using ValidateMe.Errors;
using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Datetime
    {
        public static bool IsPast(this DateTime @this)
        {
            return DateTime.Now.Date > @this.Date;
        }

        public static void MustBePast(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsPast())
                Notification.Add(Error.Create(ErrorData.IsNotInThePast, propertyName));
        }

        public static bool IsFuture(this DateTime @this)
        {
            return DateTime.Now.Date < @this.Date;
        }

        public static void MustBeFuture(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsFuture())
                Notification.Add(Error.Create(ErrorData.IsNotInTheFuture, propertyName));
        }

        public static bool IsToday(this DateTime @this)
        {
            return @this.Date == DateTime.Now.Date;
        }

        public static void MustBeToday(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsToday())
                Notification.Add(Error.Create(ErrorData.IsNotToday, propertyName));
        }

        public static bool IsYesterday(this DateTime @this)
        {
            return (DateTime.Now.AddDays(-1) - @this).Days == 0;
        }

        public static void MustBeYesterday(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsYesterday())
                Notification.Add(Error.Create(ErrorData.IsNotYesterday, propertyName));
        }

        public static bool IsTomorrow(this DateTime @this)
        {
            return (DateTime.Now.AddDays(1) - @this).Days == 0;
        }

        public static void MustBeTomorrow(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsTomorrow())
                Notification.Add(Error.Create(ErrorData.IsNotTomorrow, propertyName));
        }

        public static bool IsInLast365Days(this DateTime @this)
        {
            return (DateTime.Now - @this).Days <= 365;
        }

        public static void MustBeInLast365Days(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsInLast365Days())
                Notification.Add(Error.Create(ErrorData.IsNotInLast365Days, propertyName));
        }

        public static bool IsInNext365Days(this DateTime @this)
        {
            return (@this - DateTime.Now).Days <= 365;
        }

        public static void MustBeInNext365Days(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsInNext365Days())
                Notification.Add(Error.Create(ErrorData.IsNotInNext365Days, propertyName));
        }

        public static bool IsDawn(this DateTime @this)
        {
            return @this.Hour >= 0 && @this.Hour < 6;
        }

        public static void MustBeDawn(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsDawn())
                Notification.Add(Error.Create(ErrorData.IsNotDawn, propertyName));
        }

        public static bool IsMorning(this DateTime @this)
        {
            return @this.Hour >= 6 && @this.Hour < 12;
        }

        public static void MustBeMorning(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsMorning())
                Notification.Add(Error.Create(ErrorData.IsNotMorning, propertyName));
        }

        public static bool IsAfternoon(this DateTime @this)
        {
            return @this.Hour >= 12 && @this.Hour < 18;
        }

        public static void MustBeAfternoon(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsAfternoon())
                Notification.Add(Error.Create(ErrorData.IsNotAfternoon, propertyName));
        }

        public static bool IsEvening(this DateTime @this)
        {
            return @this.Hour >= 18 && @this.Hour <= 23;
        }

        public static void MustBeEvening(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsEvening())
                Notification.Add(Error.Create(ErrorData.IsNotEvening, propertyName));
        }

        public static bool IsLeapYear(this DateTime @this)
        {
            return DateTime.IsLeapYear(@this.Year);
        }

        public static void MustBeLeapYear(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsLeapYear())
                Notification.Add(Error.Create(ErrorData.IsNotLeapYear, propertyName));
        }

        public static bool IsMoreRecentThan(this DateTime @this, DateTime X)
        {
            return @this.CompareTo(X) > 0;
        }

        public static void MustBeMoreRecentThan(this DateTime @this, DateTime X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsMoreRecentThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotMoreRecentThan, propertyName));
        }

        public static bool IsOlderThan(this DateTime @this, DateTime X)
        {
            return @this.CompareTo(X) < 0;
        }

        public static void MustBeOlderThan(this DateTime @this, DateTime X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsOlderThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotOlderThan, propertyName));
        }

        public static bool IsWeekday(this DateTime @this)
        {
            return @this.DayOfWeek != DayOfWeek.Sunday && @this.DayOfWeek != DayOfWeek.Saturday;
        }

        public static void MustBeWeekday(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsWeekday())
                Notification.Add(Error.Create(ErrorData.IsNotWeekday, propertyName));
        }

        public static bool IsWeekend(this DateTime @this)
        {
            return @this.DayOfWeek == DayOfWeek.Sunday || @this.DayOfWeek == DayOfWeek.Saturday;
        }

        public static void MustBeWeekend(this DateTime @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsWeekend())
                Notification.Add(Error.Create(ErrorData.IsNotWeekend, propertyName));
        }

        public static bool IsAtLeastYears(this DateTime @this, int X)
        {
            return DateTime.Now.Year - @this.Date.Year >= X;
        }

        public static void MustHasAtLeastYears(this DateTime @this, int X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsAtLeastYears(X))
                Notification.Add(Error.Create(ErrorData.HasNotEnoughYears, propertyName, X.ToString()));
        }

        public static bool IsUpToYears(this DateTime @this, int X)
        {
            return DateTime.Now.Year - @this.Date.Year <= X;
        }

        public static void MustHasUpToYears(this DateTime @this, int X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsUpToYears(X))
                Notification.Add(Error.Create(ErrorData.HasMoreThanNeededYears, propertyName, X.ToString()));
        }

        public static bool IsAtLeastDays(this DateTime @this, int X)
        {
            return (DateTime.Now - @this.Date).Days >= X;
        }

        public static void MustHasAtLeastDays(this DateTime @this, int X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsAtLeastDays(X))
                Notification.Add(Error.Create(ErrorData.HasNotEnoughDays, propertyName, X.ToString()));
        }

        public static bool IsUpToDays(this DateTime @this, int X)
        {
            return (DateTime.Now - @this.Date).Days <= X;
        }

        public static void MustHasUpToDays(this DateTime @this, int X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsUpToDays(X))
                Notification.Add(Error.Create(ErrorData.HasMoreThanNeededDays, propertyName, X.ToString()));
        }
    }
}
