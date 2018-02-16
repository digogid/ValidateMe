using ValidateMe.Errors;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    internal static class uint64
    {
        /// <summary>
        /// Checks if value is zero
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeZero(this ulong @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotZero, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if value is even
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeEven(this ulong @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this % 2 == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEven, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if value is odd
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeOdd(this ulong @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this % 2 != 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotOdd, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeEqual(this ulong @this, ulong X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this == X;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEqual, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if value is greater than 'X parameter'
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeGreaterThan(this ulong @this, ulong X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this > X;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if value is smaller than 'X parameter'
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeSmallerThan(this ulong @this, ulong X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this < X;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName));

            return valid;
        }
    }
}
