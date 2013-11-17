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
    public class Invincible : BaseProperty
    {
        public bool Value { get; private set; }

        public Invincible()
        {
            Name = "Invincible";
            Value = false;
        }

        public Invincible(bool isInvincible)
        {
            Name = "Invincible";
            Value = isInvincible;
        }

        public override object ReturnValue()
        {
            return Value;
        }
    }
}