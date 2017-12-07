using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class NullableDateTime
    {
        public static bool MustBePast<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBePast(notify, propertyName);
        }

        public static bool MustBeFuture<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeFuture(notify, propertyName);
        }

        public static bool MustBeToday<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeToday(notify, propertyName);
        }

        public static bool MustBeYesterday<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeYesterday(notify, propertyName);
        }

        public static bool MustBeTomorrow<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeTomorrow(notify, propertyName);
        }

        public static bool MustBeInLast365Days<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeInLast365Days(notify, propertyName);
        }

        public static bool MustBeInNext365Days<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeInNext365Days(notify, propertyName);
        }

        public static bool MustBeDawn<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeDawn(notify, propertyName);
        }

        public static bool MustBeMorning<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeMorning(notify, propertyName);
        }

        public static bool MustBeAfternoon<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeAfternoon(notify, propertyName);
        }

        public static bool MustBeEvening<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeEvening(notify, propertyName);
        }

        public static bool MustBeLeapYear<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeLeapYear(notify, propertyName);
        }

        public static bool MustBeMoreRecentThan<T>(this T? @this, DateTime comparer, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeMoreRecentThan(comparer, notify, propertyName);
        }

        public static bool MustBeOlderThan<T>(this T? @this, DateTime comparer, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeOlderThan(comparer, notify, propertyName);
        }

        public static bool MustBeWeekday<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeWeekday(notify, propertyName);
        }

        public static bool MustBeWeekend<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustBeWeekend(notify, propertyName);
        }

        public static bool MustHasAtLeastYears<T>(this T? @this, int years, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustHasAtLeastYears(years, notify, propertyName);
        }

        public static bool MustHasUpToYears<T>(this T? @this, int years, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustHasUpToYears(years, notify, propertyName);
        }

        public static bool MustHasAtLeastDays<T>(this T? @this, int days, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustHasAtLeastDays(days, notify, propertyName);
        }

        public static bool MustHasUpToDays<T>(this T? @this, int days, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid)
                return valid;

            DateTime actualValue = Convert.ToDateTime(@this.Value);
            return actualValue.MustHasUpToDays(days, notify, propertyName);
        }
    }
}
