using System;

namespace ValidateMe.Attributes
{
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
