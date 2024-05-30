using System;
using System.Collections.Generic;

public class PluginManager
{
    private List<IPlugin> plugins = new List<IPlugin>();

    public void LoadPlugin(IPlugin plugin)
    {
        plugins.Add(plugin);
    }

    public void ExecutePlugins()
    {
        foreach (var plugin in plugins)
        {
            plugin.Execute();
        }
    }
}
