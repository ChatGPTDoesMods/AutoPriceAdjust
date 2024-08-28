using HarmonyLib;
using UnityEngine;

namespace AutoPriceAdjust.Patches
{
    [HarmonyPatch(typeof(PlayerNetwork), nameof(PlayerNetwork.OnStartClient))]
    public class AdjustPricesOnSpawn
    {
        [HarmonyPrefix]
        private static bool OptimizePricesOnSpawn()
        {
            Plugin.OptimizeProductPrices();
            return true;
        }
    }
}
