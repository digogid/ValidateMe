namespace ValidateMe.Errors
{
    public class Error
    {
        internal readonly string Message;
        internal readonly int Code;
        internal static string File { get; private set; }

        private Error(string message, int code)
        {
            Message = message;
            Code = code;
        }

        public static void SetPath(string file)
        {
            File = file;
        }

        internal static Error Create(ErrorData emessage, params string[] param)
        {
            string message = string.Format(emessage.ToString(), param);
            return new Error(message, emessage.Code);
        }

        internal string Get()
        {
            return $"{Code}: {Message}";
        }
    }
}
