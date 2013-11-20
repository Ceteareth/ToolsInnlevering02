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
    public class MovementSpeed : BaseProperty
    {
        private string _name = "Movement speed";
        public override string Name { get { return _name; } set { _name = value; } }
        public float Value { get; private set; }

        public MovementSpeed()
        {
            Value = 0.0f;
        }

        public MovementSpeed(float movementSpeed)
        {
            Value = movementSpeed;
        }

        public override object GetValue()
        {
            return Value;
        }
    }
}