using ValidateMe.Errors;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Float
    {
        /// <summary>
        /// Checks if value is a positive number
        /// </summary>
        public static bool IsPositive(this float @this)
        {
            return @this > 0;
        }

        public static void MustBePositive(this float @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsPositive())
                Notification.Add(Error.Create(ErrorData.IsNotPositive, propertyName));
        }

        /// <summary>
        /// Checks if value is a negative number
        /// </summary>
        public static bool IsNegative(this float @this)
        {
            return @this < 0;
        }

        public static void MustBeNegative(this float @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsNegative())
                Notification.Add(Error.Create(ErrorData.IsNotNegative, propertyName));
        }

        /// <summary>
        /// Checks if value is zero
        /// </summary>
        public static bool IsZero(this float @this)
        {
            return @this == 0;
        }

        public static void MustBeZero(this float @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsZero())
                Notification.Add(Error.Create(ErrorData.IsNotZero, propertyName));
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        public static bool IsEqualTo(this float @this, float X)
        {
            return @this == X;
        }

        public static void MustBeEqualTo(this float @this, float X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsEqualTo(X))
                Notification.Add(Error.Create(ErrorData.IsNotEqual, propertyName));
        }

        /// <summary>
        /// Checks if value is greater than X
        /// </summary>
        public static bool IsGreaterThan(this float @this, float X)
        {
            return @this > X;
        }

        public static void MustBeGreaterThan(this float @this, float X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsGreaterThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName));
        }

        /// <summary>
        /// Checks if value is smaller than X
        /// </summary>
        public static bool IsSmallerThan(this float @this, float X)
        {
            return @this < X;
        }

        public static void MustBeSmallerThan(this float @this, float X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsSmallerThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName));
        }
    }
}
