using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class uint16
    {
        public static bool MustBeZero(this ushort @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeZero(notify, propertyName);
        }
        public static bool MustBeEven(this ushort @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeEven(notify, propertyName);
        }
        public static bool MustBeOdd(this ushort @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeOdd(notify, propertyName);
        }
        public static bool MustBeEqual(this ushort @this, ushort comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeEqual(comparer, notify, propertyName);
        }
        public static bool MustBeGreaterThan(this ushort @this, ushort comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeGreaterThan(comparer, notify, propertyName);
        }
        public static bool MustBeSmallerThan(this ushort @this, ushort comparer, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            return ((ulong)@this).MustBeSmallerThan(comparer, notify, propertyName);
        }
    }
}
