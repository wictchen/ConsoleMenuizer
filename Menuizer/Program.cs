using Menuizer;

MainMenu();

static void MainMenu()
{
    MenuUI.HeaderMessage = "Main Menu";
    MenuUI.Message = "Your option:";
    MenuUI.DrawMenu("Item 1", "Item 2", "Item 3");
}
