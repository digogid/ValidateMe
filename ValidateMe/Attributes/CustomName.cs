using System;

namespace ValidateMe.Lib.Attributes
{
    /// <summary>
    /// Sets a custom property's name. Used to return a user-friendly name
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class CustomNameAttribute : Attribute
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }

        public CustomNameAttribute(string name)
        {
            _name = name;
        }
    }
}
