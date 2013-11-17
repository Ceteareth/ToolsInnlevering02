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
    public class MovementSpeed : BaseProperty
    {
        public float Value { get; private set; }

        public MovementSpeed()
        {
            Name = "Movement speed";
            Value = 0.0f;
        }

        public MovementSpeed(float movementSpeed)
        {
            Name = "Movement speed";
            Value = movementSpeed;
        }

        public override object ReturnValue()
        {
            return Value;
        }
    }
}