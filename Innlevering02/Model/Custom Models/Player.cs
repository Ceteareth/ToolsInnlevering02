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
    public class Player : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Player class.
        /// </summary>
        public Player()
        {
            Name = "Player";
            Health = 100;
            Damage = 10;
            MovementSpeed = 1.5f;
        }
    }
}