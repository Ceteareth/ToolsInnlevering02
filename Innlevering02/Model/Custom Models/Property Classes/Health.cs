using System;
using GalaSoft.MvvmLight;

namespace Innlevering02.Model.Custom_Models.Property_Classes
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class Health : BaseProperty
    {

        public float Value { get; private set; }

        public Health()
        {
            Name = "Health";
            Value = 0;
        }

        public Health(float health)
        {
            Name = "Health";
            Value = health;
        }

        public override object ReturnValue()
        {
            return Value;
        }
    }
}