using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innlevering02.Model.Custom_Models.Custom_Models.Custom_Models.Property_Classes
{
    public class Confused : BaseProperty
    {
        private string _name = "Confused";
        public override string Name { get { return _name; } set { _name = value; } }
        public bool Value { get; set; }

        public Confused()
        {
            Value = false;
        }

        public Confused(bool isConfused)
        {
            Value = isConfused;
        }

        public override object GetValue()
        {
            return Value;
        }
    }
}
