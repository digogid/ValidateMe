using ValidateMe.Errors;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Double
    {
        /// <summary>
        /// Checks if value is a positive number
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBePositive(this double @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this > 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotPositive, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if value is a negative number
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeNegative(this double @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this < 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotNegative, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if value is zero
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeZero(this double @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotZero, propertyName));

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
        public static bool MustBeEqual(this double @this, double X, bool notify = true, [CallerMemberName]string propertyName = "")
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
        public static bool MustBeGreaterThan(this double @this, double X, bool notify = true, [CallerMemberName]string propertyName = "")
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
        public static bool MustBeSmallerThan(this double @this, double X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this < X;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName));

            return valid;
        }
    }
}
