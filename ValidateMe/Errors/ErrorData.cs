using System.IO;
using System.Linq;

namespace ValidateMe.Lib.Errors
{
    internal class ErrorData
    {

        private readonly string _message;
        private readonly int _code;
        public int Code
        {
            get
            {
                return _code;
            }
        }

        // General purpose error messages
        public static readonly ErrorData HasNoValue = new ErrorData(1001, GetMessage("HasNoValue"));
        public static readonly ErrorData IsNotGreaterThan = new ErrorData(1002, GetMessage("IsNotGreaterThan"));
        public static readonly ErrorData IsNotSmallerThan = new ErrorData(1003, GetMessage("IsNotSmallerThan"));

        // String error messages
        public static readonly ErrorData Misformatted = new ErrorData(1101, GetMessage("Misformatted"));
        public static readonly ErrorData IsNotAlphabetic = new ErrorData(1102, GetMessage("IsNotAlphabetic"));
        public static readonly ErrorData IsNotNumeric = new ErrorData(1103, GetMessage("IsNotNumeric"));
        public static readonly ErrorData IsNotAlphanumeric = new ErrorData(1104, GetMessage("IsNotAlphanumeric"));
        public static readonly ErrorData IsNotEmail = new ErrorData(1105, GetMessage("IsNotEmail"));
        public static readonly ErrorData IsNotGuid = new ErrorData(1106, GetMessage("IsNotGuid"));
        public static readonly ErrorData IsNotSafe = new ErrorData(1107, GetMessage("IsNotSafe"));
        public static readonly ErrorData HasNotExactLength = new ErrorData(1108, GetMessage("HasNotExactLength"));
        public static readonly ErrorData HasNoSpecialCharacters = new ErrorData(1109, GetMessage("HasNoSpecialCharacters"));
        public static readonly ErrorData HasNotMinimumWords = new ErrorData(1110, GetMessage("HasNotMinimumWords"));

        // DateTime error messages
        public static readonly ErrorData IsNotInThePast = new ErrorData(1201, GetMessage("IsNotInPast"));
        public static readonly ErrorData IsNotInTheFuture = new ErrorData(1202, GetMessage("IsNotInFuture"));
        public static readonly ErrorData IsNotToday = new ErrorData(1203, GetMessage("IsNotToday"));
        public static readonly ErrorData IsNotYesterday = new ErrorData(1204, GetMessage("IsNotYesterday"));
        public static readonly ErrorData IsNotTomorrow = new ErrorData(1205, GetMessage("IsNotTomorrow"));
        public static readonly ErrorData IsNotInLast365Days = new ErrorData(1206, GetMessage("IsNotInLast365Days"));
        public static readonly ErrorData IsNotInNext365Days = new ErrorData(1207, GetMessage("IsNotInNext365Days"));
        public static readonly ErrorData IsNotDawn = new ErrorData(1208, GetMessage("IsNotDawn"));
        public static readonly ErrorData IsNotMorning = new ErrorData(1209, GetMessage("IsNotMorning"));
        public static readonly ErrorData IsNotAfternoon = new ErrorData(1210, GetMessage("IsNotAfternoon"));
        public static readonly ErrorData IsNotEvening = new ErrorData(1211, GetMessage("IsNotEvening"));
        public static readonly ErrorData IsNotLeapYear = new ErrorData(1212, GetMessage("IsNotLeapYear"));
        public static readonly ErrorData IsNotMoreRecentThan = new ErrorData(1213, GetMessage("IsNotMoreRecentThan"));
        public static readonly ErrorData IsNotOlderThan = new ErrorData(1214, GetMessage("IsNotOlderThan"));
        public static readonly ErrorData IsNotWeekday = new ErrorData(1215, GetMessage("IsNotWeekday"));
        public static readonly ErrorData IsNotWeekend = new ErrorData(1216, GetMessage("IsNotWeekend"));
        public static readonly ErrorData HasNotEnoughYears = new ErrorData(1217, GetMessage("HasNotEnoughYears"));
        public static readonly ErrorData HasMoreThanNeededYears = new ErrorData(1218, GetMessage("HasMoreThanNeededYears"));
        public static readonly ErrorData HasNotEnoughDays = new ErrorData(1219, GetMessage("HasNotEnoughDays"));
        public static readonly ErrorData HasMoreThanNeededDays = new ErrorData(1220, GetMessage("HasMoreThanNeededDays"));

        // Numeric error messages
        public static readonly ErrorData IsNotPositive = new ErrorData(1301, GetMessage("IsNotPositive"));
        public static readonly ErrorData IsNotNegative = new ErrorData(1302, GetMessage("IsNotNegative"));
        public static readonly ErrorData IsNotZero = new ErrorData(1303, GetMessage("IsNotZero"));
        public static readonly ErrorData IsNotEven = new ErrorData(1304, GetMessage("IsNotEven"));
        public static readonly ErrorData IsNotOdd = new ErrorData(1305, GetMessage("IsNotOdd"));
        public static readonly ErrorData IsNotEqual = new ErrorData(1306, GetMessage("IsNotEqual"));
        public static readonly ErrorData IsNotSmallerOrEqualTo = new ErrorData(1307, GetMessage("IsNotSmallerOrEqualTo"));
        public static readonly ErrorData IsNotGreaterOrEqualTo = new ErrorData(1308, GetMessage("IsNotGreaterOrEqualTo"));
        public static readonly ErrorData IsNotDifferentFrom = new ErrorData(1309, GetMessage("IsNotDifferentFrom"));

        // TimeSpan error messages
        public static readonly ErrorData IsNotInLast24Hours = new ErrorData(1401, GetMessage("IsNotInLast24Hours"));
        public static readonly ErrorData IsNotInNext24Hours = new ErrorData(1402, GetMessage("IsNotInNext24Hours"));


        private ErrorData(int code, string message)
        {
            _message = message;
            _code = code;
        }

        private static string GetMessage(string messageTitle)
        {
            if (Error.File == null)
                return Resources.Resources.ResourceManager.GetString(messageTitle);

            var lines = File.ReadLines(Error.File);
            foreach (var line in lines.Where(l => l.Contains(":")))
            {
                string title = line.Split(':')[0].Replace("\"","").Trim();
                if (title == messageTitle)
                {
                    return line.Split(':')[1].Replace("\"", "").Trim();
                }
            }
            return Resources.Resources.ResourceManager.GetString(messageTitle);
        }

        public override string ToString()
        {
            return _message;
        }
    }
}
