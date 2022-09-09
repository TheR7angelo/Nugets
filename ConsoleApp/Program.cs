using System.Drawing;
using InteractMenu;
using InteractMenu.Utils.Colors;

namespace ConsoleApp

{
    class Class1
    {
        private static void Main()
        {
            var menu = new ListMenu();
            var li = new List<string> { "Choix 1", "Choix 2", "Choix 3" };
            
            menu.SetColors(Color.Fuchsia, ColorsKey.Good);

            var c = Color.FromArgb(255, 255, 255);
            
            menu.AddListString(li);
            
            var x = menu.Ask("Choix ?");
            Console.WriteLine(x);
        }

        public static ColorsKey ColorsKey { get; }
    }
}