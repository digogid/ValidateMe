using ValidateMe.Errors;
using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ValidateMe
{
    public static class String
    {
        /// <summary>
        /// Checks if string has value
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustHasValue(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = !string.IsNullOrWhiteSpace(@this);

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if string is greater than the specified length
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="length">Specified length</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeGreaterThan(this string @this, int length, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Length > length;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName, length.ToString(), "characters"));

            return valid;
        }

        /// <summary>
        /// Checks if string is smaller than the specified length
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="length">Specified length</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeSmallerThan(this string @this, int length, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Length < length;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName, length.ToString(), "characters"));

            return valid;
        }

        /// <summary>
        /// Checks if string has the exact required length
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="length">Required length</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeExactLength(this string @this, int length, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Length == length;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNotExactLength, propertyName, length.ToString()));

            return valid;
        }

        /// <summary>
        /// Checks if string contains only letters and white space
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeAlphabetic(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Regex.IsMatch(@this, @"^\p{L}+(?: \p{L}+)*$");

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotAlphabetic, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if string contains only numbers
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeNumeric(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Regex.IsMatch(@this, @"^[0-9]+$");

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotNumeric, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if string contains letters and numbers
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeAlphanumeric(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Regex.IsMatch(@this, @"^[a-zA-Z0-9áàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÔÕÖÚÇÑ ]+$");

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotAlphanumeric, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if string contains letters or numbers
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MayBeAlphanumeric(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Regex.IsMatch(@this, @"^[a-zA-Z0-9áàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÔÕÖÚÇÑ ]*$");

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotAlphanumeric, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if string has any special character into it
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustContainSpecialCharacters(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Regex.IsMatch(@this, @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]+", RegexOptions.IgnoreCase);

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNoSpecialCharacters, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if string is a valid email
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeEmail(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Regex.IsMatch(@this, @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z")
                            && Regex.IsMatch(@this, @"^(?=.{1,64}@.{4,64}$)(?=.{6,100}$).*");

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEmail, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if string has value
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool IsWellFormatted(this string @this, string pattern, bool notify = true, [CallerMemberName]string propertyName = "")
        {

            if (string.IsNullOrWhiteSpace(pattern)) return false;

            bool valid = Regex.IsMatch(@this, pattern);

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.Misformatted, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if string is a Guid
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeGuid(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Guid.TryParse(@this, out Guid guid);

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotGuid, propertyName));

            return valid;
        }

        /// <summary>
        /// Checks if string has at least X words
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="X">Minimum words that string must have</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool HasAtLeastWords(this string @this, int X, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Trim().Split(' ').Length >= X;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNotMinimumWords, propertyName, X.ToString()));

            return valid;
        }

        /// <summary>
        /// Checks if value matchs the safety criteria
        /// </summary>
        /// <param name="this">String to be validated</param>
        /// <param name="notify">Tells the validation to create a notification message or not</param>
        /// <param name="propertyName">Name of the property. Default will get CallerMemberName</param>
        /// <returns>Returns true if the validation passes</returns>
        public static bool MustBeSafe(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = !(@this.ToLower().Contains("<")
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

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotSafe, propertyName));

            return valid;
        }
    }
}
