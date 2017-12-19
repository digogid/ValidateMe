namespace ValidateMe.Errors
{
    public class Error
    {
        private readonly string _message;
        private readonly int _code;
        internal static string _file { get; private set; }

        private Error(string message, int code)
        {
            _message = message;
            _code = code;
        }

        public static void SetPath(string file)
        {
            _file = file;
        }

        internal static Error Create(ErrorData emessage, params string[] param)
        {
            string message = string.Format(emessage.ToString(), param);
            return new Error(message, emessage.Code);
        }

        internal string Get()
        {
            return $"{_code}: {_message}";
        }
    }
}
