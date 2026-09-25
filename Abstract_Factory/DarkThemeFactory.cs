using Abstract_Factory1.Buttons;
using Abstract_Factory1.Checkbox;


namespace Abstract_Factory1
{
    public class DarkThemeFactory : IThemesFactory
    {
        public IButton CreateButton()
        {
            return new DarkModeButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new DarkModeCheckbox();
        }
    }
}
