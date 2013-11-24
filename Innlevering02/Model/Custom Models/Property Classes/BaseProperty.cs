using System;
using GalaSoft.MvvmLight;

namespace Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes
{
    // Default property class which can handle different values of single type.
    // Used for displaying and serializing.
    public sealed class BaseProperty
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public BaseProperty()
        {
            Name = "Unknown";
            Value = null;
        }

        public BaseProperty(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}