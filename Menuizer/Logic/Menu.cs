﻿namespace Menuizer;

public static class Menu
{
    public static void Build(Dictionary<string, Action> actions)
    {
        var items = actions.Keys.ToArray();
        MenuUI.DrawMenu(items);

        var key = actions.Keys.ElementAt(MenuUI.SelectedOption);
        actions[key].Invoke();
    }

    public static void Reset()
    {
        MenuUI.WindowTitle = null;
        MenuUI.HeaderTitle = null;
        MenuUI.Message = null;
    }

    public static void Exit() => Environment.Exit(0);
}
