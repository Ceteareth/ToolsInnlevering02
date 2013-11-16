using GalaSoft.MvvmLight;

namespace Innlevering02.Model.Custom_Models
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class BaseEntity : ViewModelBase
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public float MovementSpeed { get; set; }
        public bool Invincible { get; set; }

        /// <summary>
        /// Initializes a new instance of the BaseEntity class.
        /// </summary>
        public BaseEntity()
        {
            Name = "BaseEntity";
            Health = 0;
            Damage = 0;
            MovementSpeed = 0;
            Invincible = false;
        }
    }
}