using ValidateMe.Errors;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class uint64
    {
        public static bool MustBeZero(this ulong @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotZero, propertyName));

            return valid;
        }

        public static bool MustBeEven(this ulong @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this % 2 == 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEven, propertyName));

            return valid;
        }

        public static bool MustBeOdd(this ulong @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this % 2 != 0;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotOdd, propertyName));

            return valid;
        }

        public static bool MustBeEqual(this ulong @this, ulong comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this == comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEqual, propertyName));

            return valid;
        }

        public static bool MustBeGreaterThan(this ulong @this, ulong comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this > comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName));

            return valid;
        }

        public static bool MustBeSmallerThan(this ulong @this, ulong comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this < comparer;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName));

            return valid;
        }
    }
}
