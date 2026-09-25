using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory1.Checkbox
{
    public class DarkModeCheckbox : ICheckbox
    {
        public string Render()
        {
            return "DarkMode Checkbox";
        }
    }
}
