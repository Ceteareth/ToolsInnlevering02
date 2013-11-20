using GalaSoft.MvvmLight;
using Innlevering02.Model.Custom_Models.Custom_Models;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes;

namespace Innlevering02.Model.Custom_Models
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class Player : BaseEntity
    {
        public Player()
        {
            Name = "Player";
            Health = new Health(500);
            Damage = new Damage(20);
            MovementSpeed = new MovementSpeed(20);
            Invincible = new Invincible(true);
            AddPropertiesToCollection();
        }
    }
}