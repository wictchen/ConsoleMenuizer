namespace Menuizer;

public partial class Screens
{
    public static void MainMenu()
    {
        Console.Title = "Menuizer";
        MenuUI.HeaderMessage = "Main Menu";
        MenuUI.DrawMenu("Item 1", "Item 2", "Item 3");
        switch (MenuUI.SelectedOption)
        {
            case 0: Screen1(); break;
            case 1: Screen2(); break;
            case 2: Screen3(); break;
        }
    }
}
