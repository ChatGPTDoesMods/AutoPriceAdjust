using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace AutoPriceAdjust;

[BepInPlugin("AutoPriceAdjust", "Auto Price Adjust", "1.1.0")]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;

    internal static HarmonyLib.Harmony Harmony;

    private void Awake()
    {
        Logger = base.Logger;
        Logger.LogInfo("ChatGPT wizardry at work!");
        Harmony = new("mod.supermarkettogether.autopriceadjust");
        Harmony.PatchAll();
    }

    public static void OptimizeProductPrices()
    {
        GameObject[] products = ProductListing.Instance.productPrefabs;
        ProductListing productListing = ProductListing.Instance;
        var basePriceList = new System.Collections.Generic.List<float>();

        for (int i = 0; i < products.Length; i++)
        {
            if (i < products.Length)
            {
                Data_Product product = products[i].GetComponent<Data_Product>();
                basePriceList.Add(product.basePricePerUnit);
            }
        }

        float[] basePrices = basePriceList.ToArray();
        float[] inflationMultiplier = productListing.tierInflation;
        int priceMultiplier = 2;
        float[] newPrices = new float[basePrices.Length];

        for (int i = 0; i < basePrices.Length; i++)
        {
            Data_Product productToUpdate = products[i].GetComponent<Data_Product>();
            float calculatedPrice = basePrices[i] * inflationMultiplier[productToUpdate.productTier] * priceMultiplier;
            float newPrice = Mathf.Floor((calculatedPrice - 0.02f) * 100) / 100;
            productListing.CmdUpdateProductPrice(i, newPrice);
            // UnityEngine.Debug.Log($"AttemptingUpdatePrice::AdjustPriceOnSpawn[{products[i].name}] Base = {basePrices[i]} Inflation = {inflationMultiplier[productToUpdate.productTier]} Multiplier = {priceMultiplier} NewPrice = {newPrice}");
        }
    }
}
