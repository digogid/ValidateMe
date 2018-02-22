using System;
using System.Runtime.CompilerServices;
using ValidateMe.Errors;

namespace ValidateMe
{
    public static class NullableDateTime
    {

        /// <summary>
        /// Checks if has value and if its value is a past date.
        /// </summary>
        public static bool IsPast<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsPast();
                }
            }
            return false;
        }

        public static T? MustBePast<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBePast(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if has value and if its value is a future date.
        /// </summary>
        public static bool IsFuture<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsFuture();
                }
            }
            return false;
        }

        public static T? MustBeFuture<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeFuture(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if has value and if its value is today.
        /// </summary>
        public static bool IsToday<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsToday();
                }
            }
            return false;
        }
        public static T? MustBeToday<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeToday(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the value is yesterday.
        /// </summary>
        public static bool IsYesterday<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsYesterday();
                }
            }
            return false;
        }

        public static T? MustBeYesterday<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeYesterday(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the value is tomorrow.
        /// </summary>
        public static bool IsTomorrow<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsTomorrow();
                }
            }
            return false;
        }

        public static T? MustBeTomorrow<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeTomorrow(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the value is in the last 365 days.
        /// </summary>
        public static bool IsInLast365Days<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsInLast365Days();
                }
            }
            return false;
        }

        public static T? MustBeInLast365Days<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeInLast365Days(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the value is in the next 365 days.
        /// </summary>
        public static bool IsInNext365Days<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsInNext365Days();
                }
            }
            return false;
        }

        public static T? MustBeInNext365Days<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeInNext365Days(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the hour part of datetime is dawn. (Dawn is between 0 AM and 6 AM)
        /// </summary>
        public static bool IsDawn<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsDawn();
                }
            }
            return false;
        }

        public static T? MustBeDawn<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeDawn(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the hour part of datetime is morning. (Dawn is between 6 AM and 12 AM)
        /// </summary>
        public static bool IsMorning<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsMorning();
                }
            }
            return false;
        }

        public static T? MustBeMorning<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeMorning(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the hour part of datetime is afternoon. (Dawn is between 12 AM and 6 PM)
        /// </summary>
        public static bool IsAfternoon<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsAfternoon();
                }
            }
            return false;
        }

        public static T? MustBeAfternoon<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeAfternoon(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the hour part of datetime is evening. (Dawn is between 6 PM and 12 PM)
        /// </summary>
        public static bool IsEvening<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsEvening();
                }
            }
            return false;
        }

        public static T? MustBeEvening<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeEvening(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the year part of datetime is Leap Year.
        /// </summary>
        public static bool IsLeapYear<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsLeapYear();
                }
            }
            return false;
        }

        public static T? MustBeLeapYear<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeLeapYear(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the datetime is more recent than X
        /// </summary>
        public static bool IsMoreRecentThan<T>(this T? @this, DateTime X) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsMoreRecentThan(X);
                }
            }
            return false;
        }

        public static T? MustBeMoreRecentThan<T>(this T? @this, DateTime X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeMoreRecentThan(X, propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the datetime is older than X
        /// </summary>
        public static bool IsOlderThan<T>(this T? @this, DateTime X) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsOlderThan(X);
                }
            }
            return false;
        }

        public static T? MustBeOlderThan<T>(this T? @this, DateTime X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeOlderThan(X, propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Check if the day part of datetime is a weekday. (Weekday is Monday to Friday)
        /// </summary>
        public static bool IsWeekday<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsWeekday();
                }
            }
            return false;
        }

        public static T? MustBeWeekday<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeWeekday(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Check if the day part of datetime is a day of weekend. (Weekend is Saturday and Sunday)
        /// </summary>
        public static bool IsWeekend<T>(this T? @this) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsWeekend();
                }
            }
            return false;
        }

        public static T? MustBeWeekend<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustBeWeekend(propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Check if the year part of datetime has at least X years from present year
        /// </summary>
        public static bool IsAtLeastYears<T>(this T? @this, int years) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsAtLeastYears(years);
                }
            }
            return false;
        }

        public static T? MustHasAtLeastYears<T>(this T? @this, int years, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustHasAtLeastYears(years, propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the year part of datetime has up to X years to present year
        /// </summary>
        public static bool IsUpToYears<T>(this T? @this, int years) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsUpToYears(years);
                }
            }
            return false;
        }

        public static T? MustHasUpToYears<T>(this T? @this, int years, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustHasUpToYears(years, propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Check if the day part of datetime has at least X days from present day
        /// </summary>
        public static bool IsAtLeastDays<T>(this T? @this, int days) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsAtLeastDays(days);
                }
            }
            return false;
        }

        public static T? MustHasAtLeastDays<T>(this T? @this, int days, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustHasAtLeastDays(days, propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Checks if the day part of datetime has up to X days to present day
        /// </summary>
        public static bool IsUpToDays<T>(this T? @this, int days) where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    return actualValue.IsUpToDays(days);
                }
            }
            return false;
        }

        public static T? MustHasUpToDays<T>(this T? @this, int days, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsNullOrDateTime())
            {
                if (@this.HasValue)
                {
                    DateTime actualValue = Convert.ToDateTime(@this.Value);
                    actualValue.MustHasUpToDays(days, propertyName);
                }
                else
                {
                    Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
                }
            }
            return @this;
        }

        /// <summary>
        /// Check if value's type is DateTime
        /// </summary>
        /// <param name="this">value to be checked</param>
        /// <returns>True if is DateTime</returns>
        private static bool IsNullOrDateTime(this object @this)
            => @this is null ? true 
                : @this is DateTime ? true 
                    : throw new Exception(string.Format(Resources.Resources.IncorrectType, "DateTime", @this.GetType().Name));
    }
}
