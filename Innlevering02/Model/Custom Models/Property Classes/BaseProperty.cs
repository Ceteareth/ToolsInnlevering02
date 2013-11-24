using System;
using GalaSoft.MvvmLight;

namespace Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
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