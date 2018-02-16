using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class NullableInteger
    {
        /// <summary>
        /// Check if it is an integer (short, int or long) and has value
        /// </summary>
        internal static bool IsValidInteger<T>(this T? @this) where T : struct
        {
            return @this.IsInteger() && @this.ContainsValue();
        }

        /// <summary>
        /// Check if has value and if its value is positive
        /// </summary>
        public static bool IsPositive<T>(this T? @this) where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                return actualValue.IsPositive();
            }
            return false;
        }

        public static void MustBePositive<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBePositive(propertyName);
            }
        }

        /// <summary>
        /// Check if has value and if its value is negative
        /// </summary>
        public static bool IsNegative<T>(this T? @this) where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                return actualValue.IsNegative();
            }
            return false;
        }

        public static void MustBeNegative<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeNegative(propertyName);
            }
        }

        /// <summary>
        /// Check if has value and if its value is equal to zero
        /// </summary>
        public static bool IsZero<T>(this T? @this) where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                return actualValue.IsZero();
            }
            return false;
        }

        public static void MustBeZero<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeZero(propertyName);
            }
        }

        /// <summary>
        /// Check if has value and if its value is even
        /// </summary>
        public static bool IsEven<T>(this T? @this) where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                return actualValue.IsEven();
            }
            return false;
        }

        public static void MustBeEven<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeEven(propertyName);
            }
        }

        /// <summary>
        /// Check if has value and if its value is odd
        /// </summary>
        public static bool IsOdd<T>(this T? @this) where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                return actualValue.IsOdd();
            }
            return false;
        }

        public static void MustBeOdd<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeOdd(propertyName);
            }
        }

        /// <summary>
        /// Check if has value and if its value is equal to X
        /// </summary>
        public static bool IsOdd<T>(this T? @this, long X) where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                return actualValue.IsEqualTo(X);
            }
            return false;
        }

        public static void MustBeEqualTo<T>(this T? @this, long X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeEqualTo(X, propertyName);
            }
        }

        /// <summary>
        /// Check if has value and if its value is greater than X
        /// </summary>
        public static bool IsGreaterThan<T>(this T? @this, long X) where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                return actualValue.IsGreaterThan(X);
            }
            return false;
        }

        public static void MustBeGreaterThan<T>(this T? @this, long X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeGreaterThan(X, propertyName);
            }
        }

        /// <summary>
        /// Check if has value and if its value is smaller than X
        /// </summary>
        public static bool IsSmallerThan<T>(this T? @this, long X) where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                return actualValue.IsSmallerThan(X);
            }
            return false;
        }

        public static void MustBeSmallerThan<T>(this T? @this, long X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeSmallerThan(X, propertyName);
            }
        }

        /// <summary>
        /// Check if the value passed is integer type (short, int or long)
        /// </summary>
        private static bool IsInteger(this object @this)
            => @this is short || @this is int || @this is long ? true : throw new ArgumentException(string.Format(Resources.Resources.IncorrectType, "Integer", @this.GetType().Name));
    }
}
