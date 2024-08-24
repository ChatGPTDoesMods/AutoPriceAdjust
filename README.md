# AutoPriceAdjust: Supermarket Together Mod
Tired of setting prices? Look no further.

A simple mod for Supermarket Together that automatically adjusts product prices when you start the day — includes adjustments for inflation.

⚠ Only one player with this mod installed is required for this mod to function. ⚠

## How To

You must have BepInEx already installed to run this mod.

Find instructions on which version and how to install there.

Link to latest BepInEx release: https://github.com/BepInEx/BepInEx/releases

Ensure BepInEx is downloaded and in the correct location. Note your plugins folder.
![Correct Location for AutoPriceAdjust within files](https://github.com/user-attachments/assets/87f1adb3-d99c-4fc8-b520-ddb1b9e22ef5)

Download & unzip AutoPriceAdjust into the `steamapps\common\Supermarket Together\BepInEx\plugins` folder just like the image above.

Final path should look something like `steamapps\common\Supermarket Together\BepInEx\plugins\AutoPriceAdjust`

Link to latest AutoPriceAdjust release: https://github.com/ChatGPTDoesMods/AutoPriceAdjust/releases

## Logic

At the beginning of each day (hit the green button) this mod will automatically adjust all prices of products to be exactly double the market price.

The logic includes lookups against the inflation index per product category to ensure optimal prices are being set.

See: https://github.com/ChatGPTDoesMods/AutoPriceAdjust/blob/main/src/Patches/AdjustInflation.cs
