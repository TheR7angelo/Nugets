using InteractMenu;


namespace ConsoleApp

{
    internal static class Class1
    {
        private static void Main()
        {
            var t = new InteractMenu.InteractMenu();
            var li = new List<string> { "Hey", "Hey1" };
            
            t.AddListString(li);
            
            var x = t.Ask();
            Console.WriteLine(x);
        }
    }
}