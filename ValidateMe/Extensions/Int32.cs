using System.Runtime.CompilerServices;

namespace ValidateMe.Lib
{
    public static class Int32
    {
        /// <summary>
        /// Checks if value is positive
        /// </summary>
        public static bool IsPositive(this int @this)
        {
            return ((long)@this).IsPositive();
        }

        /// <summary>
        /// Ensure that value is positive. If not, create a notification message
        /// </summary>
        public static int MustBePositive(this int @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBePositive(propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is negative
        /// </summary>
        public static bool IsNegative(this int @this)
        {
            return ((long)@this).IsNegative();
        }

        /// <summary>
        /// Ensure that value is negative. If not, create a notification message
        /// </summary>
        public static int MustBeNegative(this int @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeNegative(propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is zero
        /// </summary>
        public static bool IsZero(this int @this)
        {
            return ((long)@this).IsZero();
        }

        /// <summary>
        /// Ensure that value is zero. If not, create a notification message
        /// </summary>
        public static int MustBeZero(this int @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeZero(propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is even
        /// </summary>
        public static bool IsEven(this int @this)
        {
            return ((long)@this).IsEven();
        }

        /// <summary>
        /// Ensure that value is even. If not, create a notification message
        /// </summary>
        public static int MustBeEven(this int @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeEven(propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is odd
        /// </summary>
        public static bool IsOdd(this int @this)
        {
            return ((long)@this).IsOdd();
        }

        /// <summary>
        /// Ensure that value is odd. If not, create a notification message
        /// </summary>
        public static int MustBeOdd(this int @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeOdd(propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        public static bool IsEqualTo(this int @this, int X)
        {
            return ((long)@this).IsEqualTo(X);
        }

        /// <summary>
        /// Ensure that value is equals to X. If not, create a notification message
        /// </summary>
        public static int MustBeEqualTo(this int @this, int X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeEqualTo(X, propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is greater than X
        /// </summary>
        public static bool IsGreaterThan(this int @this, int X)
        {
            return ((long)@this).IsGreaterThan(X);
        }

        /// <summary>
        /// Ensure that value is greater than X. If not, create a notification message
        /// </summary>
        public static int MustBeGreaterThan(this int @this, int X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeGreaterThan(X, propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is smaller than X
        /// </summary>
        public static bool IsSmallerThan(this int @this, int X)
        {
            return ((long)@this).IsSmallerThan(X);
        }

        /// <summary>
        /// Ensure that value is smaller than X. If not, create a notification message
        /// </summary>
        public static int MustBeSmallerThan(this int @this, int X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeSmallerThan(X, propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is smaller or equal to X
        /// </summary>
        public static bool IsSmallerOrEqualTo(this int @this, int X)
        {
            return ((long)@this).IsSmallerOrEqualTo(X);
        }

        /// <summary>
        /// Ensure that value is smaller or equal to X. If not, create a notification message
        /// </summary>
        public static int MustBeSmallerOrEqualTo(this int @this, int X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeSmallerOrEqualTo(X);
            return @this;
        }

        /// <summary>
        /// Checks if value is greater or equal to X
        /// </summary>
        public static bool IsGreaterOrEqualTo(this int @this, int X)
        {
            return ((long)@this).IsGreaterOrEqualTo(X);
        }

        /// <summary>
        /// Ensure that value is greater or equal to X. If not, create a notification message
        /// </summary>
        public static int MustBeGreaterOrEqualTo(this int @this, int X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeGreaterOrEqualTo(X);
            return @this;
        }

        /// <summary>
        /// Checks if value is different from X
        /// </summary>
        public static bool IsDifferentFrom(this int @this, int X)
        {
            return ((long)@this).IsDifferentFrom(X);
        }

        /// <summary>
        /// Ensure that value is different from X. If not, create a notification message
        /// </summary>
        public static int MustBeDifferentFrom(this int @this, int X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeDifferentFrom(X);
            return @this;
        }
    }
}
