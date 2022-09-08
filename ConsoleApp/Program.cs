using InteractMenu;

namespace ConsoleApp

{
    class Class1
    {
        private static void Main()
        {
            var menu = new ListMenu();
            var li = new List<string> { "Hey", "Hey1", "Hey2" };
            
            menu.AddListString(li);
            
            var x = menu.Ask("Choix ?");
            Console.WriteLine(x);
        }
    }
}