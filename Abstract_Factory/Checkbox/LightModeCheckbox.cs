using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory1.Checkbox
{
    public class LightModeCheckbox : ICheckbox
    {
        public string Render()
        {
            return "LightMode Checkbox";
        }
    }
}
