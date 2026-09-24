using Abstract_Factory;
using Abstract_Factory.CheckBox;
using Abstract_Factory.Buttons;
using Factory.CheckBox;
using Abstract_Factory_Buttons;

namespace Abstract_Factory.Buttons
{
    internal class LightGUIFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new LightButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LightCheckbox();
        }
    }
}
