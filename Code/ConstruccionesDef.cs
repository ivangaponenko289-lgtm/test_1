using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using ReflectionUtility;
using ai;
using ai.behaviours;
using AmbientWar;
using HarmonyLib;

namespace AmbientWar
{
    public class ConstruccionesDef
    {
        public void init()
        {
 RaceBuildOrderAsset human = AssetManager.race_build_orders.get("kingdom_base");
BuildingAsset Ballista_Defense = AssetManager.buildings.clone("Ballista_Defense", "!city_building");
Ballista_Defense.id = "Ballista_Defense";
Ballista_Defense.type = "Ballista_Defense";
Ballista_Defense.priority = 600;
Ballista_Defense.fundament = new BuildingFundament(1, 1, 1, 0);
Ballista_Defense.cost = new ConstructionCost(pStone: 10, pWood: 25, pGold: 40);
Ballista_Defense.burnable = true;
Ballista_Defense.randomFlip = true;
Ballista_Defense.tower_projectile_amount = 1;
Ballista_Defense.build_place_single = true;
Ballista_Defense.build_place_batch = false;
Ballista_Defense.buildRoadTo = false;
Ballista_Defense.base_stats[S.health] = 550;
Ballista_Defense.base_stats[S.knockback] = 4f;
Ballista_Defense.base_stats[S.accuracy] = 150f;
Ballista_Defense.base_stats[S.targets] = 1f;
Ballista_Defense.base_stats[S.damage] = 300;
Ballista_Defense.canBeLivingHouse = true;
Ballista_Defense.tech = "Siegeweapons";
Ballista_Defense.tower = true;
Ballista_Defense.tower_projectile = "Ballista4";
Ballista_Defense.tower_projectile_offset = 5f;
Ballista_Defense.tower_projectile_reload = 8f;
Ballista_Defense.canBeUpgraded = true;
Ballista_Defense.upgradeTo = "UltraCannon"; 
Ballista_Defense.upgradeLevel = 1;
AssetManager.buildings.loadSprites(Ballista_Defense);

AddBuildingOrderKeysToCivRaces("order_Ballista_Defense", "Ballista_Defense");
human.addBuilding("order_Ballista_Defense", 1, pPop: 10, pBuildings: 5);

// Nivel 1: Cannon_Defense
BuildingAsset Cannon_Defense = AssetManager.buildings.clone("Cannon_Defense", "!city_building");
Cannon_Defense.id = "Cannon_Defense";
Cannon_Defense.type = "Cannon_Defense";
Cannon_Defense.priority = 650;
Cannon_Defense.fundament = new BuildingFundament(1, 1, 1, 0);
Cannon_Defense.cost = new ConstructionCost(pStone: 10, pWood: 25, pGold: 40);
Cannon_Defense.burnable = true;
Cannon_Defense.randomFlip = true;
Cannon_Defense.tower_projectile_amount = 1;
Cannon_Defense.build_place_single = true;
Cannon_Defense.build_place_batch = false;
Cannon_Defense.buildRoadTo = false;
Cannon_Defense.base_stats[S.health] = 850;
Cannon_Defense.base_stats[S.knockback] = 4f;
Cannon_Defense.base_stats[S.accuracy] = 80f;
Cannon_Defense.base_stats[S.targets] = 1f;
Cannon_Defense.base_stats[S.damage] = 200;
Cannon_Defense.canBeLivingHouse = true;
Cannon_Defense.tech = "Siegeweapons";
Cannon_Defense.tower = true;
Cannon_Defense.tower_projectile = "Cannon4";
Cannon_Defense.tower_projectile_offset = 1f;
Cannon_Defense.tower_projectile_reload = 15f;
Cannon_Defense.canBeUpgraded = true;
Cannon_Defense.upgradeTo = "NTAstra40"; 
Cannon_Defense.upgradeLevel = 1;
AssetManager.buildings.loadSprites(Cannon_Defense);

AddBuildingOrderKeysToCivRaces("order_Cannon_Defense", "Cannon_Defense");
human.addBuilding("order_Cannon_Defense", 1, pPop: 10, pBuildings: 10);

BuildingAsset NTAstra40 = AssetManager.buildings.clone("NTAstra40", "!city_building");
NTAstra40.id = "NTAstra40";
NTAstra40.type = "NTAstra40";
NTAstra40.priority = 800;
NTAstra40.fundament = new BuildingFundament(1, 1, 1, 0);
NTAstra40.cost = new ConstructionCost(pStone: 10, pWood: 60, pGold: 240);
NTAstra40.burnable = true;
NTAstra40.randomFlip = true;
NTAstra40.tower_projectile_amount = 70;
NTAstra40.build_place_single = true;
NTAstra40.build_place_batch = false;
NTAstra40.buildRoadTo = false;
NTAstra40.base_stats[S.health] = 5000;
NTAstra40.base_stats[S.knockback] = 7f;
NTAstra40.base_stats[S.range] = 50f;
NTAstra40.base_stats[S.accuracy] = 100f;
NTAstra40.base_stats[S.targets] = 6f;
NTAstra40.base_stats[S.damage] = 900;
NTAstra40.canBeLivingHouse = true;
NTAstra40.tech = "FuturisticGuns";
NTAstra40.tower = true;
NTAstra40.tower_projectile = "BlueLaser4";
NTAstra40.tower_projectile_offset = 5f;
NTAstra40.tower_projectile_reload = 0.5f;
NTAstra40.upgradedFrom = "Cannon_Defense";
NTAstra40.upgradeLevel = 2;
NTAstra40.canBeUpgraded = false; // Es el nivel final
AssetManager.buildings.loadSprites(NTAstra40);

AddBuildingOrderKeysToCivRaces("order_NTAstra40", "NTAstra40");
human.addUpgrade("order_Cannon_Defense", 0, 0, 50, 10, false, false, 0);

			
		
			
        }

        private void AddBuildingOrderKeysToCivRaces(string key, string value)
        {
            foreach (Race race in AssetManager.raceLibrary.list.Where(race => race.civilization))
            {
                race.building_order_keys.Add(key, value);
            }
        }
    }
}
