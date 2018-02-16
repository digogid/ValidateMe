using ValidateMe.Errors;
using System.Collections.Generic;
using System.Linq;

namespace ValidateMe
{
    public static class Notification
    {
        private static List<Error> _errors {
            get
            {
                if (_errors == null)
                    return new List<Error>();
                return _errors;
            }
            set
            {
                _errors = value;
            }
        }

        public static int Count
        {
            get
            {
                return _errors.Count();
            }
        }

        public static bool HasErrors
        {
            get
            {
                return _errors.Any();
            }
        }

        private static IReadOnlyList<string> Get()
        {
            return _errors.Select(e => e.Get()).ToList();
        }

        internal static void Add(Error error)
        {
            _errors.Add(error);
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
            _errors.Clear();
        }
    }
}
