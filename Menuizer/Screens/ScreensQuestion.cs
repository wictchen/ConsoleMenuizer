namespace Menuizer;

public partial class Screens
{
    public static void Confirm()
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
