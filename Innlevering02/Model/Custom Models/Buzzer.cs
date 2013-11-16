using GalaSoft.MvvmLight;
using Innlevering02.Model.Custom_Models;

namespace Innlevering02.Model
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class Buzzer : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Buzzer class.
        /// </summary>
        public Buzzer()
        {
            Name = "Buzzer";
            Health = 20;
            Damage = 10;
            MovementSpeed = 0.5f;
        }
    }
}