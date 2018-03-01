using System;
using System.Runtime.CompilerServices;

namespace ValidateMe.Lib
{
    public static class Validator
    {
        private static Action _validationsDefault;
        private static Action<string> _validations;

        /// <summary>
        /// Set all validations that a single property needs to pass to become valid
        /// </summary>
        public static void SetValidations(Action validations)
        {
            _validationsDefault = validations;
        }

        /// <summary>
        /// Set all validations that a single property needs to pass to become valid
        /// </summary>
        public static void SetValidations(Action<string> validations)
        {
            _validations = validations;
        }

        /// <summary>
        /// Check whether all validations pass
        /// </summary>
        public static bool CheckValidations(this Object obj, [CallerMemberName] string propertyName = "")
        {
            try
            {
                if (_validations != null)
                {
                    string _propertyName = obj.GetDisplayName(propertyName);
                    _validations.Invoke(_propertyName);
                    _validations = null;
                }
                else
                {
                    _validationsDefault.Invoke();
                    _validationsDefault = null;
                }

                return !Notification.HasErrors;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
