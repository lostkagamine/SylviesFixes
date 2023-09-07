using UnityEngine;

namespace SylviesFixes.Impl;

[Fix("RunInBackground")]
public class RunInBackgroundFix : Fix
{
    public override string FriendlyName => "Run in background";
    public override string Description => "Makes the game run in the background.";
    public override void OnEnable()
    {
        Application.runInBackground = true;
    }

    public override void OnDisable()
    {
        Application.runInBackground = false;
    }
}