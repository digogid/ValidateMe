using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Int16
    {
        /// <summary>
        /// Checks if value is positive
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBePositive(this short @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBePositive(notify, propertyName);
        }

        /// <summary>
        /// Checks if value is negative
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeNegative(this short @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeNegative(notify, propertyName);
        }

        /// <summary>
        /// Checks if value is zero
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeZero(this short @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeZero(notify, propertyName);
        }

        /// <summary>
        /// Checks if value is even
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeEven(this short @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeEven(notify, propertyName);
        }

        /// <summary>
        /// Checks if value is odd
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeOdd(this short @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeOdd(notify, propertyName);
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeEqual(this short @this, short X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeEqual(X, notify, propertyName);
        }

        /// <summary>
        /// Checks if value is greater than 'X parameter'
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeGreaterThan(this short @this, short X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeGreaterThan(X, notify, propertyName);
        }

        /// <summary>
        /// Checks if value is smaller than 'X parameter'
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeSmallerThan(this short @this, short X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeSmallerThan(X, notify, propertyName);
        }
    }
}
