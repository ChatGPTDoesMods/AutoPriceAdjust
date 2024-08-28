using HarmonyLib;
using UnityEngine;

namespace AutoPriceAdjust.Patches
{
    [HarmonyPatch(typeof(GameData), nameof(GameData.ServerCalculateNewInflation))]
    public class AdjustPricesDaily
    {
        [HarmonyPostfix]
        private static void OptimizePricesDaily()
        {
            Plugin.OptimizeProductPrices();
        }
    }
}
