using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes
{
    public class Creepy : BaseProperty
    {
        private string _name = "Creepy";
        public override string Name { get { return _name; } set { _name = value; } }
        public bool Value { get; set; }

        public Creepy()
        {
            Value = false;
        }

        public Creepy(bool isCreepy)
        {
            Value = isCreepy;
        }

        public override object GetValue()
        {
            return Value;
        }
    }
}
