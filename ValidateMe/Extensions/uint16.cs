using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class uint16
    {
        /// <summary>
        /// Checks if value is zero
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeZero(this ushort @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeZero(notify, propertyName);
        }

        /// <summary>
        /// Checks if value is even
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeEven(this ushort @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeEven(notify, propertyName);
        }

        /// <summary>
        /// Checks if value is odd
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeOdd(this ushort @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeOdd(notify, propertyName);
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeEqual(this ushort @this, ushort X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeEqual(X, notify, propertyName);
        }

        /// <summary>
        /// Checks if value is greater than 'X parameter'
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeGreaterThan(this ushort @this, ushort X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeGreaterThan(X, notify, propertyName);
        }

        /// <summary>
        /// Checks if value is smaller than 'X parameter'
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="X">Value to be compared</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeSmallerThan(this ushort @this, ushort X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeSmallerThan(X, notify, propertyName);
        }
    }
}
