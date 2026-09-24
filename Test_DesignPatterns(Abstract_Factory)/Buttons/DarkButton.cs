using Abstract_Factory.CheckBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Buttons
{
    public class DarkButton : ICheckbox
    {
        public string Render()
        {
            return "Dark Mode";
        }
    }
}
