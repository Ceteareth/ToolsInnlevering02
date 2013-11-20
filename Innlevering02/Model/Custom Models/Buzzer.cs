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
    public class Buzzer : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Buzzer class.
        /// </summary>
        public Buzzer()
        {
            Name = "Buzzer";
            Health = new Health(20);
            Damage = new Damage(5);
            MovementSpeed = new MovementSpeed(1);
            Invincible = new Invincible();
            AddPropertiesToCollection();
        }
    }
}