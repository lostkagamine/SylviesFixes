using System;
using System.Collections.Generic;
using System.Reflection;

namespace SylviesFixes;

public class FixManager
{
    public static Dictionary<string, Fix> Fixes = new();
    
    public static void ScanAndApply()
    {
        var asm = Assembly.GetExecutingAssembly();
        foreach (var t in asm.GetTypes())
        {
            if (!t.IsSubclassOf(typeof(Fix))) continue;
            var attr = t.GetCustomAttribute<FixAttribute>();
            if (attr == null) continue;
            var name = attr.Name;
            var inst = Activator.CreateInstance(t) as Fix;
            Fixes[name] = inst ?? throw new Exception("?");
            inst.OnEnable();
        }
        Plugin.Log.LogInfo($"Loaded and enabled {Fixes.Count} fixes");
    }
}