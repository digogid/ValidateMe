using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class NullableUnassignedInteger
    {
        public static bool MustBeZero<T>(T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid && notify)
                return valid;

            ulong actualValue = Convert.ToUInt64(@this.Value);
            return actualValue.MustBeZero(notify, propertyName);
        }
        public static bool MustBeEven<T>(T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid && notify)
                return valid;

            ulong actualValue = Convert.ToUInt64(@this.Value);
            return actualValue.MustBeEven(notify, propertyName);
        }
        public static bool MustBeOdd<T>(T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid && notify)
                return valid;

            ulong actualValue = Convert.ToUInt64(@this.Value);
            return actualValue.MustBeOdd(notify, propertyName);
        }
        public static bool MustBeEqual<T>(this T? @this, ulong comparer, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid && notify)
                return valid;

            ulong actualValue = Convert.ToUInt64(@this.Value);
            return actualValue.MustBeEqual(comparer, notify, propertyName);
        }
        public static bool MustBeGreaterThan<T>(this T? @this, ulong comparer, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid && notify)
                return valid;

            ulong actualValue = Convert.ToUInt64(@this.Value);
            return actualValue.MustBeGreaterThan(comparer, notify, propertyName);
        }
        public static bool MustBeSmallerThan<T>(this T? @this, ulong comparer, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = @this.HasValue(notify, propertyName);

            if (!valid && notify)
                return valid;

            ulong actualValue = Convert.ToUInt64(@this.Value);
            return actualValue.MustBeSmallerThan(comparer, notify, propertyName);
        }
    }
}
