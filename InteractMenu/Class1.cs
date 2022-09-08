using System.Diagnostics.SymbolStore;

namespace InteractMenu
{
    public class ListMenu
    {
        private List<string> _listOptionsStrings = new();
        // private List<string> _listOptionsSelected = new();
        // private string _mode = "liste";

        public void AddString(string str)
        {
            _listOptionsStrings.Add(str);
        }

        public void AddListString(IEnumerable<string> listStr)
        {
            _listOptionsStrings.AddRange(listStr);
        }

        public string Ask(string title, ConsoleKey exit = ConsoleKey.X)
        {
            var index = 0;
            ConsoleKeyInfo keyInfo;
            Console.WriteLine(title);
            WriteMenu(index);
            do
            {
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        index = AddIndex(index, "+");
                        break;
                    case ConsoleKey.UpArrow:
                        index = AddIndex(index, "-");
                        break;
                    case ConsoleKey.Enter:
                        return _listOptionsStrings[index];
                }
                WriteMenu(index, true);
                
            } while (keyInfo.Key != exit);

            return string.Empty;
        }

        private void WriteMenu(int index, bool init = false)
        {
            if (init)
            {
                var lastLine = Console.CursorTop;
                for (var i = Console.CursorTop; i >= lastLine - _listOptionsStrings.Count  ; i--)
                {
                    Utils.Console.Clear.ClearConsoleLine(i);
                }
            }

            foreach (var opt in _listOptionsStrings.Select((value, i) => new { i, value }))
            {
                var str = opt.i.Equals(index) ? $"> {opt.value}".ForestGreen() : $" {opt.value}".Crimson();
                Console.WriteLine($"  {str}");
            }
        }

        private int AddIndex(int index, string mode)
        {
            index = mode.Equals("+") ? index + 1 : index - 1;
            if (_listOptionsStrings.Count - 1 < index) return _listOptionsStrings.Count - 1;
            return index < 0 ? 0 : index;
        }
    }
}