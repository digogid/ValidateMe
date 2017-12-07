using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class uint32
    {
        public static bool MustBeZero(this uint @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeZero(notify, propertyName);
        }
        public static bool MustBeEven(this uint @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeEven(notify, propertyName);
        }
        public static bool MustBeOdd(this uint @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeOdd(notify, propertyName);
        }
        public static bool MustBeEqual(this uint @this, uint comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeEqual(comparer, notify, propertyName);
        }
        public static bool MustBeGreaterThan(this uint @this, uint comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeGreaterThan(comparer, notify, propertyName);
        }
        public static bool MustBeSmallerThan(this uint @this, uint comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeSmallerThan(comparer, notify, propertyName);
        }
    }
}
