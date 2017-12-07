using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Int32
    {
        public static bool MustBePositive(this int @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBePositive(notify, propertyName);
        }
        public static bool MustBeNegative(this int @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeNegative(notify, propertyName);
        }
        public static bool MustBeZero(this int @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeZero(notify, propertyName);
        }
        public static bool MustBeEven(this int @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeEven(notify, propertyName);
        }
        public static bool MustBeOdd(this int @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeOdd(notify, propertyName);
        }
        public static bool MustBeEqual(this int @this, int comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeEqual(comparer, notify, propertyName);
        }
        public static bool MustBeGreaterThan(this int @this, int comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeGreaterThan(comparer, notify, propertyName);
        }
        public static bool MustBeSmallerThan(this int @this, int comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((long)@this).MustBeSmallerThan(comparer, notify, propertyName);
        }
    }
}
