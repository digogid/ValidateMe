using ValidateMe.Errors;
using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    internal static class Timespan
    {
        /// <summary>
        /// Check if the value is in the past
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBePast(this TimeSpan @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.TimeOfDay > @this;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInThePast, propertyName));

            return valid;
        }

        /// <summary>
        /// Check if the value is in the future
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeFuture(this TimeSpan @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.TimeOfDay < @this;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInTheFuture, propertyName));

            return valid;
        }

        /// <summary>
        /// Check if the value is in the last 24 hours
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeInLast24Hours(this TimeSpan @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now.TimeOfDay - @this).Hours <= 24;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInLast24Hours, propertyName));

            return valid;
        }

        /// <summary>
        /// Check if the value is in the next 24 hours
        /// </summary>
        /// <param name="this">Value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeInNext24Hours(this TimeSpan @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (@this - DateTime.Now.TimeOfDay).Hours <= 24;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInNext24Hours, propertyName));

            return valid;
        }
    }
}
