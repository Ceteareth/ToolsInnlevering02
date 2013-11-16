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
    public class KamikazeBuzzer : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the KamikazeBuzzer class.
        /// </summary>
        public KamikazeBuzzer()
        {
            Name = "KamikazeBuzzer";
            Health = 10;
            Damage = 20;
            MovementSpeed = 0.5f;
        }
    }
}