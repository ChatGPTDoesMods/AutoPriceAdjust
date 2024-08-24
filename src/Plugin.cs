using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

namespace AutoPriceAdjust;

[BepInPlugin("AutoPriceAdjust", "Auto Price Adjust", "1.0.1")]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;

    internal static HarmonyLib.Harmony Harmony;

    private void Awake()
    {
        Logger = base.Logger;
        Logger.LogInfo($"Plugin AutoPriceAdjust is loaded!");
        Harmony = new("mod.supermarkettogether.autopriceadjust");
        Harmony.PatchAll();
    }
}
