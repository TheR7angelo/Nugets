namespace InteractMenu
{
    public class InteractMenu
    {
        private List<string> _listeOption = new();

        public void AddString(string str)
        {
            _listeOption.Add(str);
        }

        public void AddListString(IEnumerable<string> listStr)
        {
            _listeOption.AddRange(listStr);
        }

        public List<string> GetList()
        {
            return _listeOption;
        }
    }
}