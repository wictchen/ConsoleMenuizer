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

            foreach (var i in _items ?? Array.Empty<string>())
            {
                if (i == _items?.ElementAt(_selectedOption))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.WriteLine(new string(' ', 20) + i);

                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
