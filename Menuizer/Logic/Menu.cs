namespace Menuizer;

/// <summary>
/// Provides methods for building and managing a console menu.
/// </summary>
public static class Menu
{
    // Builds the menu based on the provided actions
    public static void Build(Dictionary<string, Action> actions)
    {
        var items = actions.Keys.ToArray();
        MenuUI.DrawMenu(items);

        // Invokes the action corresponding to the selected option
        var key = actions.Keys.ElementAt(MenuUI.SelectedOption);
        actions[key].Invoke();
    }

    // Resets the menu UI
    public static void Reset()
    {
        MenuUI.WindowTitle = null;
        MenuUI.HeaderTitle = null;
        MenuUI.Message = null;
    }

    // Exits the application
    public static void Exit() => Environment.Exit(0);
}
