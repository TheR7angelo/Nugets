using System.Drawing;
using InteractMenu;
using InteractMenu.Utils;

namespace ConsoleApp

{
    class Class1
    {
        private static void Main()
        {
            var menu = new ListMenu();
            var li = new List<string> { "Choix 1", "Choix 2", "Choix 3" };

            menu.SetColors(Color.Fuchsia, Strucs.Good);
            
            menu.AddListString(li);
            
            var x = menu.Ask("Choix ?");
            Console.WriteLine(x);
        }
    }
}