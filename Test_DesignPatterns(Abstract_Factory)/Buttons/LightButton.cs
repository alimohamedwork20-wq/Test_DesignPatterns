using Abstract_Factory.Buttons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Buttons
{
    public class LightButton : ICheckBox
    {
        public string Render()
        {
            return "Light Mode";
        }
    }
}
