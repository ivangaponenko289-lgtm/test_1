//========= MODERNBOX 2.1.0.1 ============//
// Made by Tuxxego
//========================================//

using System;
using System.Collections.Generic;
using UnityEngine;
using HarmonyLib;
using NCMS.Utils;
using NCMS;
using System.Linq;

namespace ModernBox
{
    public static class CustomItemsList
    {
        public static List<EquipmentAsset> CustomWeapons = new List<EquipmentAsset>();
        public static readonly Dictionary<string, string> WeaponEras = new Dictionary<string, string>
        {
            { "Glock17", "modern" },
            { "AK", "modern" },
            { "RPG", "modern" },
            { "Minigun", "modern" },
            { "Sniper", "modern" },
            { "FAMAS", "modern" },
            { "M4A1", "modern" },
            { "ThompsonM1A1", "modern" },
            { "SGT44", "modern" },
            { "XM8", "modern" },
            { "AK103", "modern" },
            { "Uzi", "modern" },
            { "Malorian", "modern" },
            { "DesertEagle", "modern" },
            { "M16", "modern" },
            { "HK416", "modern" },
            { "MP7", "modern" },
            { "M32", "modern" },
            { "Sluggershotgun", "modern" },
            { "Americanshotgun", "modern" },
            { "Flamethrower", "modern" },
            { "vrifle", "modern" },
            { "bigboy", "modern" },
            { "grifle", "modern" },
            { "MGL", "modern" },

            { "BudgetMIRV", "modern" },
            { "DecentMIRV", "modern" },
            { "MIRV", "modern" },
            { "MIRVBomb", "modern" },
            { "STRONGMIRV", "modern" },

            { "BathSalts", "modern" },
            { "Fentanyl", "modern" },
            { "Morphine", "modern" },
            { "Oxycodone", "modern" },
            { "Ritalin", "modern" }
        };
        public static bool GunsAllowed;
        public static bool MirvsAllowed = true;
        public static bool DrugsAllowed;

        public static readonly HashSet<string> Kys = new HashSet<string>
        {
            "BudgetMIRV",
            "DecentMIRV",
            "MIRV",
            "MIRVBomb",
            "STRONGMIRV"
        };

        public static readonly HashSet<string> Druggies = new HashSet<string>
        {
            "BathSalts",
            "Fentanyl",
            "Morphine",
            "Oxycodone",
            "Ritalin"
        };

        public static void InitCustomItems()
        {
            if (!AssetManager.items.dict.ContainsKey("Glock17"))
                return;

            CustomWeapons.Clear();
            CustomWeapons.Add(AssetManager.items.get("Glock17"));
            CustomWeapons.Add(AssetManager.items.get("AK"));
            CustomWeapons.Add(AssetManager.items.get("RPG"));
            CustomWeapons.Add(AssetManager.items.get("Minigun"));
            CustomWeapons.Add(AssetManager.items.get("Sniper"));
            CustomWeapons.Add(AssetManager.items.get("FAMAS"));
            CustomWeapons.Add(AssetManager.items.get("M4A1"));
            CustomWeapons.Add(AssetManager.items.get("ThompsonM1A1"));
            CustomWeapons.Add(AssetManager.items.get("SGT44"));
            CustomWeapons.Add(AssetManager.items.get("XM8"));
            CustomWeapons.Add(AssetManager.items.get("AK103"));
            CustomWeapons.Add(AssetManager.items.get("Uzi"));
            CustomWeapons.Add(AssetManager.items.get("Malorian"));
            CustomWeapons.Add(AssetManager.items.get("DesertEagle"));
            CustomWeapons.Add(AssetManager.items.get("M16"));
            CustomWeapons.Add(AssetManager.items.get("HK416"));
            CustomWeapons.Add(AssetManager.items.get("MP7"));
            CustomWeapons.Add(AssetManager.items.get("M32"));
            CustomWeapons.Add(AssetManager.items.get("Sluggershotgun"));
            CustomWeapons.Add(AssetManager.items.get("Americanshotgun"));
            CustomWeapons.Add(AssetManager.items.get("Flamethrower"));
            CustomWeapons.Add(AssetManager.items.get("vrifle"));
            CustomWeapons.Add(AssetManager.items.get("bigboy"));
            CustomWeapons.Add(AssetManager.items.get("grifle"));
            CustomWeapons.Add(AssetManager.items.get("MGL"));
            CustomWeapons.Add(AssetManager.items.get("BudgetMIRV"));
            CustomWeapons.Add(AssetManager.items.get("DecentMIRV"));
            CustomWeapons.Add(AssetManager.items.get("MIRV"));
            CustomWeapons.Add(AssetManager.items.get("MIRVBomb"));
            CustomWeapons.Add(AssetManager.items.get("STRONGMIRV"));
            CustomWeapons.Add(AssetManager.items.get("BathSalts"));
            CustomWeapons.Add(AssetManager.items.get("Fentanyl"));
            CustomWeapons.Add(AssetManager.items.get("Morphine"));
            CustomWeapons.Add(AssetManager.items.get("Oxycodone"));
            CustomWeapons.Add(AssetManager.items.get("Ritalin"));
        }

        public static string GetCultureEraSafe(Culture culture)
        {
            if (culture == null || culture.cities == null || culture.cities.Count == 0)
                return null;

            foreach (City city in culture.cities)
            {
                if (city == null)
                    continue;

                Building bonfire = city.getBuildingOfType("type_bonfire");
                if (bonfire == null || bonfire.asset == null)
                    continue;

                int level = bonfire.asset.upgrade_level;

                return level switch
                {
                    0 => "medieval",
                    1 => "renaissance",
                    2 => "modern",
                    3 => "modern",
                    _ => null
                };
            }

            return null;
        }

        public static bool IsWeaponAllowedForEra(EquipmentAsset asset, string era)
        {
            if (asset == null || era == null)
                return false;

            if (!WeaponEras.TryGetValue(asset.id, out string weaponEra))
                return false;

            return weaponEra == era;
        }

        public static void turnOnGuns() => GunsAllowed = true;
        public static void turnOffGuns() => GunsAllowed = false;

        public static void turnOnMIRVs() => MirvsAllowed = true;
        public static void turnOffMIRVs() => MirvsAllowed = false;
    
        public static void turnOnDrugs() => DrugsAllowed = true;
        public static void turnOffDrugs() => DrugsAllowed = false;
    
public static void toggleGuns()
        {
            Main.modifyBoolOption("GunOption", PowerButtons.GetToggleValue("gun_toggle"));
            if (PowerButtons.GetToggleValue("gun_toggle"))
            {
                turnOnGuns();
                return;
            }
            turnOffGuns();
        }
    

public static void toggleMIRVs()
        {
            Main.modifyBoolOption("MIRVOption", PowerButtons.GetToggleValue("mirv_toggle"));
            if (PowerButtons.GetToggleValue("mirv_toggle"))
            {
                turnOnMIRVs();
                return;
            }
            turnOffMIRVs();
        }
    

public static void toggleDrugs()
        {
            Main.modifyBoolOption("DrugsOption", PowerButtons.GetToggleValue("drugs_toggle"));
            if (PowerButtons.GetToggleValue("drugs_toggle"))
            {
                turnOnDrugs();
                return;
            }
            turnOffDrugs();
        }
    }

    [HarmonyPatch(typeof(Culture), "getPreferredWeaponSubtypeIDs")]
    public class Patch_Culture_PreferredWeaponSubtypes
    {
        static bool Prefix(Culture __instance, ref string __result)
        {
            if (!CustomItemsList.GunsAllowed || CustomItemsList.CustomWeapons.Count == 0)
                return true;

            if (!CustomItemsList.MirvsAllowed && CustomItemsList.Kys.Contains(__result))
                return false;

            if (!CustomItemsList.DrugsAllowed && CustomItemsList.Druggies.Contains(__result))
                return false;

            __result = "firearm";
            return false;
        }
    }

    [HarmonyPatch(typeof(Culture), "getPreferredWeaponAssets")]
    public class Patch_Culture_PreferredWeaponAssets
    {
        static bool Prefix(Culture __instance, ref List<EquipmentAsset> __result)
        {
            if (!CustomItemsList.GunsAllowed || CustomItemsList.CustomWeapons.Count == 0)
                return true;

            string era = CustomItemsList.GetCultureEraSafe(__instance);
            if (era == null)
            {
                __result = new List<EquipmentAsset>();
                return false;
            }

            IEnumerable<EquipmentAsset> weapons =
                CustomItemsList.CustomWeapons
                    .Where(w => CustomItemsList.IsWeaponAllowedForEra(w, era));

            if (!CustomItemsList.MirvsAllowed)
                weapons = weapons.Where(w => !CustomItemsList.Kys.Contains(w.id));

            if (!CustomItemsList.DrugsAllowed)
                weapons = weapons.Where(w => !CustomItemsList.Druggies.Contains(w.id));

            __result = weapons.ToList();
            return false;
        }
    }

    [HarmonyPatch(typeof(Culture), "hasPreferredWeaponsToCraft")]
    public class Patch_Culture_HasPreferredWeaponsToCraft
    {
        static bool Prefix(Culture __instance, ref bool __result)
        {
            if (!CustomItemsList.GunsAllowed || CustomItemsList.CustomWeapons.Count == 0)
                return true;

            string era = CustomItemsList.GetCultureEraSafe(__instance);
            if (era == null)
            {
                __result = false;
                return false;
            }

            __result = CustomItemsList.CustomWeapons.Any(w =>
                CustomItemsList.IsWeaponAllowedForEra(w, era) &&
                (CustomItemsList.MirvsAllowed || !CustomItemsList.Kys.Contains(w.id)) &&
                (CustomItemsList.DrugsAllowed || !CustomItemsList.Druggies.Contains(w.id))
            );

            return false;
        }
    }

    public class WeaponsProjectilesEffects : MonoBehaviour
    {
        public static void init()
        {
            FixAllWeapons();
        }

        public static void FixAllWeapons()
        {
      //      ModernBoxLogger.Log("[FixAllWeapons] Starting weapon sprite fix pass...");

            int totalChecked = 0;
            int totalFixed = 0;
            int totalSkipped = 0;

            foreach (var kvp in AssetManager.items.list)
            {
                string id = kvp.id;
                EquipmentAsset asset = kvp;

                if (asset == null)
                {
                    totalSkipped++;
                    continue;
                }

                totalChecked++;

                if (asset.gameplay_sprites == null || asset.gameplay_sprites.Length == 0)
                {
                    var sprites = FetchSprites(id);
                    asset.gameplay_sprites = sprites;

                    if (sprites != null && sprites.Length > 0)
                        totalFixed++;
                }
                else
                {
                    totalSkipped++;
                }
            }

         //   ModernBoxLogger.Log($"[FixAllWeapons] Done. Checked: {totalChecked}, Fixed: {totalFixed}, Skipped: {totalSkipped}");
        }

        public static Sprite[] FetchSprites(string id)
        {
            EquipmentAsset item = AssetManager.items.get(id);
            if (item == null)
                return Array.Empty<Sprite>();

            if (item.animated)
            {
                List<Sprite> spriteList = new List<Sprite>();
                int frameIndex = 0;
                bool foundFrames = false;

                while (true)
                {
                    string[] paths = new[]
                    {
                        $"weapons/{id}_{frameIndex}",
                        $"weapons/{id}{frameIndex}",
                        $"weapons/{id}/main_0_{frameIndex}"
                    };

                    bool frameFound = false;
                    foreach (string path in paths)
                    {
                        Sprite sprite = Resources.Load<Sprite>(path);
                        if (sprite != null)
                        {
                            spriteList.Add(sprite);
                            foundFrames = true;
                            frameIndex++;
                            frameFound = true;
                            break;
                        }
                    }

                    if (!frameFound) break;
                    if (frameIndex > 20) break;
                }

                if (!foundFrames)
                {
                    var fallback = Resources.LoadAll<Sprite>("weapons/" + id);
                    if (fallback != null && fallback.Length > 0)
                        return fallback;
                    else
                        return Array.Empty<Sprite>();
                }

                return spriteList.ToArray();
            }
            else
            {
                var sprite = Resources.Load<Sprite>("weapons/" + id);
                return sprite != null ? new Sprite[] { sprite } : Array.Empty<Sprite>();
            }
        }
    }
}

