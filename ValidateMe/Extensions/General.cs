using ValidateMe.Attributes;
using ValidateMe.Errors;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class General
    {
        /// <summary>
        /// Checks if a Nullable<T> has value.
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="obj">value to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustHasValue<T>(this T? obj, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = obj.HasValue;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));

            return valid;
        }

        /// <summary>
        /// Gets the name of property that will be checked.
        /// </summary>
        /// <param name="obj">Object that will get the name from</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>CustomAttributeName value if set or CallerMemberName</returns>
        internal static string GetDisplayName(this Object obj, [CallerMemberName] string propertyName = "")
        {
            var displayName = obj
                                .GetType()
                                .GetProperty(propertyName)
                                .GetCustomAttributes(false)
                                .OfType<CustomNameAttribute>();


            return displayName.FirstOrDefault() != null ?
                displayName.FirstOrDefault().Name : propertyName;
        }
    }
}
