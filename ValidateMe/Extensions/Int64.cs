using ValidateMe.Errors;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Int64
    {
        public static bool MustBePositive(this long @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this > 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotPositive, propertyName));

            return valid;
        }

        public static bool MustBeNegative(this long @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this < 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotNegative, propertyName));

            return valid;
        }

        public static bool MustBeZero(this long @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotZero, propertyName));

            return valid;
        }

        public static bool MustBeEven(this long @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this % 2 == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEven, propertyName));

            return valid;
        }

        public static bool MustBeOdd(this long @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this % 2 != 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotOdd, propertyName));

            return valid;
        }

        public static bool MustBeEqual(this long @this, long comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this == comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEqual, propertyName));

            return valid;
        }

        public static bool MustBeGreaterThan(this long @this, long comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this > comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName));

            return valid;
        }

        public static bool MustBeSmallerThan(this long @this, long comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this < comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName));

            return valid;
        }
    }
}
