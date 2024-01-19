namespace Menuizer;

public class Menu
{
    public static void Navigation(Dictionary<string, Action> actions)
    {
        var items = actions.Keys.ToArray();
        MenuUI.DrawMenu(items);

        var key = actions.Keys.ElementAt(MenuUI.SelectedOption);
        actions[key].Invoke();
    }

    public static void Reset()
    {
        MenuUI.HeaderMessage = null;
        MenuUI.Message = null;
    }

    public static void Exit() => Environment.Exit(0);
}
