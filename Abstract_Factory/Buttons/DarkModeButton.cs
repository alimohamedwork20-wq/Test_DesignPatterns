using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory1.Buttons
{
    public class DarkModeButton : IButton
    {
        public string Render()
        {
            return "DarkMode Button";
        }
    }
}
