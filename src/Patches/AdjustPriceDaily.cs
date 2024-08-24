﻿using HarmonyLib;
using UnityEngine;

namespace AutoPriceAdjust.Patches
{
    [HarmonyPatch(typeof(GameData), nameof(GameData.ServerCalculateNewInflation))]
    public class AdjustPriceDaily
    {
        public static void Postfix()
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
                UnityEngine.Debug.Log($"AttemptingUpdatePrice::AdjustPriceDaily[{products[i].name}] Base = {basePrices[i]} Inflation = {inflationMultiplier[productToUpdate.productTier]} Multiplier = {priceMultiplier} NewPrice = {newPrice}");
            }

            return;
        }
    }
}
