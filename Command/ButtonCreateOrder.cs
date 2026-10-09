using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ButtonCreateOrder : IButton
    {
        private readonly ICommand _command;
        public ButtonCreateOrder(ICommand command)
        {
            _command = command;
        }
        public void Click()
        {
            _command.Execute();
        }
    }
}
