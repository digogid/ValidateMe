using ValidateMe.Errors;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Float
    {
        public static bool MustBePositive(this float @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this > 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotPositive, propertyName));

            return valid;
        }

        public static bool MustBeNegative(this float @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this < 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotNegative, propertyName));

            return valid;
        }

        public static bool MustBeZero(this float @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotZero, propertyName));

            return valid;
        }

        public static bool MustBeEqual(this float @this, float comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this == comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEqual, propertyName));

            return valid;
        }

        public static bool MustBeGreaterThan(this float @this, float comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this > comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName));

            return valid;
        }

        public static bool MustBeSmallerThan(this float @this, float comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this < comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName));

            return valid;
        }
    }
}
