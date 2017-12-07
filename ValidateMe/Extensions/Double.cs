using ValidateMe.Errors;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Double
    {
        public static bool MustBePositive(this double @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this > 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotPositive, propertyName));

            return valid;
        }

        public static bool MustBeNegative(this double @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this < 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotNegative, propertyName));

            return valid;
        }

        public static bool MustBeZero(this double @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotZero, propertyName));

            return valid;
        }

        public static bool MustBeEqual(this double @this, double comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this == comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEqual, propertyName));

            return valid;
        }

        public static bool MustBeGreaterThan(this double @this, double comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this > comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName));

            return valid;
        }

        public static bool MustBeSmallerThan(this double @this, double comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this < comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName));

            return valid;
        }
    }
}
