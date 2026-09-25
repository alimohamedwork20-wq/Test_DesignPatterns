using Abstract_Factory1.Buttons;
using Abstract_Factory1.Checkbox;

namespace Abstract_Factory1
{
    class Program
    {
        public static void Main(string[] strings)
        {
            var them = new LightThemeFactory();
            var button = them.CreateButton();
            var checkbox = them.CreateCheckbox();
            Console.WriteLine(button.Render());
            Console.WriteLine(checkbox.Render());
        }
    }
}