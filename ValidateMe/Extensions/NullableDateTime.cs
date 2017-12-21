using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class NullableDateTime
    {
        /// <summary>
        /// Checks if has value and if its value is a past date.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBePast<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBePast(notify, propertyName);
        }

        /// <summary>
        /// Checks if has value and if its value is a future date.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeFuture<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeFuture(notify, propertyName);
        }

        /// <summary>
        /// Checks if has value and if its value is today.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeToday<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeToday(notify, propertyName);
        }

        /// <summary>
        /// Checks if the value is yesterday.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeYesterday<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeYesterday(notify, propertyName);
        }

        /// <summary>
        /// Checks if the value is tomorrow.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeTomorrow<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeTomorrow(notify, propertyName);
        }

        /// <summary>
        /// Checks if the value is in the last 365 days.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeInLast365Days<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeInLast365Days(notify, propertyName);
        }

        /// <summary>
        /// Checks if the value is in the next 365 days.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeInNext365Days<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeInNext365Days(notify, propertyName);
        }

        /// <summary>
        /// Checks if the hour part of datetime is dawn. (Dawn is between 0 AM and 6 AM)
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeDawn<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeDawn(notify, propertyName);
        }

        /// <summary>
        /// Checks if the hour part of datetime is morning. (Dawn is between 6 AM and 12 AM)
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeMorning<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeMorning(notify, propertyName);
        }

        /// <summary>
        /// Checks if the hour part of datetime is afternoon. (Dawn is between 12 AM and 6 PM)
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeAfternoon<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeAfternoon(notify, propertyName);
        }

        /// <summary>
        /// Checks if the hour part of datetime is evening. (Dawn is between 6 PM and 12 PM)
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeEvening<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeEvening(notify, propertyName);
        }

        /// <summary>
        /// Checks if the year part of datetime is Leap Year.
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeLeapYear<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeLeapYear(notify, propertyName);
        }

        /// <summary>
        /// Checks if the datetime is more recent than the value passed as parameter
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeMoreRecentThan<T>(this T? @this, DateTime X, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeMoreRecentThan(X, notify, propertyName);
        }

        /// <summary>
        /// Checks if the datetime is older than the value passed as parameter
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeOlderThan<T>(this T? @this, DateTime X, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeOlderThan(X, notify, propertyName);
        }

        /// <summary>
        /// Check if the day part of datetime is a weekday. (Weekday is Monday to Friday)
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeWeekday<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeWeekday(notify, propertyName);
        }

        /// <summary>
        /// Check if the day part of datetime is a day of weekend. (Weekend is Saturday and Sunday)
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeWeekend<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeWeekend(notify, propertyName);
        }

        /// <summary>
        /// Check if the year part of datetime has at least X years from present year
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="years">Value representing the max number of years</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustHasAtLeastYears<T>(this T? @this, int years, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustHasAtLeastYears(years, notify, propertyName);
        }

        /// <summary>
        /// Checks if the year part of datetime has up to X years to present year
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="years">Maximum number of years</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustHasUpToYears<T>(this T? @this, int years, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustHasUpToYears(years, notify, propertyName);
        }

        /// <summary>
        /// Check if the day part of datetime has at least X days from present day
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="years">Value representing the max number of days</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustHasAtLeastDays<T>(this T? @this, int days, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustHasAtLeastDays(days, notify, propertyName);
        }

        /// <summary>
        /// Checks if the day part of datetime has up to X days to present day
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="years">Maximum number of days</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustHasUpToDays<T>(this T? @this, int days, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsDateTime();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustHasUpToDays(days, notify, propertyName);
        }

        /// <summary>
        /// Check if value's type is DateTime
        /// </summary>
        /// <param name="this">value to be checked</param>
        /// <returns>True if is DateTime</returns>
        private static bool IsDateTime(this object @this)
            => @this is DateTime ? true : throw new Exception(string.Format(Resources.Resources.IncorrectType, "DateTime", @this.GetType().Name));

    }
}
