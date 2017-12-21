using ValidateMe.Errors;
using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Datetime
    {
        /// <summary>
        /// Checks if the value is in a past date.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBePast(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.Date > @this.Date;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInThePast, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the value is in a future date.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeFuture(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.Date < @this.Date;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInTheFuture, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the value is today.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeToday(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Date == DateTime.Now.Date;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotToday, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the value is yesterday.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeYesterday(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now.AddDays(-1) - @this).Days == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotYesterday, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the value is tomorrow.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeTomorrow(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now.AddDays(1) - @this).Days == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotTomorrow, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the value is in the last 365 days.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeInLast365Days(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now - @this).Days <= 365;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInLast365Days, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the value is in the next 365 days.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeInNext365Days(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (@this - DateTime.Now).Days <= 365;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInNext365Days, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the hour part of datetime is dawn. (Dawn is between 0 AM and 6 AM)
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeDawn(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Hour >= 0 && @this.Hour < 6;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotDawn, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the hour part of datetime is morning. (Morning is between 6AM and 12AM)
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeMorning(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Hour >= 6 && @this.Hour < 12;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotMorning, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the hour part of datetime is afternoon. (Afternoon is between 12AM (12H) and 6PM (18H))
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeAfternoon(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Hour >= 12 && @this.Hour < 18;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotAfternoon, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the hour part of datetime is evening. (Evening is between 6PM (18H) and 12PM)
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeEvening(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Hour >= 18 && @this.Hour <= 23;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEvening, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the year part of datetime is Leap Year.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeLeapYear(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.IsLeapYear(@this.Year);

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotLeapYear, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the datetime is more recent than the 'X parameter'
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeMoreRecentThan(this DateTime @this, DateTime X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.CompareTo(X) > 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotMoreRecentThan, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if the datetime is older than the 'X parameter'
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeOlderThan(this DateTime @this, DateTime X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.CompareTo(X) < 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotOlderThan, propertyName));

            return valid;
        }

        /// <summary>
        /// Check if the day part of datetime is a weekday. (Weekday is Monday to Friday)
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeWeekday(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.DayOfWeek != DayOfWeek.Sunday && @this.DayOfWeek != DayOfWeek.Saturday;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotWeekday, propertyName));

            return valid;
        }

        /// <summary>
        /// Check if the day part of datetime is a day of weekend. (Weekend is Saturday and Sunday)
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeWeekend(this DateTime @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.DayOfWeek == DayOfWeek.Sunday || @this.DayOfWeek == DayOfWeek.Saturday;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotWeekend, propertyName));

            return valid;
        }

        /// <summary>
        /// Check if the year part of datetime has at least X years from present year
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value representing the minimum number of years</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustHasAtLeastYears(this DateTime @this, int X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.Year - @this.Date.Year >= X;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNotEnoughYears, propertyName, X.ToString()));

            return valid;
        }

        /// <summary>
        /// Checks if the year part of datetime has up to X years to present year
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Maximum number of years</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustHasUpToYears(this DateTime @this, int X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.Year - @this.Date.Year <= X;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasMoreThanNeededYears, propertyName, X.ToString()));

            return valid;
        }

        /// <summary>
        /// Check if the day part of datetime has at least X days from present day
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value representing the minimum number of days</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustHasAtLeastDays(this DateTime @this, int X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now - @this.Date).Days >= X;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNotEnoughYears, propertyName, X.ToString()));

            return valid;
        }

        /// <summary>
        /// Checks if the day part of datetime has up to X days to present day
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value representing the maximum number of days</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustHasUpToDays(this DateTime @this, int X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now - @this.Date).Days <= X;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasMoreThanNeededYears, propertyName, X.ToString()));

            return valid;
        }
    }
}
