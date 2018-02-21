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

        /// <summary>
        /// Ensure that has a value and it is positive. If not, create a notification message
        /// </summary>
        public static T? MustBePositive<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBePositive(propertyName);
            }
            return @this;
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

        /// <summary>
        /// Ensure that has a value and it is negative. If not, create a notification message
        /// </summary>
        public static T? MustBeNegative<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeNegative(propertyName);
            }
            return @this;
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

        /// <summary>
        /// Ensure that has a value and it is zero. If not, create a notification message
        /// </summary>
        public static T? MustBeZero<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeZero(propertyName);
            }
            return @this;
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

        /// <summary>
        /// Ensure that has a value and it is even. If not, create a notification message
        /// </summary>
        public static T? MustBeEven<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeEven(propertyName);
            }
            return @this;
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

        /// <summary>
        /// Ensure that has a value and it is odd. If not, create a notification message
        /// </summary>
        public static T? MustBeOdd<T>(this T? @this, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeOdd(propertyName);
            }
            return @this;
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

        /// <summary>
        /// Ensure that has a value and it is equals to X. If not, create a notification message
        /// </summary>
        public static T? MustBeEqualTo<T>(this T? @this, long X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeEqualTo(X, propertyName);
            }
            return @this;
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

        /// <summary>
        /// Ensure that has a value and it is greater than X. If not, create a notification message
        /// </summary>
        public static T? MustBeGreaterThan<T>(this T? @this, long X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeGreaterThan(X, propertyName);
            }
            return @this;
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

        /// <summary>
        /// Ensure that has a value and it is smaller than X. If not, create a notification message
        /// </summary>
        public static T? MustBeSmallerThan<T>(this T? @this, long X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeSmallerThan(X, propertyName);
            }
            return @this;
        }


        /// <summary>
        /// Checks if value is smaller or equal to X
        /// </summary>
        public static bool IsSmallerOrEqualTo<T>(this T? @this, long X) where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                return actualValue.IsSmallerOrEqualTo(X);
            }
            return false;
        }

        /// <summary>
        /// Ensure that value is smaller or equal to X. If not, create a notification message
        /// </summary>
        public static T? MustBeSmallerOrEqualTo<T>(this T? @this, long X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeSmallerOrEqualTo(X, propertyName);
            }
            return @this;
        }

        /// <summary>
        /// Checks if value is greater or equal to X
        /// </summary>
        public static bool IsGreaterOrEqualTo<T>(this T? @this, long X) where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                return actualValue.IsSmallerOrEqualTo(X);
            }
            return false;
        }

        /// <summary>
        /// Ensure that value is greater or equal to X. If not, create a notification message
        /// </summary>
        public static T? MustBeGreaterOrEqualTo<T>(this T? @this, long X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeGreaterOrEqualTo(X, propertyName);
            }
            return @this;
        }

        /// <summary>
        /// Checks if value is different from X
        /// </summary>
        public static bool IsDifferentFrom<T>(this T? @this, long X) where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                return actualValue.IsDifferentFrom(X);
            }
            return false;
        }

        /// <summary>
        /// Ensure that value is different from X. If not, create a notification message
        /// </summary>
        public static T? MustBeDifferentFrom<T>(this T? @this, long X, [CallerMemberName]string propertyName = "") where T : struct
        {
            if (@this.IsValidInteger())
            {
                long actualValue = Convert.ToInt64(@this.Value);
                actualValue.MustBeDifferentFrom(X, propertyName);
            }
            return @this;
        }


        /// <summary>
        /// Check if the value passed is integer type (short, int or long)
        /// </summary>
        private static bool IsInteger(this object @this)
            => @this is short || @this is int || @this is long ? true : throw new ArgumentException(string.Format(Resources.Resources.IncorrectType, "Integer", @this.GetType().Name));
    }
}
