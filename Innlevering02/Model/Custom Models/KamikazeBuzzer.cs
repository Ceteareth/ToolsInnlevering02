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
    public class KamikazeBuzzer : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the KamikazeBuzzer class.
        /// </summary>
        public KamikazeBuzzer()
        {
            Name = "KamikazeBuzzer";
            Health = new Health(1);
            Damage = new Damage(20);
            MovementSpeed = new MovementSpeed(10);
            Invincible = new Invincible();
            AddPropertiesToCollection();
        }
    }
}