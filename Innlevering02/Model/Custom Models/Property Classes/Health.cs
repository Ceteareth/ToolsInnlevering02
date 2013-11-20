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
    public class Health : BaseProperty
    {
        private string _name = "Health";
        public override string Name { get { return _name; } set { _name = value; } }
        public float Value { get; set; }

        public Health()
        {
            Value = 0;
        }

        public Health(float health)
        {
            Value = health;
        }

        public override object GetValue()
        {
            return Value;
        }
    }
}