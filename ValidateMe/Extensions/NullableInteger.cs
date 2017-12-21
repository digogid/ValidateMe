using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class NullableInteger
    {
        /// <summary>
        /// Check if has value and if its value is positive
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBePositive<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBePositive(notify, propertyName);
        }

        /// <summary>
        /// Check if has value and if its value is negative
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeNegative<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeNegative(notify, propertyName);
        }

        /// <summary>
        /// Check if has value and if its value is equal to zero
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeZero<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeZero(notify, propertyName);
        }

        /// <summary>
        /// Check if has value and if its value is even
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeEven<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeEven(notify, propertyName);
        }

        /// <summary>
        /// Check if has value and if its value is odd
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeOdd<T>(this T? @this, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeOdd(notify, propertyName);
        }

        /// <summary>
        /// Check if has value and if its value is equal to the 'X parameter'
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared to</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeEqual<T>(this T? @this, long X, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeEqual(X, notify, propertyName);
        }

        /// <summary>
        /// Check if has value and if its value is greater than the 'X parameter'
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared to</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeGreaterThan<T>(this T? @this, long X, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeGreaterThan(X, notify, propertyName);
        }

        /// <summary>
        /// Check if has value and if its value is smaller than the 'X parameter'
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared to</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeSmallerThan<T>(this T? @this, long X, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            @this.IsInteger();

            bool valid = @this.MustHasValue(notify, propertyName);

            if (!valid)
                return valid;

            long actualValue = Convert.ToInt64(@this.Value);
            return actualValue.MustBeSmallerThan(X, notify, propertyName);
        }

        /// <summary>
        /// Check if the value passed is integer type (short, int or long)
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        private static bool IsInteger(this object @this)
            => @this is short || @this is int || @this is long ? true : throw new Exception(string.Format(Resources.Resources.IncorrectType, "Integer", @this.GetType().Name));
    }
}
