
namespace InteractMenu.Utils.Console;

public class Clear
{
    public static void ClearConsoleLine(int line)
    {
        System.Console.SetCursorPosition(0, line);
        System.Console.SetCursorPosition(0, System.Console.CursorTop);
        System.Console.Write(new string(' ', System.Console.WindowWidth));
        System.Console.SetCursorPosition(0, line);
    }
}