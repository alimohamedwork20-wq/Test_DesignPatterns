using Abstract_Factory.CheckBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.CheckBox
{
    public class LightCheckbox : ICheckbox
    {
        public string Render()
        {
            return "Light Mode CheckBox";
        }
    }
}
