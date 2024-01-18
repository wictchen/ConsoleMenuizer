namespace Menuizer;

public class Screens
{
    public static void MainMenu()
    {
        Console.Title = "Menuizer";
        MenuUI.HeaderMessage = "Main Menu";
        MenuUI.Message = "Your option:";
        MenuUI.DrawMenu("Item 1", "Item 2", "Item 3");
    }
}
