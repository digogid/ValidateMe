using System.Runtime.CompilerServices;

namespace ValidateMe
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

        public static void MustBePositive(this int @this, [CallerMemberName]string propertyName = "")
        {
           ((long)@this).MustBePositive(propertyName);
        }

        /// <summary>
        /// Checks if value is negative
        /// </summary>
        public static bool IsNegative(this int @this)
        {
            return ((long)@this).IsNegative();
        }

        public static void MustBeNegative(this int @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeNegative(propertyName);
        }

        /// <summary>
        /// Checks if value is zero
        /// </summary>
        public static bool IsZero(this int @this)
        {
            return ((long)@this).IsZero();
        }

        public static void MustBeZero(this int @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeZero(propertyName);
        }

        /// <summary>
        /// Checks if value is even
        /// </summary>
        public static bool IsEven(this int @this)
        {
            return ((long)@this).IsEven();
        }

        public static void MustBeEven(this int @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeEven(propertyName);
        }

        /// <summary>
        /// Checks if value is odd
        /// </summary>
        public static bool IsOdd(this int @this)
        {
            return ((long)@this).IsOdd();
        }

        public static void MustBeOdd(this int @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeOdd(propertyName);
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        public static bool IsEqualTo(this int @this, int X)
        {
            return ((long)@this).IsEqualTo(X);
        }

        public static void MustBeEqualTo(this int @this, int X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeEqualTo(X, propertyName);
        }

        /// <summary>
        /// Checks if value is greater than 'X parameter'
        /// </summary>
        public static bool IsGreaterThan(this int @this, int X)
        {
            return ((long)@this).IsGreaterThan(X);
        }

        public static void MustBeGreaterThan(this int @this, int X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeGreaterThan(X, propertyName);
        }

        /// <summary>
        /// Checks if value is smaller than 'X parameter'
        /// </summary>
        public static bool IsSmallerThan(this int @this, int X)
        {
            return ((long)@this).IsSmallerThan(X);
        }

        public static void MustBeSmallerThan(this int @this, int X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeSmallerThan(X, propertyName);
        }
    }
}
