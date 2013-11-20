using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes;

namespace Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models
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
        public Health Health { get; set; }
        public Damage Damage { get; set; }
        public MovementSpeed MovementSpeed { get; set; }
        public Invincible Invincible { get; set; }
        public ObservableCollection<BaseProperty> PropertyCollection; 

        /// <summary>
        /// Initializes a new instance of the BaseEntity class.
        /// </summary>
        public BaseEntity()
        {
            Name = "BaseEntity";
            Health = new Health();
            Damage = new Damage();
            MovementSpeed = new MovementSpeed();
            Invincible = new Invincible();
            PropertyCollection = new ObservableCollection<BaseProperty>();
        }

        protected void AddPropertiesToCollection()
        {
            PropertyCollection.Add(Health);
            PropertyCollection.Add(Damage);
            PropertyCollection.Add(MovementSpeed);
            PropertyCollection.Add(Invincible);
        }
    }
}