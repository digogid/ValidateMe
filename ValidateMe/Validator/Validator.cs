using System;
using System.Runtime.CompilerServices;

namespace ValidateMe
{
    public static class Validator
    {
        private static Action<string> _validations;
        private static Action _validationsDefault;

        /// <summary>
        /// Set all validations that a single property needs to pass to become valid
        /// </summary>
        public static void SetValidations(Action<string> validations)
        {
            _validations = validations;
        }

        public static void SetValidations(Action validations)
        {
            _validationsDefault = validations;
        }

        /// <summary>
        /// Check whether all validations pass
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static bool CheckValidations(this Object obj, [CallerMemberName] string propertyName = "")
        {
            try
            {
                if (_validations != null)
                {
                    string _propertyName = obj.GetDisplayName(propertyName);
                    _validations.Invoke(_propertyName);
                }
                else
                {
                    _validationsDefault.Invoke();
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
