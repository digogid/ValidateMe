using ValidateMe.Errors;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Int64
    {
        /// <summary>
        /// Checks if value is positive
        /// </summary>
        public static bool IsPositive(this long @this)
        {
            return @this > 0;
        }

        /// <summary>
        /// Ensure that value is positive. If not, create a notification message
        /// </summary>
        public static long MustBePositive(this long @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsPositive())
                Notification.Add(Error.Create(ErrorData.IsNotPositive, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if value is negative
        /// </summary>
        public static bool IsNegative(this long @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// Ensure that value is negative. If not, create a notification message
        /// </summary>
        public static long MustBeNegative(this long @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsNegative())
                Notification.Add(Error.Create(ErrorData.IsNotNegative, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if value is zero
        /// </summary>
        public static bool IsZero(this long @this)
        {
            return @this == 0;
        }

        /// <summary>
        /// Ensure that value is zero. If not, create a notification message
        /// </summary>
        public static long MustBeZero(this long @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsZero())
                Notification.Add(Error.Create(ErrorData.IsNotZero, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if value is even
        /// </summary>
        public static bool IsEven(this long @this)
        {
            return @this % 2 == 0;
        }

        /// <summary>
        /// Ensure that value is even. If not, create a notification message
        /// </summary>
        public static long MustBeEven(this long @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsEven())
                Notification.Add(Error.Create(ErrorData.IsNotEven, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if value is odd
        /// </summary>
        public static bool IsOdd(this long @this)
        {
            return @this % 2 != 0;
        }

        /// <summary>
        /// Ensure that value is odd. If not, create a notification message
        /// </summary>
        public static long MustBeOdd(this long @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsOdd())
                Notification.Add(Error.Create(ErrorData.IsNotOdd, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        public static bool IsEqualTo(this long @this, long X)
        {
            return @this == X;
        }

        /// <summary>
        /// Ensure that value is equals to X. If not, create a notification message
        /// </summary>
        public static long MustBeEqualTo(this long @this, long X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsEqualTo(X))
                Notification.Add(Error.Create(ErrorData.IsNotEqual, propertyName, X.ToString(), string.Empty));
            return @this;
        }

        /// <summary>
        /// Checks if value is greater than X
        /// </summary>
        public static bool IsGreaterThan(this long @this, long X)
        {
            return @this > X;
        }

        /// <summary>
        /// Ensure that value is greater than X. If not, create a notification message
        /// </summary>
        public static long MustBeGreaterThan(this long @this, long X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsGreaterThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName, X.ToString(), string.Empty));
            return @this;
        }

        /// <summary>
        /// Checks if value is smaller than X
        /// </summary>
        public static bool IsSmallerThan(this long @this, long X)
        {
            return @this < X;
        }

        /// <summary>
        /// Ensure that value is smaller than X. If not, create a notification message
        /// </summary>
        public static long MustBeSmallerThan(this long @this, long X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsSmallerThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName, X.ToString(), string.Empty));
            return @this;
        }

        /// <summary>
        /// Checks if value is smaller or equal to X
        /// </summary>
        public static bool IsSmallerOrEqualTo(this long @this, long X)
        {
            return @this <= X;
        }

        /// <summary>
        /// Ensure that value is smaller or equal to X. If not, create a notification message
        /// </summary>
        public static long MustBeSmallerOrEqualTo(this long @this, long X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsSmallerOrEqualTo(X))
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName, X.ToString(), string.Empty));
            return @this;
        }

        /// <summary>
        /// Checks if value is greater or equal to X
        /// </summary>
        public static bool IsGreaterOrEqualTo(this long @this, long X)
        {
            return @this >= X;
        }

        /// <summary>
        /// Ensure that value is greater or equal to X. If not, create a notification message
        /// </summary>
        public static long MustBeGreaterOrEqualTo(this long @this, long X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsGreaterOrEqualTo(X))
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName, X.ToString(), string.Empty));
            return @this;
        }

        /// <summary>
        /// Checks if value is different from X
        /// </summary>
        public static bool IsDifferentFrom(this long @this, long X)
        {
            return @this != X;
        }

        /// <summary>
        /// Ensure that value is different from X. If not, create a notification message
        /// </summary>
        public static long MustBeDifferentFrom(this long @this, long X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsSmallerOrEqualTo(X))
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName, X.ToString(), string.Empty));
            return @this;
        }
    }
}
