namespace Menuizer;

/// <summary>
/// A template for create methods and manipulate the console screen.
/// </summary>
public class Screens
{
    public static void MainMenu()
    {
        MenuUI.WindowTitle = "Menuizer";
        MenuUI.HeaderTitle = "Main Menu";
        Menu.Build(new()
        {
            { "Item 1", Screen1 },
            { "Item 2", Screen2 },
            { "Item 3", Screen3 },
            { "Exit", Menu.Exit }
        });
    }

    public static void Screen1()
    {
        MenuUI.HeaderTitle = "Screen 1";
        Menu.Build(new()
        {
            { "Item 1", Confirm },
            { "Item 2", Confirm },
            { "Item 3", Confirm },
            { "~Back", MainMenu }
        });
    }

    public static void Screen2()
    {
        MenuUI.HeaderTitle = "Screen 2";
        Menu.Build(new()
        {
            { "Item 1", Confirm },
            { "Item 2", Confirm },
            { "Item 3", Confirm },
            { "~Back", MainMenu }
        });
    }

    public static void Screen3()
    {
        MenuUI.HeaderTitle = "Screen 3";
        Menu.Build(new()
        {
            { "Item 1", Confirm },
            { "Item 2", Confirm },
            { "Item 3", Confirm },
            { "~Back", MainMenu }
        });
    }

    public static void Confirm()
    {
        MenuUI.WindowTitle = "Confirm";
        MenuUI.Message = "Are you sure?";
        MenuUI.DrawMenu("No", "Yes");
        switch (MenuUI.SelectedOption)
        {
            case 0: MainMenu(); break;
            case 1: MainMenu(); break;
        }
    }
}
