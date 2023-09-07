using System;

namespace SylviesFixes;

[AttributeUsage(AttributeTargets.Class)]
public class FixAttribute : Attribute
{
    public string Name;
    
    public FixAttribute(string name)
    {
        Name = name;
    }
}