namespace Menuizer;

public partial class Screens
{
    public static void MainMenu()
    {
        Console.Title = "Menuizer";
        MenuUI.HeaderMessage = "Main Menu";
        Menu.Navigation(new()
        {
            { "Item 1", Screen1 },
            { "Item 2", Screen2 },
            { "Item 3", Screen3 },
            { "Exit", Menu.Exit }
        });
    }
}
