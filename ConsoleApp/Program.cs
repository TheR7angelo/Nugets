using InteractMenu;


namespace ConsoleApp

{
    internal static class Class1
    {
        private static void Main()
        {
            var t = new InteractMenu.InteractMenu();
            var li = new List<string>() { "Hey", "Hey1" };
            // for (var i = 1; i < 10; i++)
            // {
            //     t.AddString($"Hey_{i}");
            // }
            //t.AddListString(li);

            var y = t.GetList();
            foreach (var z in y)
            {
                Console.WriteLine(z);
            }
        }
    }
}