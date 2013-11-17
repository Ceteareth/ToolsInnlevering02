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
    public class Damage : BaseProperty
    {
        public int Value { get; private set; }

        public Damage()
        {
            Name = "Damage";
            Value = 0;
        }

        public Damage(int damage)
        {
            Name = "Damage";
            Value = damage;
        }

        public override object ReturnValue()
        {
            return Value;
        }
    }
}