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
    public class Mech : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Mech class.
        /// </summary>
        public Mech()
        {
            Name = "Mech";
            Health = 100;
            Damage = 15;
            MovementSpeed = 0.5f;
        }
    }
}