using System.Reflection;

namespace InteractMenu.Utils;

public partial class Strucs
{
    public class ReflectableClass
    {
        public object this[string? key]
        {
            get => GetType().GetField(key, BindingFlags.Instance | BindingFlags.Public)!.GetValue(this)!;
            set => GetType().GetField(key, BindingFlags.Instance | BindingFlags.Public)!.SetValue(this, value);
        }
    }
}