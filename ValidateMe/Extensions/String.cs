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

        public static void MustHasValue(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.HasValue())
                Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));
        }

        /// <summary>
        /// Checks if string is greater than the specified length
        /// </summary>
        public static bool IsGreaterThan(this string @this, int length)
        {
            return @this.Length > length;
        }

        public static void MustBeGreaterThan(this string @this, int length, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsGreaterThan(length))
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName, length.ToString(), "characters"));
        }

        /// <summary>
        /// Checks if string is smaller than the specified length
        /// </summary>
        public static bool IsSmallerThan(this string @this, int length)
        {
            return @this.Length < length;
        }

        public static void MustBeSmallerThan(this string @this, int length, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsSmallerThan(length))
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName, length.ToString(), "characters"));
        }

        /// <summary>
        /// Checks if string has the exact required length
        /// </summary>
        public static bool HasExactLength(this string @this, int length)
        {
            return @this.Length == length;
        }

        public static void MustBeExactLength(this string @this, int length, [CallerMemberName]string propertyName = "")
        {
            if (!@this.HasExactLength(length))
                Notification.Add(Error.Create(ErrorData.HasNotExactLength, propertyName, length.ToString()));
        }

        /// <summary>
        /// Checks if string contains only letters and white space
        /// </summary>
        public static bool IsAlphabetic(this string @this)
        {
            return Regex.IsMatch(@this, @"^\p{L}+(?: \p{L}+)*$");
        }

        public static void MustBeAlphabetic(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsAlphabetic())
                Notification.Add(Error.Create(ErrorData.IsNotAlphabetic, propertyName));
        }

        /// <summary>
        /// Checks if string contains only numbers
        /// </summary>
        public static bool IsNumeric(this string @this)
        {
            return Regex.IsMatch(@this, @"^[0-9]+$");
        }

        public static void MustBeNumeric(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsNumeric())
                Notification.Add(Error.Create(ErrorData.IsNotNumeric, propertyName));
        }

        /// <summary>
        /// Checks if string contains letters and numbers
        /// </summary>
        public static bool IsAlphanumeric(this string @this)
        {
            string noSpacesThis = @this.Replace(" ", string.Empty);
            return noSpacesThis.Any(char.IsLetter) && noSpacesThis.Any(char.IsDigit);
        }

        public static void MustBeAlphanumeric(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsAlphanumeric())
                Notification.Add(Error.Create(ErrorData.IsNotAlphanumeric, propertyName));
        }

        /// <summary>
        /// Checks if string contains letters or numbers
        /// </summary>
        public static bool CanBeAlphanumeric(this string @this)
        {
            string noSpacesThis = @this.Replace(" ", string.Empty);
            return noSpacesThis.Any(char.IsLetter) || noSpacesThis.Any(char.IsDigit);
        }

        public static void MayBeAlphanumeric(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.CanBeAlphanumeric())
                Notification.Add(Error.Create(ErrorData.IsNotAlphanumeric, propertyName));
        }

        /// <summary>
        /// Checks if string has any special character into it
        /// </summary>
        public static bool ContainsSpecialCharacters(this string @this)
        {
            return Regex.IsMatch(@this, @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]+", RegexOptions.IgnoreCase);
        }

        public static void MustContainSpecialCharacters(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.ContainsSpecialCharacters())
                Notification.Add(Error.Create(ErrorData.HasNoSpecialCharacters, propertyName));
        }

        /// <summary>
        /// Checks if string is a valid email
        /// </summary>
        public static bool IsEmail(this string @this)
        {
            return Regex.IsMatch(@this.ToLower(), @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z")
                            && Regex.IsMatch(@this.ToLower(), @"^(?=.{1,64}@.{4,64}$)(?=.{6,100}$).*");
        }

        public static void MustBeEmail(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsEmail())
                Notification.Add(Error.Create(ErrorData.IsNotEmail, propertyName));
        }

        /// <summary>
        /// Checks if string has value
        /// </summary>
        public static bool IsWellFormatted(this string @this, string pattern)
        {
            if (string.IsNullOrWhiteSpace(pattern))
                return false;

            return Regex.IsMatch(@this, pattern);
        }

        public static void MustBeFormatted(this string @this, string pattern, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsWellFormatted(pattern))
                Notification.Add(Error.Create(ErrorData.Misformatted, propertyName));
        }

        /// <summary>
        /// Checks if string is a Guid
        /// </summary>
        public static bool IsGuid(this string @this)
        {
            return Guid.TryParse(@this, out _);
        }

        public static void MustBeGuid(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsGuid())
                Notification.Add(Error.Create(ErrorData.IsNotGuid, propertyName));
        }

        /// <summary>
        /// Checks if string has at least X words
        /// </summary>
        public static bool ContainsAtLeastWords(this string @this, int X)
        {
            return @this.Trim().Split(' ').Length >= X;
        }

        public static void MustContainsAtLeastWords(this string @this, int X, [CallerMemberName]string propertyName = "")
        {
            if (!@this.ContainsAtLeastWords(X))
                Notification.Add(Error.Create(ErrorData.HasNotMinimumWords, propertyName, X.ToString()));
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

        public static void MustBeSafe(this string @this, [CallerMemberName]string propertyName = "")
        {
            if (!@this.IsSafe())
                Notification.Add(Error.Create(ErrorData.IsNotSafe, propertyName));
        }
    }
}
