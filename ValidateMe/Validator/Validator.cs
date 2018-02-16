using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Validator
    {
        private static Action<string> _validations;

        public static void SetValidations(Action<string> validations)
        {
            _validations = validations;
        }

        public static bool CheckValidations(this Object obj, [CallerMemberName] string propertyName = "")
        {
            string _propertyName = obj.GetDisplayName(propertyName);
            _validations.Invoke(_propertyName);

            return Notification.HasErrors;
        }
    }
}
