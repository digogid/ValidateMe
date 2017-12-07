using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Int16
    {
        public static bool MustBePositive(this short @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBePositive(notify, propertyName);
        }
        public static bool MustBeNegative(this short @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeNegative(notify, propertyName);
        }
        public static bool MustBeZero(this short @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeZero(notify, propertyName);
        }
        public static bool MustBeEven(this short @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeEven(notify, propertyName);
        }
        public static bool MustBeOdd(this short @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeOdd(notify, propertyName);
        }
        public static bool MustBeEqual(this short @this, short comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeEqual(comparer, notify, propertyName);
        }
        public static bool MustBeGreaterThan(this short @this, short comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeGreaterThan(comparer, notify, propertyName);
        }
        public static bool MustBeSmallerThan(this short @this, short comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeSmallerThan(comparer, notify, propertyName);
        }
    }
}
