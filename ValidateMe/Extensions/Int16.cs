using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Int16
    {
        /// <summary>
        /// Checks if value is positive
        /// </summary>
        public static bool IsPositive(this short @this)
        {
            return ((long)@this).IsPositive();
        }

        /// <summary>
        /// Ensure that value is positive. If not, create a notification message
        /// </summary>
        public static short MustBePositive(this short @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBePositive(propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is negative
        /// </summary>
        public static bool IsNegative(this short @this)
        {
            return ((long)@this).IsNegative();
        }

        /// <summary>
        /// Ensure that value is negative. If not, create a notification message
        /// </summary>
        public static short MustBeNegative(this short @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeNegative(propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is zero
        /// </summary>
        public static bool IsZero(this short @this)
        {
            return ((long)@this).IsZero();
        }

        /// <summary>
        /// Ensure that value is zero. If not, create a notification message
        /// </summary>
        public static short MustBeZero(this short @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeZero(propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is even
        /// </summary>
        public static bool IsEven(this short @this)
        {
            return ((long)@this).IsEven();
        }

        /// <summary>
        /// Ensure that value is even. If not, create a notification message
        /// </summary>
        public static short MustBeEven(this short @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeEven(propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is odd
        /// </summary>
        public static bool IsOdd(this short @this)
        {
            return ((long)@this).IsOdd();
        }

        /// <summary>
        /// Ensure that value is odd. If not, create a notification message
        /// </summary>
        public static short MustBeOdd(this short @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeOdd(propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        public static bool IsEqualTo(this short @this, short X)
        {
            return ((long)@this).IsEqualTo(X);
        }

        /// <summary>
        /// Ensure that value is equals to X. If not, create a notification message
        /// </summary>
        public static short MustBeEqualTo(this short @this, short X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeEqualTo(X, propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is greater than X
        /// </summary>
        public static bool IsGreaterThan(this short @this, short X)
        {
            return ((long)@this).IsGreaterThan(X);
        }

        /// <summary>
        /// Ensure that value is greater than X. If not, create a notification message
        /// </summary>
        public static short MustBeGreaterThan(this short @this, short X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeGreaterThan(X, propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is smaller than X
        /// </summary>
        public static bool IsSmallerThan(this short @this, short X)
        {
            return ((long)@this).IsSmallerThan(X);
        }

        /// <summary>
        /// Ensure that value is smaller than X. If not, create a notification message
        /// </summary>
        public static short MustBeSmallerThan(this short @this, short X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeSmallerThan(X, propertyName);
            return @this;
        }

        /// <summary>
        /// Checks if value is smaller or equal to X
        /// </summary>
        public static bool IsSmallerOrEqualTo(this short @this, short X)
        {
            return ((long)@this).IsSmallerOrEqualTo(X);
        }

        /// <summary>
        /// Ensure that value is smaller or equal to X. If not, create a notification message
        /// </summary>
        public static short MustBeSmallerOrEqualTo(this short @this, short X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeSmallerOrEqualTo(X);
            return @this;
        }

        /// <summary>
        /// Checks if value is greater or equal to X
        /// </summary>
        public static bool IsGreaterOrEqualTo(this short @this, short X)
        {
            return ((long)@this).IsGreaterOrEqualTo(X);
        }

        /// <summary>
        /// Ensure that value is greater or equal to X. If not, create a notification message
        /// </summary>
        public static short MustBeGreaterOrEqualTo(this short @this, short X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeGreaterOrEqualTo(X);
            return @this;
        }

        /// <summary>
        /// Checks if value is different from X
        /// </summary>
        public static bool IsDifferentFrom(this short @this, short X)
        {
            return ((long)@this).IsDifferentFrom(X);
        }

        /// <summary>
        /// Ensure that value is different from X. If not, create a notification message
        /// </summary>
        public static short MustBeDifferentFrom(this short @this, short X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeDifferentFrom(X);
            return @this;
        }
    }
}
