using ValidateMe.Errors;
using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Linq;

namespace ValidateMe
{
    public static class String
    {
        /// <summary>
        /// Checks if string has value
        /// </summary>
        public static bool HasValue(this string @this)
        {
            return !string.IsNullOrWhiteSpace(@this);
        }

        /// <summary>
        /// Ensure that string has value. If not, create a notification message
        /// </summary>
        public static string MustHasValue(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.HasValue())
                Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if string is greater than the specified length
        /// </summary>
        public static bool IsGreaterThan(this string @this, int length)
        {
            return @this.Length > length;
        }

        /// <summary>
        /// Ensure that string is greater than the specified length. If not, create a notification message
        /// </summary>
        public static string MustBeGreaterThan(this string @this, int length, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsGreaterThan(length))
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName, length.ToString(), "characters"));
            return @this;
        }

        /// <summary>
        /// Checks if string is smaller than the specified length
        /// </summary>
        public static bool IsSmallerThan(this string @this, int length)
        {
            return @this.Length < length;
        }

        /// <summary>
        /// Ensure that string is smaller than the specified length. If not, create a notification message
        /// </summary>
        public static string MustBeSmallerThan(this string @this, int length, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsSmallerThan(length))
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName, length.ToString(), "characters"));
            return @this;
        }

        /// <summary>
        /// Checks if string has the exact length
        /// </summary>
        public static bool HasExactLength(this string @this, int length)
        {
            return @this.Length == length;
        }

        /// <summary>
        /// Ensure that string has the exact length. If not, create a notification message
        /// </summary>
        public static string MustBeExactLength(this string @this, int length, [CallerMemberName]string propertyName = "")
        {
            if (!@this.HasExactLength(length))
                Notification.Add(Error.Create(ErrorData.HasNotExactLength, propertyName, length.ToString()));
            return @this;
        }

        /// <summary>
        /// Checks if string contains only letters and white space
        /// </summary>
        public static bool IsAlphabetic(this string @this)
        {
            return Regex.IsMatch(@this, @"^\p{L}+(?: \p{L}+)*$");
        }

        /// <summary>
        /// Ensure that string contains only letters and white spaces. If not, create a notification message
        /// </summary>
        public static string MustBeAlphabetic(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsAlphabetic())
                Notification.Add(Error.Create(ErrorData.IsNotAlphabetic, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if string contains only digits
        /// </summary>
        public static bool IsNumeric(this string @this)
        {
            return Regex.IsMatch(@this, @"^[0-9]+$");
        }

        /// <summary>
        /// Ensure that string contains only digits. If not, create a notification message
        /// </summary>
        public static string MustBeNumeric(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsNumeric())
                Notification.Add(Error.Create(ErrorData.IsNotNumeric, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if string contains letters and numbers
        /// </summary>
        public static bool IsAlphanumeric(this string @this)
        {
            string noSpacesThis = @this.Replace(" ", string.Empty);
            return noSpacesThis.Any(char.IsLetter) && noSpacesThis.Any(char.IsDigit);
        }

        /// <summary>
        /// Ensure that string is composed by letter and digits containing at least one letter and one digit. If not, create a notification message
        /// </summary>
        public static string MustBeAlphanumeric(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsAlphanumeric())
                Notification.Add(Error.Create(ErrorData.IsNotAlphanumeric, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if string contains letters or numbers
        /// </summary>
        public static bool CanBeAlphanumeric(this string @this)
        {
            string noSpacesThis = @this.Replace(" ", string.Empty);
            return noSpacesThis.Any(char.IsLetter) || noSpacesThis.Any(char.IsDigit);
        }

        /// <summary>
        /// Ensure that string is composed by letter and/or digits only. If not, create a notification message
        /// </summary>
        /// <remarks>Could contain white spaces also</remarks>
        public static string MayBeAlphanumeric(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.CanBeAlphanumeric())
                Notification.Add(Error.Create(ErrorData.IsNotAlphanumeric, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if string has any special character
        /// </summary>
        public static bool ContainsSpecialCharacters(this string @this)
        {
            return Regex.IsMatch(@this, @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]+", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Ensure that string contains any special characters. If not, create a notification message
        /// </summary>
        public static string MustContainSpecialCharacters(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.ContainsSpecialCharacters())
                Notification.Add(Error.Create(ErrorData.HasNoSpecialCharacters, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if string is a valid email
        /// </summary>
        public static bool IsEmail(this string @this)
        {
            return Regex.IsMatch(@this.ToLower(), @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z")
                            && Regex.IsMatch(@this.ToLower(), @"^(?=.{1,64}@.{4,64}$)(?=.{6,100}$).*");
        }

        /// <summary>
        /// Ensure that string is a valid email. If not, create a notification message
        /// </summary>
        public static string MustBeEmail(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsEmail())
                Notification.Add(Error.Create(ErrorData.IsNotEmail, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if string is well-formatted
        /// </summary>
        public static bool IsWellFormatted(this string @this, string pattern)
        {
            if (string.IsNullOrWhiteSpace(pattern))
                return false;

            return Regex.IsMatch(@this, pattern);
        }

        /// <summary>
        /// Ensure that string is well-formatted. If not, create a notification message
        /// </summary>
        /// <param name="pattern">regex pattern</param>
        public static string MustBeFormatted(this string @this, string pattern, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsWellFormatted(pattern))
                Notification.Add(Error.Create(ErrorData.Misformatted, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if string is a Guid
        /// </summary>
        public static bool IsGuid(this string @this)
        {
            return Guid.TryParse(@this, out _);
        }

        /// <summary>
        /// Ensure that string is a Guid. If not, create a notification message
        /// </summary>
        public static string MustBeGuid(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsGuid())
                Notification.Add(Error.Create(ErrorData.IsNotGuid, propertyName));
            return @this;
        }

        /// <summary>
        /// Checks if string has at least X words
        /// </summary>
        public static bool ContainsAtLeastWords(this string @this, int X)
        {
            return @this.Trim().Split(' ').Length >= X;
        }

        /// <summary>
        /// Ensure that string contains at least X words. If not, create a notification message
        /// </summary>
        public static string MustContainsAtLeastWords(this string @this, int X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.ContainsAtLeastWords(X))
                Notification.Add(Error.Create(ErrorData.HasNotMinimumWords, propertyName, X.ToString()));
            return @this;
        }

        /// <summary>
        /// Checks if value matchs the safety criteria
        /// </summary>
        public static bool IsSafe(this string @this)
        {
            return !(@this.ToLower().Contains("<")
                        || @this.ToLower().Contains(">")
                        || @this.ToLower().Contains("script")
                        || @this.ToLower().Contains("alert")
                        || @this.ToLower().Contains("insert ")
                        || @this.ToLower().Contains("update ")
                        || @this.ToLower().Contains("select ")
                        || @this.ToLower().Contains("delete ")
                        || @this.ToLower().Contains("drop ")
                        || @this.ToLower().Contains("where ")
                        || @this.ToLower().Contains("--")
                        || @this.ToLower().Contains("/*")
                        );
        }

        /// <summary>
        /// Ensure that string is safe. If not, create a notification message
        /// </summary>
        public static string MustBeSafe(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsSafe())
                Notification.Add(Error.Create(ErrorData.IsNotSafe, propertyName));
            return @this;
        }
    }
}
