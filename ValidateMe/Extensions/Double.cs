using ValidateMe.Lib.Errors;
using System.Runtime.CompilerServices;

namespace ValidateMe.Lib
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

        /// <summary>
        /// Ensure that value is a positive number. If not, create a message
        /// </summary>
        public static double MustBePositive(this double @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsPositive())
                Notification.Add(Error.Create(ErrorData.IsNotPositive, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if value is a negative number
        /// </summary>
        public static bool IsNegative(this double @this)
        {
            return @this < 0;
        }

        /// <summary>
        /// Ensure that value is a negative number. If not, create a message
        /// </summary>
        public static double MustBeNegative(this double @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsNegative())
                Notification.Add(Error.Create(ErrorData.IsNotNegative, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if value is zero
        /// </summary>
        public static bool IsZero(this double @this)
        {
            return @this == 0;
        }

        /// <summary>
        /// Ensure that value is zero. If not, create a message
        /// </summary>
        public static double MustBeZero(this double @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsZero())
                Notification.Add(Error.Create(ErrorData.IsNotZero, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if value is equal to X
        /// </summary>
        public static bool IsEqualTo(this double @this, double X)
        {
            return @this == X;
        }

        /// <summary>
        /// Ensure that value is equal to X. If not, create a message
        /// </summary>
        public static double MustBeEqualTo(this double @this, double X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsEqualTo(X))
                Notification.Add(Error.Create(ErrorData.IsNotEqual, propertyName, X.ToString()));
            return @this;
        }

        /// <summary>
        /// Checks if value is greater than X
        /// </summary>
        public static bool IsGreaterThan(this double @this, double X)
        {
            return @this > X;
        }

        /// <summary>
        /// Ensure that value is greater than X. If not, create a message
        /// </summary>
        public static double MustBeGreaterThan(this double @this, double X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsGreaterThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName, X.ToString()));
            return @this;
        }

        /// <summary>
        /// Checks if value is smaller than X
        /// </summary>
        public static bool IsSmallerThan(this double @this, double X)
        {
            return @this < X;
        }

        /// <summary>
        /// Ensure that value is smaller than X. If not, create a message
        /// </summary>
        public static double MustBeSmallerThan(this double @this, double X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsSmallerThan(X))
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName, X.ToString()));
            return @this;
        }
    }
}
