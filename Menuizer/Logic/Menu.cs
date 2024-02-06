namespace Menuizer;

public class Menu
{
    public static void Build(Dictionary<string, Action> actions, string? consoleTitle = null, string? headerMessage = null, string? message = null)
    {
        if (!string.IsNullOrEmpty(consoleTitle))
            Console.Title = consoleTitle;

        if (!string.IsNullOrEmpty(headerMessage))
            MenuUI.HeaderMessage = headerMessage;

        if (!string.IsNullOrEmpty(message))
            MenuUI.Message = message;

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
