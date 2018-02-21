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

        public static void MustBePositive(this long @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsPositive())
                Notification.Add(Error.Create(ErrorData.IsNotPositive, propertyName));
        }

        /// <summary>
        /// Checks if value is negative
        /// </summary>
        public static bool IsNegative(this long @this)
        {
            return @this < 0;
        }

        public static void MustBeNegative(this long @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsNegative())
                Notification.Add(Error.Create(ErrorData.IsNotNegative, propertyName));
        }

        /// <summary>
        /// Checks if value is zero
        /// </summary>
        public static bool IsZero(this long @this)
        {
            return @this == 0;
        }

        public static void MustBeZero(this long @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsZero())
                Notification.Add(Error.Create(ErrorData.IsNotZero, propertyName));
        }

        /// <summary>
        /// Checks if value is even
        /// </summary>
        public static bool IsEven(this long @this)
        {
            return @this % 2 == 0;
        }

        public static void MustBeEven(this long @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsEven())
                Notification.Add(Error.Create(ErrorData.IsNotEven, propertyName));
        }

        /// <summary>
        /// Checks if value is odd
        /// </summary>
        public static bool IsOdd(this long @this)
        {
            return @this % 2 != 0;
        }

        public static void MustBeOdd(this long @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsOdd())
                Notification.Add(Error.Create(ErrorData.IsNotOdd, propertyName));
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        public static bool IsEqualTo(this long @this, long X)
        {
            return @this == X;
        }

        public static void MustBeEqualTo(this long @this, long X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsEqualTo(X))
                Notification.Add(Error.Create(ErrorData.IsNotEqual, propertyName, X.ToString(), string.Empty));
        }

        /// <summary>
        /// Checks if value is greater than 'X parameter'
        /// </summary>
        public static bool IsGreaterThan(this long @this, long X)
        {
            return @this > X;
        }

        public static void MustBeGreaterThan(this long @this, long X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsGreaterThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName, X.ToString(), string.Empty));
        }

        /// <summary>
        /// Checks if value is smaller than 'X parameter'
        /// </summary>
        public static bool IsSmallerThan(this long @this, long X)
        {
            return @this < X;
        }
        
        public static void MustBeSmallerThan(this long @this, long X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsSmallerThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName, X.ToString(), string.Empty));
        }
    }
}
