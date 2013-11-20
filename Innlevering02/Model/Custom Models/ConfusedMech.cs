using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes;

namespace Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models
{
    class ConfusedMech : BaseEntity
    {
        public Confused Confused { get; set; }

        public ConfusedMech()
        {
            Name = "Confused Mech";
            Health = new Health(200);
            Damage = new Damage(20);
            MovementSpeed = new MovementSpeed(0.5f);
            Invincible = new Invincible();
            Confused = new Confused(true);
            AddPropertiesToCollection();
        }

        public new void AddPropertiesToCollection()
        {
            base.AddPropertiesToCollection();
            PropertyCollection.Add(Confused);
        }
    }
}
