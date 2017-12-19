using ValidateMe.Attributes;
using ValidateMe.Errors;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class General
    {
        public static bool MustHasValue<T>(this T? obj, bool notify = true, [CallerMemberName]string propertyName = "") where T : struct
        {
            bool valid = obj.HasValue;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));

            return valid;
        }

        public static string GetDisplayName(this Object obj, bool notify = true, [CallerMemberName] string propertyName = "")
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
