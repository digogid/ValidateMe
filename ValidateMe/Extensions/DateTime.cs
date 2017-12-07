using ValidateMe.Errors;
using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Datetime
    {
        public static bool MustBePast(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.Date > @this.Date;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInThePast, propertyName));

            return valid;
        }

        public static bool MustBeFuture(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.Date < @this.Date;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInTheFuture, propertyName));

            return valid;
        }

        public static bool MustBeToday(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Date == DateTime.Now.Date;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotToday, propertyName));

            return valid;
        }

        public static bool MustBeYesterday(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now.AddDays(-1) - @this).Days == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotYesterday, propertyName));

            return valid;
        }

        public static bool MustBeTomorrow(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now.AddDays(1) - @this).Days == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotTomorrow, propertyName));

            return valid;
        }

        public static bool MustBeInLast365Days(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now - @this).Days <= 365;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInLast365Days, propertyName));

            return valid;
        }

        public static bool MustBeInNext365Days(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (@this - DateTime.Now).Days <= 365;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInNext365Days, propertyName));

            return valid;
        }

        public static bool MustBeDawn(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Hour >= 0 && @this.Hour < 6;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotDawn, propertyName));

            return valid;
        }

        public static bool MustBeMorning(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Hour >= 6 && @this.Hour < 12;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotMorning, propertyName));

            return valid;
        }

        public static bool MustBeAfternoon(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Hour >= 12 && @this.Hour < 18;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotAfternoon, propertyName));

            return valid;
        }

        public static bool MustBeEvening(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Hour >= 18 && @this.Hour <= 23;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEvening, propertyName));

            return valid;
        }

        public static bool MustBeLeapYear(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.IsLeapYear(@this.Year);

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotLeapYear, propertyName));

            return valid;
        }

        public static bool MustBeMoreRecentThan(this DateTime @this, DateTime comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.CompareTo(comparer) > 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotMoreRecentThan, propertyName));

            return valid;
        }

        public static bool MustBeOlderThan(this DateTime @this, DateTime comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.CompareTo(comparer) < 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotOlderThan, propertyName));

            return valid;
        }

        public static bool MustBeWeekday(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.DayOfWeek != DayOfWeek.Sunday && @this.DayOfWeek != DayOfWeek.Saturday;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotWeekday, propertyName));

            return valid;
        }

        public static bool MustBeWeekend(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.DayOfWeek == DayOfWeek.Sunday || @this.DayOfWeek == DayOfWeek.Saturday;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotWeekend, propertyName));

            return valid;
        }

        public static bool MustHasAtLeastYears(this DateTime @this, int years, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.Year - @this.Date.Year >= years;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNotEnoughYears, propertyName, years.ToString()));

            return valid;
        }

        public static bool MustHasUpToYears(this DateTime @this, int years, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.Year - @this.Date.Year <= years;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasMoreThanNeededYears, propertyName, years.ToString()));

            return valid;
        }

        public static bool MustHasAtLeastDays(this DateTime @this, int days, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now - @this.Date).Days >= days;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNotEnoughYears, propertyName, days.ToString()));

            return valid;
        }

        public static bool MustHasUpToDays(this DateTime @this, int days, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now - @this.Date).Days <= days;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasMoreThanNeededYears, propertyName, days.ToString()));

            return valid;
        }
    }
}
