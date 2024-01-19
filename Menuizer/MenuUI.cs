namespace Menuizer;

public class MenuUI
{
    const int MenuWidth = 30;

    private static string[]? _items { get; set; }
    private static int _selectedOption { get; set; }

    static MenuUI()
    {
        Console.CursorVisible = false;
    }

    public static int SelectedOption { get => _selectedOption; }
    public static string? HeaderMessage { get; set; }
    public static string? Message { get; set; }

    public static void DrawMenu(params string[] items)
    {
        _items = items;
        _selectedOption = 0;

        do
        {
            Console.Clear();

            if (!string.IsNullOrEmpty(HeaderMessage))
                MenuMessage(HeaderMessage, MenuStyle.Header);

            if (!string.IsNullOrEmpty(Message))
                MenuMessage(Message, MenuStyle.Normal);

            for (int i = 0; i < _items?.Length; i++)
            {
                if (i == _selectedOption)
                    (Console.BackgroundColor, Console.ForegroundColor) = (ConsoleColor.White, ConsoleColor.Black);

                Console.WriteLine($"{_items[i],MenuWidth}  ");

                Console.ResetColor();
            }

        } while (!HandleInput());
    }

    private static bool HandleInput()
    {
        int endIndex = _items?.Length - 1 ?? 0;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.UpArrow when _selectedOption > 0: _selectedOption--; break;
            case ConsoleKey.DownArrow when _selectedOption < endIndex: _selectedOption++; break;
            case ConsoleKey.UpArrow when _selectedOption == 0: _selectedOption = endIndex; break;
            case ConsoleKey.DownArrow when _selectedOption == endIndex: _selectedOption = 0; break;
            case ConsoleKey.Enter: Menu.Reset(); return true;
            default: HandleInput(); break;
        }

        return false;
    }

    private static void MenuMessage(string message, MenuStyle style)
    {
        int width = MenuWidth > message.Length - 1 ? MenuWidth + 2 : message.Length + 2;

        if (style == MenuStyle.Header)
        {
            message = " " + message + " ";
            message = message.PadLeft(message.Length + (width - message.Length) / 2, '-');
            message = message.PadRight(width, '-');
        }

        Console.WriteLine($"{message,MenuWidth}");

        if (style == MenuStyle.Normal)
            Console.WriteLine(new string('-', width));
    }
}
