namespace Menuizer;

public class MenuUI
{
    private static string[]? _items { get; set; }
    private static int _selectedOption { get; set; }

    static MenuUI()
    {
        Console.CursorVisible = false;
    }

    public static void DrawMenu(params string[] items)
    {
        _items = items;

        while (true)
        {
            Console.Clear();

            for (int i = 0; i < _items?.Length; i++)
            {
                if (i == _selectedOption)
                    (Console.BackgroundColor, Console.ForegroundColor) = (ConsoleColor.White, ConsoleColor.Black);

                Console.WriteLine($"{_items[i],30}  ");

                Console.ResetColor();
            }

            HandleInput();
        }
    }

    public static void HandleInput()
    {
        int endIndex = _items?.Length - 1 ?? 0;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.UpArrow when _selectedOption > 0: _selectedOption--; break;
            case ConsoleKey.DownArrow when _selectedOption < endIndex: _selectedOption++; break;
            case ConsoleKey.UpArrow when _selectedOption == 0: _selectedOption = endIndex; break;
            case ConsoleKey.DownArrow when _selectedOption == endIndex: _selectedOption = 0; break;
            default: HandleInput(); break;
        }
    }
}
