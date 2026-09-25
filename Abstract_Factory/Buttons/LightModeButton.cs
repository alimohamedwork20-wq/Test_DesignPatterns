using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory1.Buttons
{
    public class LightModeButton : IButton
    {
        public string Render()
        {
            return "LightMode Button";
        }
    }
}
