using ValidateMe.Errors;
using System.Collections.Generic;
using System.Linq;

namespace ValidateMe
{
    public static class Notification
    {
        private static List<Error> _errors;

        private static void Create()
        {
            _errors = new List<Error>();
        }

        private static IReadOnlyList<string> Get()
        {
            return _errors.Select(e => e.Get()).ToList();
        }

        internal static void Add(Error error)
        {
            if (_errors == null)
                Create();

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

        public static int Count()
        {
            return _errors.Count;
        }

        public static bool HasErrors()
        {
            return _errors.Any();
        }

        public static void Clear()
        {
            _errors.Clear();
        }
    }
}
