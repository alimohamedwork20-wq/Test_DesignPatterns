using Abstract_Factory1.Buttons;
using Abstract_Factory1.Checkbox;

namespace Abstract_Factory1
{
    public class LightThemeFactory : IThemesFactory
    {
        public IButton CreateButton()
        {
            return new LightModeButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new LightModeCheckbox();
        }
    }
}
