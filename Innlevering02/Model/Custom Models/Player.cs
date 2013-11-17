using GalaSoft.MvvmLight;
using Innlevering02.Model.Custom_Models;
using Innlevering02.Model.Custom_Models.Property_Classes;

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
            Health = new Health(150);
            Damage = new Damage(20);
            MovementSpeed = new MovementSpeed(10);
            Invincible = new Invincible(true);
            AddPropertiesToCollection();
        }
    }
}