# AutoPriceAdjust: Supermarket Together Mod
Tired of setting prices? Look no further.

A simple mod for Supermarket Together that automatically adjusts product prices when you start the day — includes adjustments for inflation.

⚠ Only one player with this mod installed is required for this mod to function. ⚠

## How To

You must have BepInEx already installed to run this mod.

Link to github: https://github.com/BepInEx/BepInEx 

Find instructions on which version and how to install there.

Link to download: https://github.com/BepInEx/BepInEx/releases

Once BepInEx is downloaded and in the correct location, unzip AutoPriceAdjust into the BepInEx>Plugins folder.
![Correct Location for AutoPriceAdjust within files](https://github.com/user-attachments/assets/87f1adb3-d99c-4fc8-b520-ddb1b9e22ef5)

## Logic

At the beginning of each day (hit the green button) this mod will automatically adjust all prices of products to be exactly double the market price.

The logic includes lookups against the inflation index per product category to ensure optimal prices are being set.

See: https://github.com/ChatGPTDoesMods/AutoPriceAdjust/blob/main/src/Patches/AdjustInflation.cs
