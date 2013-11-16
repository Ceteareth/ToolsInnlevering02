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
    public class Spider : BaseEntity
    {
        /// <summary>
        /// Initializes a new instance of the Spider class.
        /// </summary>
        public Spider()
        {
            Name = "Spider";
            Health = 15;
            Damage = 5;
            MovementSpeed = 2.5f;
        }
    }
}