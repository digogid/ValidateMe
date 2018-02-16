using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class NullableDateTime
    {
        /// <summary>
        /// Check if it is a DateTime object and has value
        /// </summary>
        internal static bool IsValidDateTime<T>(this T? @this) where T : struct
        {
            return @this.IsDateTime() && @this.ContainsValue();
        }

        /// <summary>
        /// Checks if has value and if its value is a past date.
        /// </summary>
        public static bool IsPast<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsPast();
            }
            return false;
        }

        public static void MustBePast<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBePast(propertyName);
            }
        }

        /// <summary>
        /// Checks if has value and if its value is a future date.
        /// </summary>
        public static bool IsFuture<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsFuture();
            }
            return false;
        }

        public static void MustBeFuture<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeFuture(propertyName);
            }
        }

        /// <summary>
        /// Checks if has value and if its value is today.
        /// </summary>
        public static bool IsToday<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsToday();
            }
            return false;
        }
        public static void MustBeToday<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeToday(propertyName);
            }
        }

        /// <summary>
        /// Checks if the value is yesterday.
        /// </summary>
        public static bool IsYesterday<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsYesterday();
            }
            return false;
        }

        public static void MustBeYesterday<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeYesterday(propertyName);
            }
        }

        /// <summary>
        /// Checks if the value is tomorrow.
        /// </summary>
        public static bool IsTomorrow<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsTomorrow();
            }
            return false;
        }

        public static void MustBeTomorrow<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeTomorrow(propertyName);
            }
        }

        /// <summary>
        /// Checks if the value is in the last 365 days.
        /// </summary>
        public static bool IsInLast365Days<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsInLast365Days();
            }
            return false;
        }

        public static void MustBeInLast365Days<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeInLast365Days(propertyName);
            }
        }

        /// <summary>
        /// Checks if the value is in the next 365 days.
        /// </summary>
        public static bool IsInNext365Days<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsInNext365Days();
            }
            return false;
        }

        public static void MustBeInNext365Days<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeInNext365Days(propertyName);
            }
        }

        /// <summary>
        /// Checks if the hour part of datetime is dawn. (Dawn is between 0 AM and 6 AM)
        /// </summary>
        public static bool IsDawn<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsDawn();
            }
            return false;
        }

        public static void MustBeDawn<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeDawn(propertyName);
            }
        }

        /// <summary>
        /// Checks if the hour part of datetime is morning. (Dawn is between 6 AM and 12 AM)
        /// </summary>
        public static bool IsMorning<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsMorning();
            }
            return false;
        }

        public static void MustBeMorning<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeMorning(propertyName);
            }
        }

        /// <summary>
        /// Checks if the hour part of datetime is afternoon. (Dawn is between 12 AM and 6 PM)
        /// </summary>
        public static bool IsAfternoon<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsAfternoon();
            }
            return false;
        }

        public static void MustBeAfternoon<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeAfternoon(propertyName);
            }
        }

        /// <summary>
        /// Checks if the hour part of datetime is evening. (Dawn is between 6 PM and 12 PM)
        /// </summary>
        public static bool IsEvening<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsEvening();
            }
            return false;
        }

        public static void MustBeEvening<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeEvening(propertyName);
            }
        }

        /// <summary>
        /// Checks if the year part of datetime is Leap Year.
        /// </summary>
        public static bool IsLeapYear<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsLeapYear();
            }
            return false;
        }

        public static void MustBeLeapYear<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeLeapYear(propertyName);
            }
        }

        /// <summary>
        /// Checks if the datetime is more recent than X
        /// </summary>
        public static bool IsMoreRecentThan<T>(this T? @this, DateTime X) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsMoreRecentThan(X);
            }
            return false;
        }

        public static void MustBeMoreRecentThan<T>(this T? @this, DateTime X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeMoreRecentThan(X, propertyName);
            }
        }

        /// <summary>
        /// Checks if the datetime is older than X
        /// </summary>
        public static bool IsOlderThan<T>(this T? @this, DateTime X) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsOlderThan(X);
            }
            return false;
        }

        public static void MustBeOlderThan<T>(this T? @this, DateTime X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeOlderThan(X, propertyName);
            }
        }

        /// <summary>
        /// Check if the day part of datetime is a weekday. (Weekday is Monday to Friday)
        /// </summary>
        public static bool IsWeekday<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsWeekday();
            }
            return false;
        }

        public static void MustBeWeekday<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeWeekday(propertyName);
            }
        }

        /// <summary>
        /// Check if the day part of datetime is a day of weekend. (Weekend is Saturday and Sunday)
        /// </summary>
        public static bool IsWeekend<T>(this T? @this) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsWeekend();
            }
            return false;
        }

        public static void MustBeWeekend<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustBeWeekend(propertyName);
            }
        }

        /// <summary>
        /// Check if the year part of datetime has at least X years from present year
        /// </summary>
        public static bool IsAtLeastYears<T>(this T? @this, int years) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsAtLeastYears(years);
            }
            return false;
        }

        public static void MustHasAtLeastYears<T>(this T? @this, int years, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustHasAtLeastYears(years, propertyName);
            }
        }

        /// <summary>
        /// Checks if the year part of datetime has up to X years to present year
        /// </summary>
        public static bool IsUpToYears<T>(this T? @this, int years) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsUpToYears(years);
            }
            return false;
        }

        public static void MustHasUpToYears<T>(this T? @this, int years, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustHasUpToYears(years, propertyName);
            }
        }

        /// <summary>
        /// Check if the day part of datetime has at least X days from present day
        /// </summary>
        public static bool IsAtLeastDays<T>(this T? @this, int days) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsAtLeastDays(days);
            }
            return false;
        }

        public static void MustHasAtLeastDays<T>(this T? @this, int days, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustHasAtLeastDays(days, propertyName);
            }
        }

        /// <summary>
        /// Checks if the day part of datetime has up to X days to present day
        /// </summary>
        public static bool IsUpToDays<T>(this T? @this, int days) where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                return actualValue.IsUpToDays(days);
            }
            return false;
        }

        public static void MustHasUpToDays<T>(this T? @this, int days, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidDateTime())
            {
                DateTime actualValue = Convert.ToDateTime(@this.Value);
                actualValue.MustHasUpToDays(days, propertyName);
            }
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
