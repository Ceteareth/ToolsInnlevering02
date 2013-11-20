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
        private string _name = "Invincible";
        public override string Name { get { return _name; } set { _name = value; } }
        public bool Value { get; private set; }

        public Invincible()
        {
            Value = false;
        }

        public Invincible(bool isInvincible)
        {
            Value = isInvincible;
        }

        public override object GetValue()
        {
            return Value;
        }
    }
}