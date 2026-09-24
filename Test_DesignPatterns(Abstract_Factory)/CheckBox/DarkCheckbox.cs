using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.CheckBox
{
    public class DarkCheckbox : ICheckbox
    {
        public string Render()
        {
            return "Dark Mode CheckBox";
        }
    }
}
