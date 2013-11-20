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
    public class Spider : BaseEntity
    {
        public Creepy Creepy { get; set; }

        public Spider()
        {
            Name = "Spider";
            Health = new Health(10);
            Damage = new Damage(5);
            MovementSpeed = new MovementSpeed(5);
            Invincible = new Invincible();
            Creepy = new Creepy(true);

            AddPropertiesToCollection();
        }

        public new void AddPropertiesToCollection()
        {
            base.AddPropertiesToCollection();
            PropertyCollection.Add(Creepy);
        }
    }
}