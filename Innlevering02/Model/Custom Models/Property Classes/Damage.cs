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
    public class Damage : BaseProperty
    {
        private string _name = "Damage";
        public override string Name { get { return _name; } set { _name = value; } }
        public int Value { get; set; }

        public Damage()
        {
            Value = 0;
        }

        public Damage(int damage)
        {
            Value = damage;
        }

        public override object GetValue()
        {
            return Value;
        }
    }
}