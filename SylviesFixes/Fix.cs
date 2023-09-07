namespace SylviesFixes;

public abstract class Fix
{
    public abstract string FriendlyName { get; }
    public abstract string Description { get; }
    
    public abstract void OnEnable();
    public abstract void OnDisable();
}