using NeoModLoader.api;
using System;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using ReflectionUtility;
using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmbientWar;
using static Config;
using System.Reflection;
using UnityEngine.Tilemaps;
using System.IO;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http;
using HarmonyLib;
using UnityEngine;

namespace AmbientWar {
    class RGN {
        public static void init() {

            Harmony harmony = new Harmony("com.ambientwar.mod");
            MethodInfo originalMethod = typeof(BaseSimObject).GetMethod(nameof(BaseSimObject.findEnemyObjectTarget), BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo prefixMethod = typeof(RGN).GetMethod(nameof(findEnemyObjectTarget_prefix), BindingFlags.Static | BindingFlags.Public);
            harmony.Patch(originalMethod, new HarmonyMethod(prefixMethod));

            RaceBuildOrderAsset human = AssetManager.race_build_orders.get("kingdom_base");
            BuildingAsset OVM10 = AssetManager.buildings.clone("OVM10", "!city_building");
            OVM10.id = "OVM10";
            OVM10.type = "OVM10";
            OVM10.priority = 3750;
            OVM10.fundament = new BuildingFundament(4, 2, 2, 0);
            OVM10.cost = new ConstructionCost(pStone: 10, pGold: 800);
            OVM10.burnable = false;
            OVM10.canBeUpgraded = false;
            OVM10.tower_projectile_amount = 1;
            OVM10.build_place_single = true;
            OVM10.build_place_batch = false;
            OVM10.base_stats[S.health] = 2550;
            OVM10.base_stats[S.knockback] = 7f;
            OVM10.base_stats[S.accuracy] = 80f;
            OVM10.base_stats[S.damage] = 200;
            OVM10.canBeLivingHouse = true;
            OVM10.tech = "FuturisticGuns";
            OVM10.buildRoadTo = false;
            OVM10.tower = true;
            OVM10.tower_projectile = "OVMbomb4";
            OVM10.tower_projectile_offset = 4f;
            OVM10.tower_projectile_reload = 64f;
            AssetManager.buildings.add(OVM10);
            AssetManager.buildings.loadSprites(OVM10);

            AddBuildingOrderKeysToCivRaces("order_OVM10", "OVM10");
            AssetManager.race_build_orders.get("kingdom_base")?.addBuilding("order_OVM10", 1, pPop: 10, pBuildings: 10);
			
            BuildingAsset RiflePlaster200 = AssetManager.buildings.clone("RiflePlaster200", "!city_building");
            AssetManager.buildings.add(RiflePlaster200);
            RiflePlaster200.id = "RiflePlaster200";
            RiflePlaster200.type = "RiflePlaster200";
            RiflePlaster200.priority = 1200;
            RiflePlaster200.fundament = new BuildingFundament(1, 1, 1, 0);
            RiflePlaster200.cost = new ConstructionCost(pGold: 430);
            RiflePlaster200.burnable = true;
            RiflePlaster200.randomFlip = true;
            RiflePlaster200.tower_projectile_amount = 40;
            RiflePlaster200.build_place_single = true;
            RiflePlaster200.build_place_batch = false;
            RiflePlaster200.buildRoadTo = false;
            RiflePlaster200.base_stats[S.health] = 4900;
            RiflePlaster200.base_stats[S.knockback] = 6f;
			RiflePlaster200.base_stats[S.range] = 50f;
            RiflePlaster200.base_stats[S.accuracy] = 80f;
            RiflePlaster200.base_stats[S.targets] = 6f;
            RiflePlaster200.base_stats[S.damage] = 1;
            RiflePlaster200.canBeLivingHouse = true;
            RiflePlaster200.tech = "FuturisticGuns";
            RiflePlaster200.tower = true;
            RiflePlaster200.tower_projectile = "RiflePlaster200FIRE4";
            RiflePlaster200.tower_projectile_offset = 1f;
            RiflePlaster200.tower_projectile_reload = 0.7f;
            AssetManager.buildings.loadSprites(RiflePlaster200);
			AddBuildingOrderKeysToCivRaces("order_RiflePlaster200", "RiflePlaster200");
            AssetManager.race_build_orders.get("kingdom_base")?.addBuilding("order_RiflePlaster200", 1, pPop: 10, pBuildings: 10);  

BuildingAsset UltraCannon = AssetManager.buildings.clone("UltraCannon", "!city_building");
UltraCannon.id = "UltraCannon";
UltraCannon.type = "UltraCannon";
UltraCannon.priority = 1200;
UltraCannon.fundament = new BuildingFundament(1, 1, 1, 0);
UltraCannon.cost = new ConstructionCost(pGold: 400);
UltraCannon.burnable = true;
UltraCannon.randomFlip = true;
UltraCannon.tower_projectile_amount = 4;
UltraCannon.build_place_single = true;
UltraCannon.build_place_batch = false;
UltraCannon.buildRoadTo = false;
UltraCannon.base_stats[S.health] = 8000;
UltraCannon.base_stats[S.knockback] = 6f;
UltraCannon.base_stats[S.accuracy] = 100f;
UltraCannon.base_stats[S.targets] = 6f;
UltraCannon.canBeLivingHouse = true;
UltraCannon.tech = "FuturisticGuns";
UltraCannon.tower = true;
UltraCannon.tower_projectile = "UltraCannonPoryectile4";
UltraCannon.tower_projectile_offset = 1f;
UltraCannon.tower_projectile_reload = 2f;
UltraCannon.upgradedFrom = "Ballista_Defense";
UltraCannon.canBeUpgraded = false;
AssetManager.buildings.loadSprites(UltraCannon);

AddBuildingOrderKeysToCivRaces("order_UltraCannon", "UltraCannon");
human.addUpgrade("order_Ballista_Defense", 0, 0, 100, 20, false, false, 0);

        }
        [HarmonyPatch(typeof(BaseSimObject), "findEnemyObjectTarget")]
        [HarmonyPrefix]
        public static bool findEnemyObjectTarget_prefix(BaseSimObject __instance, ref BaseSimObject __result) {
            int range = -1;

            if (__instance is Building building) {
                if (building.asset.id == "OVM10") {
                    range = 23;
                } else if (building.asset.id == "RiflePlaster200") {
                    range = 17;
                } else if (building.asset.id == "UltraCannon") { 
                    range = 19;
                }
              }
            EnemyFinderData enemyFinderData = EnemiesFinder.findEnemiesFrom(__instance.currentTile, __instance.kingdom, range);
            if (enemyFinderData.list == null) {
                __result = null;
                return false;
            }

            __instance.checkObjectList(enemyFinderData.list, Toolbox.randomChance(0.6f), out BaseSimObject result);
            __result = result;
            return false;
        }
        private static void AddBuildingOrderKeysToCivRaces(string key, string value) 
		{
         foreach (Race race in AssetManager.raceLibrary.list.Where(r => r.civilization)) 
		  {
           race.building_order_keys.Add(key, value);
          }
        }
    }
}
