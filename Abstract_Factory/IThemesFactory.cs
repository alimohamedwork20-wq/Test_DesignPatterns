using Abstract_Factory1.Buttons;
using Abstract_Factory1.Checkbox;


namespace Abstract_Factory1
{
    public interface IThemesFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
