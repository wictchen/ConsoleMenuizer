namespace Menuizer;

public partial class Screens
{
    private static void Screen1()
    {
        MenuUI.HeaderMessage = "Screen 1";
        MenuUI.DrawMenu("Item 1", "Item 2", "Back");
        if (MenuUI.SelectedOption == 2)
            MainMenu();
    }

    private static void Screen2()
    {
        MenuUI.HeaderMessage = "Screen 2";
        MenuUI.DrawMenu("Item 1", "Item 2", "Back");
        if (MenuUI.SelectedOption == 2)
            MainMenu();
    }

    private static void Screen3()
    {
        MenuUI.HeaderMessage = "Screen 3";
        MenuUI.DrawMenu("Item 1", "Item 2", "Back");
        if (MenuUI.SelectedOption == 2)
            MainMenu();
    }
}
