using ValidateMe.Errors;
using System.Collections.Generic;
using System.Linq;

namespace ValidateMe
{
    public static class Notification
    {
        private static List<Error> _errors { get; set; }

        public static int Count
        {
            get
            {
                if (_errors == null) return 0;
                return _errors.Count();
            }
        }

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

        public static void Clear()
        {
            _errors = new List<Error>();
        }
    }
}
