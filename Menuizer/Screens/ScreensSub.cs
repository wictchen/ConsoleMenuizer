namespace Menuizer;

public partial class Screens
{
    private static void Screen1()
    {
        MenuUI.HeaderMessage = "Screen 1";
        MenuUI.DrawMenu("Item 1", "Item 2", "Item 3", "Back");
        switch (MenuUI.SelectedOption)
        {
            case 0: Confirm(); break;
            case 1: Confirm(); break;
            case 2: Confirm(); break;
            case 3: MainMenu(); break;
        }
    }

    private static void Screen2()
    {
        MenuUI.HeaderMessage = "Screen 2";
        MenuUI.DrawMenu("Item 1", "Item 2", "Item 3", "Back");
        switch (MenuUI.SelectedOption)
        {
            case 0: Confirm(); break;
            case 1: Confirm(); break;
            case 2: Confirm(); break;
            case 3: MainMenu(); break;
        }
    }

    private static void Screen3()
    {
        MenuUI.HeaderMessage = "Screen 3";
        MenuUI.DrawMenu("Item 1", "Item 2", "Item 3", "Back");
        switch (MenuUI.SelectedOption)
        {
            case 0: Confirm(); break;
            case 1: Confirm(); break;
            case 2: Confirm(); break;
            case 3: MainMenu(); break;
        }
    }
}
