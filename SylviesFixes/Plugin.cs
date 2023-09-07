using BepInEx;
using BepInEx.Logging;

namespace SylviesFixes
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public static ManualLogSource Log = null!;
        
        private void Awake()
        {
            Log = Logger;
            
            Log.LogInfo("SylviesFixes starting");
            FixManager.ScanAndApply();
        }
    }
}