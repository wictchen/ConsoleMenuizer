namespace Menuizer;

public class Screens
{
    public static void MainMenu()
    {
        Menu.Build(
            consoleTitle: "Menuizer",
            headerMessage: "Main Menu",
            actions: new() {
                { "Item 1", Screen1 },
                { "Item 2", Screen2 },
                { "Item 3", Screen3 },
                { "Exit", Menu.Exit }
            });
    }

    private static void Screen1()
    {
        Menu.Build(
            headerMessage: "Screen 1",
            actions: new() {
                { "Item 1", Confirm },
                { "Item 2", Confirm },
                { "Item 3", Confirm },
                { "~Back", MainMenu }
            });
    }

    private static void Screen2()
    {
        Menu.Build(
            headerMessage: "Screen 2",
            actions: new() {
                { "Item 1", Confirm },
                { "Item 2", Confirm },
                { "Item 3", Confirm },
                { "~Back", MainMenu }
            });
    }

    private static void Screen3()
    {
        Menu.Build(
            headerMessage: "Screen 3",
            actions: new() {
                { "Item 1", Confirm },
                { "Item 2", Confirm },
                { "Item 3", Confirm },
                { "~Back", MainMenu }
            });
    }

    private static void Confirm()
    {
        MenuUI.Message = "Are you sure?";
        MenuUI.DrawMenu("No", "Yes");
        switch (MenuUI.SelectedOption)
        {
            case 0: MainMenu(); break;
            case 1: MainMenu(); break;
        }
    }
}
