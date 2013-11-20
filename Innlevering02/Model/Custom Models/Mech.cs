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
    public class Mech : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Mech class.
        /// </summary>
        public Mech()
        {
            Name = "Mech";
            Health = new Health(200);
            Damage = new Damage(20);
            MovementSpeed = new MovementSpeed(0.5f);
            Invincible = new Invincible();
            AddPropertiesToCollection();
        }
    }
}