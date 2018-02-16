using ValidateMe.Errors;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Double
    {
        /// <summary>
        /// Checks if value is a positive number
        /// </summary>
        public static bool IsPositive(this double @this)
        {
            return @this > 0;
        }

        public static void MustBePositive(this double @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsPositive())
                Notification.Add(Error.Create(ErrorData.IsNotPositive, propertyName));
        }

        /// <summary>
        /// Checks if value is a negative number
        /// </summary>
        public static bool IsNegative(this double @this)
        {
            return @this < 0;
        }

        public static void MustBeNegative(this double @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsNegative())
                Notification.Add(Error.Create(ErrorData.IsNotNegative, propertyName));
        }

        /// <summary>
        /// Checks if value is zero
        /// </summary>
        public static bool IsZero(this double @this)
        {
            return @this == 0;
        }

        public static void MustBeZero(this double @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsZero())
                Notification.Add(Error.Create(ErrorData.IsNotZero, propertyName));
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        public static bool IsEqualTo(this double @this, double X)
        {
            return @this == X;
        }

        public static void MustBeEqualTo(this double @this, double X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsEqualTo(X))
                Notification.Add(Error.Create(ErrorData.IsNotEqual, propertyName));
        }

        /// <summary>
        /// Checks if value is greater than X
        /// </summary>
        public static bool IsGreaterThan(this double @this, double X)
        {
            return @this > X;
        }

        public static void MustBeGreaterThan(this double @this, double X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsGreaterThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName));
        }

        /// <summary>
        /// Checks if value is smaller than X
        /// </summary>
        public static bool IsSmallerThan(this double @this, double X)
        {
            return @this < X;
        }

        public static void MustBeSmallerThan(this double @this, double X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsSmallerThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName));
        }
    }
}
