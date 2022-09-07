namespace InteractMenu
{
    public class InteractMenu
    {
        private List<string> _listOptionsStrings = new();
        private List<string> _listOptionsSelected = new();
        private string _mode = "liste";

        public void AddString(string str)
        {
            _listOptionsStrings.Add(str);
        }

        public void AddListString(IEnumerable<string> listStr)
        {
            _listOptionsStrings.AddRange(listStr);
        }

        public string Ask(ConsoleKey exit = ConsoleKey.X)
        {
            var index = 0;
            ConsoleKeyInfo keyInfo;
            WriteMenu(index);
            do
            {
                keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        index = AddIndex(index, "+");
                        WriteMenu(index);
                        break;
                    case ConsoleKey.UpArrow:
                        index = AddIndex(index, "-");
                        WriteMenu(index);
                        break;
                    case ConsoleKey.Enter:
                        return _listOptionsStrings[index];
                }
                
            } while (keyInfo.Key != exit);

            return string.Empty;
        }

        private void WriteMenu(int index)
        {
            Console.Clear();
            foreach (var opt in _listOptionsStrings.Select((value, i) => new { i, value }))
            {
                var carac = opt.i.Equals(index) ? ">" : " ";
                Console.WriteLine($"{carac} {opt.value}");
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