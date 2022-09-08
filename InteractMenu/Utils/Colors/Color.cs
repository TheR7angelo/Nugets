using System.Drawing;
using Pastel;

namespace InteractMenu;

public static class Colors
{
    public static string Crimson(this string str)
    {
        return str.Pastel(Color.FromKnownColor(KnownColor.Crimson));
    }
    public static string ForestGreen(this string str)
    {
        return str.Pastel(Color.FromKnownColor(KnownColor.ForestGreen));
    }
}