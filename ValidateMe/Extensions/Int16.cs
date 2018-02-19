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

        public static void MustBePositive(this short @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBePositive(propertyName);
        }

        /// <summary>
        /// Checks if value is negative
        /// </summary>
        public static bool IsNegative(this short @this)
        {
            return ((long)@this).IsNegative();
        }

        public static void MustBeNegative(this short @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeNegative(propertyName);
        }

        /// <summary>
        /// Checks if value is zero
        /// </summary>
        public static bool IsZero(this short @this)
        {
            return ((long)@this).IsZero();
        }

        public static void MustBeZero(this short @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeZero(propertyName);
        }

        /// <summary>
        /// Checks if value is even
        /// </summary>
        public static bool IsEven(this short @this)
        {
            return ((long)@this).IsEven();
        }

        public static void MustBeEven(this short @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeEven(propertyName);
        }

        /// <summary>
        /// Checks if value is odd
        /// </summary>
        public static bool IsOdd(this short @this)
        {
            return ((long)@this).IsOdd();
        }

        public static void MustBeOdd(this short @this, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeOdd(propertyName);
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        public static bool IsEqualTo(this short @this, short X)
        {
            return ((long)@this).IsEqualTo(X);
        }

        public static void MustBeEqual(this short @this, short X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeEqualTo(X, propertyName);
        }

        /// <summary>
        /// Checks if value is greater than 'X parameter'
        /// </summary>
        public static bool IsGreaterThan(this short @this, short X)
        {
            return ((long)@this).IsGreaterThan(X);
        }

        public static void MustBeGreaterThan(this short @this, short X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeGreaterThan(X, propertyName);
        }

        /// <summary>
        /// Checks if value is smaller than 'X parameter'
        /// </summary>
        public static bool IsSmallerThan(this short @this, short X)
        {
            return ((long)@this).IsSmallerThan(X);
        }

        public static void MustBeSmallerThan(this short @this, short X, [CallerMemberName]string propertyName = "")
        {
            ((long)@this).MustBeSmallerThan(X, propertyName);
        }
    }
}
