using System.Drawing;

namespace InteractMenu.Utils;

public partial class Strucs
{ 
    public class ColorsListAnswer : ReflectableClass
    {
        public Color Bad;
        public Color Good;

        public ColorsListAnswer()
        {
            Bad = Color.Crimson;
            Good = Color.ForestGreen;
        }
    }
}