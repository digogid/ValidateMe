using ValidateMe.Errors;
using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Timespan
    {
        public static bool MustBePast(this TimeSpan @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.TimeOfDay > @this;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInThePast, propertyName));

            return valid;
        }

        public static bool MustBeFuture(this TimeSpan @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = DateTime.Now.TimeOfDay < @this;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInTheFuture, propertyName));

            return valid;
        }

        public static bool MustBeInLast24Hours(this TimeSpan @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (DateTime.Now.TimeOfDay - @this).Hours <= 24;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInLast24Hours, propertyName));

            return valid;
        }

        public static bool MustBeInNext24Hours(this TimeSpan @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = (@this - DateTime.Now.TimeOfDay).Hours <= 24;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotInNext24Hours, propertyName));

            return valid;
        }
    }
}
