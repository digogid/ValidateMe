using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class NullableInteger
    {
        public static bool MustBePositive<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBePositive(notify, propertyName);
        }
        public static bool MustBeNegative<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeNegative(notify, propertyName);
        }
        public static bool MustBeZero<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            if (@this is UInt64 || @this is UInt32 || @this is UInt16)
            {
                return NullableUnassignedInteger.MustBeZero(@this, notify, propertyName);
            }

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeZero(notify, propertyName);
        }
        public static bool MustBeEven<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            if (@this is UInt64 || @this is UInt32 || @this is UInt16)
            {
                return NullableUnassignedInteger.MustBeEven(@this, notify, propertyName);
            }

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeEven(notify, propertyName);
        }
        public static bool MustBeOdd<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            if (@this is UInt64 || @this is UInt32 || @this is UInt16)
            {
                return NullableUnassignedInteger.MustBeOdd(@this, notify, propertyName);
            }

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeOdd(notify, propertyName);
        }
        public static bool MustBeEqual<T>(this T? @this, long comparer, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeEqual(comparer, notify, propertyName);
        }
        public static bool MustBeGreaterThan<T>(this T? @this, long comparer, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeGreaterThan(comparer, notify, propertyName);
        }
        public static bool MustBeSmallerThan<T>(this T? @this, long comparer, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeSmallerThan(comparer, notify, propertyName);
        }
        private static bool IsInteger(this object @this)
            => @this is short || @this is int || @this is long ? true : throw new Exception("Integer was expected.");
    }
}
