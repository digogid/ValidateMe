using ValidateMe.Errors;
using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ValidateMe
{
    public static class String
    {
        public static bool MustHasValue(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = !string.IsNullOrWhiteSpace(@this);

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNoValue, propertyName));

            return valid;
        }

        public static bool MustBeGreaterThan(this string @this, int length, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Length > length;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotGreaterThan, propertyName, length.ToString(), "characters"));

            return valid;
        }

        public static bool MustBeSmallerThan(this string @this, int length, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Length < length;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotSmallerThan, propertyName, length.ToString(), "characters"));

            return valid;
        }

        public static bool MustBeExactLength(this string @this, int length, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Length == length;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNotExactLength, propertyName, length.ToString()));

            return valid;
        }

        public static bool MustBeAlphabetic(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Regex.IsMatch(@this, @"^\p{L}+(?: \p{L}+)*$");

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotAlphabetic, propertyName));

            return valid;
        }

        public static bool MustBeNumeric(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Regex.IsMatch(@this, @"^[0-9]+$");

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotNumeric, propertyName));

            return valid;
        }

        public static bool MustBeAlphanumeric(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Regex.IsMatch(@this, @"^[a-zA-Z0-9áàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÔÕÖÚÇÑ ]+$");

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotAlphanumeric, propertyName));

            return valid;
        }

        public static bool MustContainSpecialCharacters(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Regex.IsMatch(@this, @"[!@#$%^&*()_+\-=\[\]{};':""\\|,.<>\/?]+", RegexOptions.IgnoreCase);

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNoSpecialCharacters, propertyName));

            return valid;
        }

        public static bool MustBeEmail(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Regex.IsMatch(@this, @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z")
                            && Regex.IsMatch(@this, @"^(?=.{1,64}@.{4,64}$)(?=.{6,100}$).*");

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotEmail, propertyName));

            return valid;
        }

        public static bool IsWellFormatted(this string @this, string pattern, bool notify = true, [CallerMemberName]string propertyName = "")
        {

            if (string.IsNullOrWhiteSpace(pattern)) return false;

            bool valid = Regex.IsMatch(@this, pattern);

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.Misformatted, propertyName));

            return valid;
        }

        public static bool MustBeGuid(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = Guid.TryParse(@this, out Guid guid);

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.IsNotGuid, propertyName));

            return valid;
        }

        public static bool HasAtLeastWords(this string @this, int wordsCount, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = @this.Trim().Split(' ').Length >= wordsCount;

            if (!valid && notify)
                Notification.Add(Error.Create(ErrorData.HasNotMinimumWords, propertyName, wordsCount.ToString()));

            return valid;
        }

        public static bool MustBeSafe(this string @this, bool notify = true, [CallerMemberName]string propertyName = "")
        {
            bool valid = !(@this.ToLower().Contains("<")
                        || @this.ToLower().Contains(">")
                        || @this.ToLower().Contains("script")
                        || @this.ToLower().Contains("function")
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
