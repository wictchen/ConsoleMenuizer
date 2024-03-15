namespace Menuizer;

/// <summary>
/// Handles the user interface for the console menu.
/// </summary>
public static class MenuUI
{
    const int MenuWidth = 30;

    private static string[]? _items;
    private static int _selectedOption;

    static MenuUI()
    {
        Console.CursorVisible = false;
    }

    // Gets the selected option
    public static int SelectedOption { get => _selectedOption; }

    // Sets the window title
    public static string? WindowTitle { set => Console.Title = value ?? ""; }

    public static string? HeaderTitle { get; set; }
    public static string? Message { get; set; }

    // Draws the menu with the provided items
    public static void DrawMenu(params string[] items)
    {
        _items = items;
        _selectedOption = 0;

        do
        {
            Console.Clear();
            MenuMessage();

            // Iterates over the items and prints them
            for (int i = 0; i < _items?.Length; i++)
            {
                // Highlights the selected option
                if (i == _selectedOption)
                    (Console.BackgroundColor, Console.ForegroundColor) = (ConsoleColor.White, ConsoleColor.Black);

                Console.WriteLine($"{_items[i],MenuWidth}  ");

                Console.ResetColor();
            }

        } while (!HandleInput());
    }

    // Handles the user input
    private static bool HandleInput()
    {
        int endIndex = _items?.Length - 1 ?? 0;
        ref int option = ref _selectedOption;

        // Changes the selected option based on the key pressed
        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.UpArrow when option > 0: option--; break;
            case ConsoleKey.DownArrow when option < endIndex: option++; break;
            case ConsoleKey.UpArrow when option == 0: option = endIndex; break;
            case ConsoleKey.DownArrow when option == endIndex: option = 0; break;
            case ConsoleKey.Enter: Menu.Reset(); return true;
            default: HandleInput(); break;
        }

        return false;
    }

    // Displays the menu message
    private static void MenuMessage()
    {
        // Displays the header title
        if (!string.IsNullOrEmpty(HeaderTitle))
        {
            string message = HeaderTitle;
            int width = WidthText(message);

            message = " " + message + " ";
            message = message.PadLeft(message.Length + (width - message.Length) / 2, '-');
            message = message.PadRight(width, '-');
            Console.WriteLine($"{message,MenuWidth}");
        }

        // Displays the message
        if (!string.IsNullOrEmpty(Message))
        {
            string message = Message;
            int width = WidthText(message);

            Console.WriteLine($"{message,MenuWidth}");
            Console.WriteLine(new string('-', width));
        }
    }

    // Returns the width of the text
    private static int WidthText(string txt)
        => MenuWidth > txt.Length - 1 ? MenuWidth + 2 : txt.Length + 2;
}
