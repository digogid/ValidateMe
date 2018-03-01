using ValidateMe.Lib.Errors;
using System.Collections.Generic;
using System.Linq;

namespace ValidateMe.Lib
{
    public static class Notification
    {
        private static List<Error> _errors { get; set; }

        /// <summary>
        /// How many errors have occurred
        /// </summary>
        public static int Count
        {
            get
            {
                if (_errors == null) return 0;
                return _errors.Count();
            }
        }

        /// <summary>
        /// Checks if any error occurred
        /// </summary>
        public static bool HasErrors
        {
            get
            {
                if (_errors == null) return false;
                return _errors.Any();
            }
        }

        private static IReadOnlyList<string> Get()
        {
            if (_errors == null) return null;
            return _errors.Select(e => e.Get()).ToList();
        }

        internal static void Add(Error error)
        {
            if (_errors == null)
                _errors = new List<Error>();

            if (!HasSpecificError(error))
                _errors.Add(error);
        }

        internal static bool HasSpecificError(Error error)
        {
            if (_errors == null)
                return false;
            return _errors.Any(x => x.Code == error.Code && x.Message == error.Message);
        }

        /// <summary>
        /// Return a list of string for each error that has occurred
        /// </summary>
        public static IReadOnlyList<string> Get(bool clearAfterGet = true)
        {
            if (!clearAfterGet)
            {
                return Get();
            }

            var copyNotifications = Get();
            Clear();

            return copyNotifications;
        }

        /// <summary>
        /// Remove all error messages
        /// </summary>
        public static void Clear()
        {
            _errors = new List<Error>();
        }
    }
}
