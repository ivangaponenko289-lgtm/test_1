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
    public class Construcciones
    {
        public void init()
        {
           RaceBuildOrderAsset human = AssetManager.race_build_orders.get("kingdom_base");
    BuildingAsset Industria_HT = AssetManager.buildings.clone("Industria_HT", "!city_building");
    Industria_HT.type = "Industria_HT";
    Industria_HT.priority = 600;
    Industria_HT.fundament = new BuildingFundament(0, 0, 0, 0);
    Industria_HT.cost = new ConstructionCost(pStone: 20, pWood: 40, pGold: 260);
    Industria_HT.burnable = true;
    Industria_HT.build_place_single = true;
    Industria_HT.build_place_batch = false;
    Industria_HT.base_stats[S.health] = 450f;
    Industria_HT.base_stats[S.size] = 1f;
    Industria_HT.canBeLivingHouse = false;
    Industria_HT.buildRoadTo = true;
    Industria_HT.tech = "Industria_HT's";
    Industria_HT.housing = 1;
    Industria_HT.spawnUnits = true;
    Industria_HT.spawnUnits_asset = "Zeta01";
    Industria_HT.canBeUpgraded = true;
    Industria_HT.upgradeTo = "Industria_HT2";
    Industria_HT.upgradeLevel = 1;
    Industria_HT.resources_given.Add(new ResourceContainer { id = "stone", amount = 50 });
    Industria_HT.resources_given.Add(new ResourceContainer { id = "wood", amount = 78 });
    AssetManager.buildings.loadSprites(Industria_HT);

    // Nivel 2
    BuildingAsset Industria_HT2 = AssetManager.buildings.clone("Industria_HT2", "!city_building");
    Industria_HT2.type = "Industria_HT2";
    Industria_HT2.priority = 1000;
    Industria_HT2.fundament = new BuildingFundament(0, 0, 0, 0);
    Industria_HT2.cost = new ConstructionCost(pStone: 34, pWood: 50, pGold: 360);
    Industria_HT2.burnable = true;
    Industria_HT2.build_place_single = true;
    Industria_HT2.build_place_batch = false;
    Industria_HT2.base_stats[S.health] = 550f;
    Industria_HT2.base_stats[S.size] = 1f;
    Industria_HT2.canBeLivingHouse = false;
    Industria_HT2.buildRoadTo = true;
    Industria_HT2.tech = "Industria_HT's";
    Industria_HT2.housing = 4;
    Industria_HT2.spawnUnits = true;
	Industria_HT2.canBeUpgraded = true;
    Industria_HT2.spawnUnits_asset = "Zeta02";
    Industria_HT2.upgradeLevel = 2;
    Industria_HT2.upgradedFrom = "Industria_HT";
    Industria_HT2.upgradeTo = "Industria_HT3";
    AssetManager.buildings.loadSprites(Industria_HT2);

    // Nivel 3
    BuildingAsset Industria_HT3 = AssetManager.buildings.clone("Industria_HT3", "!city_building");
    Industria_HT3.type = "Industria_HT3";
    Industria_HT3.priority = 1400;
    Industria_HT3.fundament = new BuildingFundament(0, 0, 0, 0);
    Industria_HT3.cost = new ConstructionCost(pStone: 45, pWood: 60, pGold: 430);
    Industria_HT3.burnable = true;
    Industria_HT3.build_place_single = true;
    Industria_HT3.build_place_batch = false;
    Industria_HT3.base_stats[S.health] = 650f;
    Industria_HT3.base_stats[S.size] = 1f;
    Industria_HT3.canBeLivingHouse = false;
    Industria_HT3.buildRoadTo = true;
	Industria_HT3.canBeUpgraded = true;
    Industria_HT3.tech = "Industria_HT's";
    Industria_HT3.housing = 1;
    Industria_HT3.spawnUnits = true;
    Industria_HT3.spawnUnits_asset = "Zeta03";
    Industria_HT3.upgradeLevel = 3;
    Industria_HT3.upgradedFrom = "Industria_HT2";
    Industria_HT3.upgradeTo = "Industria_HT4";
    AssetManager.buildings.loadSprites(Industria_HT3);

    // Nivel 4
    BuildingAsset Industria_HT4 = AssetManager.buildings.clone("Industria_HT4", "!city_building");
    Industria_HT4.type = "Industria_HT4";
    Industria_HT4.priority = 1600;
    Industria_HT4.fundament = new BuildingFundament(0, 0, 0, 0);
    Industria_HT4.cost = new ConstructionCost(pStone: 47, pWood: 75, pGold: 432);
    Industria_HT4.burnable = true;
    Industria_HT4.build_place_single = true;
    Industria_HT4.build_place_batch = false;
    Industria_HT4.base_stats[S.health] = 780f;
    Industria_HT4.base_stats[S.size] = 2f;
    Industria_HT4.canBeLivingHouse = false;
    Industria_HT4.buildRoadTo = true;
	Industria_HT4.canBeUpgraded = true;
    Industria_HT4.tech = "Industria_HT's";
    Industria_HT4.housing = 1;
    Industria_HT4.spawnUnits = true;
    Industria_HT4.spawnUnits_asset = "Zeta04";
    Industria_HT4.upgradeLevel = 4;
    Industria_HT4.upgradedFrom = "Industria_HT3";
    Industria_HT4.upgradeTo = "Industria_HT5";
    AssetManager.buildings.loadSprites(Industria_HT4);

    // Nivel 5 (final)
    BuildingAsset Industria_HT5 = AssetManager.buildings.clone("Industria_HT5", "!city_building");
    Industria_HT5.type = "Industria_HT5";
    Industria_HT5.priority = 2000;
    Industria_HT5.fundament = new BuildingFundament(0, 0, 0, 0);
    Industria_HT5.cost = new ConstructionCost(pStone: 50, pWood: 78, pGold: 470);
    Industria_HT5.burnable = true;
    Industria_HT5.build_place_single = true;
    Industria_HT5.build_place_batch = false;
    Industria_HT5.base_stats[S.health] = 900f;
    Industria_HT5.base_stats[S.size] = 2f;
    Industria_HT5.canBeLivingHouse = false;
    Industria_HT5.buildRoadTo = true;
    Industria_HT5.tech = "Industria_HT's";
    Industria_HT5.housing = 1;
    Industria_HT5.spawnUnits = true;
    Industria_HT5.spawnUnits_asset = "Zeta05";
    Industria_HT5.upgradeLevel = 5;
    Industria_HT5.upgradedFrom = "Industria_HT4";
    Industria_HT5.canBeUpgraded = false;  
    AssetManager.buildings.loadSprites(Industria_HT5);

    AddBuildingOrderKeysToCivRaces("order_Industria_HT", "Industria_HT");
    human.addBuilding("order_Industria_HT", 1, pPop: 10, pBuildings: 10);

    AddBuildingOrderKeysToCivRaces("order_Industria_HT2", "Industria_HT2");
    human.addUpgrade("order_Industria_HT", 0, 0, 50, 10, false, false, 0);

    AddBuildingOrderKeysToCivRaces("order_Industria_HT3", "Industria_HT3");
    human.addUpgrade("order_Industria_HT2", 0, 0, 50, 10, false, false, 0);

    AddBuildingOrderKeysToCivRaces("order_Industria_HT4", "Industria_HT4");
    human.addUpgrade("order_Industria_HT3", 0, 0, 50, 10, false, false, 0);

    AddBuildingOrderKeysToCivRaces("order_Industria_HT5", "Industria_HT5");
    human.addUpgrade("order_Industria_HT4", 0, 0, 50, 10, false, false, 0); 
			
// Nivel 1
BuildingAsset Fabrica_OP1 = AssetManager.buildings.clone("Fabrica_OP1", "!city_building");
Fabrica_OP1.type = "Fabrica_OP1";
Fabrica_OP1.priority = 900;
Fabrica_OP1.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OP1.cost = new ConstructionCost(pStone: 10, pWood: 50, pGold: 230);
Fabrica_OP1.burnable = true;
Fabrica_OP1.build_place_single = true;
Fabrica_OP1.build_place_batch = false;
Fabrica_OP1.base_stats[S.health] = 480f;
Fabrica_OP1.base_stats[S.size] = 2f;
Fabrica_OP1.canBeLivingHouse = false;
Fabrica_OP1.buildRoadTo = true;
Fabrica_OP1.tech = "Fabrica_OP's";
Fabrica_OP1.housing = 4;
Fabrica_OP1.spawnUnits = true;
Fabrica_OP1.spawnUnits_asset = "Delta01";
Fabrica_OP1.upgradeLevel = 1;
Fabrica_OP1.canBeUpgraded = true;
Fabrica_OP1.upgradeTo = "Fabrica_OP2";
Fabrica_OP1.resources_given.Add(new ResourceContainer { id = "stone", amount = 25 });
Fabrica_OP1.resources_given.Add(new ResourceContainer { id = "wood", amount = 90 });
AssetManager.buildings.loadSprites(Fabrica_OP1);

// Nivel 2
BuildingAsset Fabrica_OP2 = AssetManager.buildings.clone("Fabrica_OP2", "!city_building");
Fabrica_OP2.type = "Fabrica_OP2";
Fabrica_OP2.priority = 1100;
Fabrica_OP2.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OP2.cost = new ConstructionCost(pStone: 15, pWood: 65, pGold: 270);
Fabrica_OP2.burnable = true;
Fabrica_OP2.build_place_single = true;
Fabrica_OP2.build_place_batch = false;
Fabrica_OP2.base_stats[S.health] = 640f;
Fabrica_OP2.base_stats[S.size] = 2f;
Fabrica_OP2.canBeLivingHouse = false;
Fabrica_OP2.canBeUpgraded = true;
Fabrica_OP2.buildRoadTo = true;
Fabrica_OP2.tech = "Fabrica_OP's";
Fabrica_OP2.housing = 4;
Fabrica_OP2.spawnUnits = true;
Fabrica_OP2.spawnUnits_asset = "Delta02";
Fabrica_OP2.upgradeLevel = 2;
Fabrica_OP2.upgradedFrom = "Fabrica_OP1";
Fabrica_OP2.upgradeTo = "Fabrica_OP3";
AssetManager.buildings.loadSprites(Fabrica_OP2);

// Nivel 3
BuildingAsset Fabrica_OP3 = AssetManager.buildings.clone("Fabrica_OP3", "!city_building");
Fabrica_OP3.type = "Fabrica_OP3";
Fabrica_OP3.priority = 1600;
Fabrica_OP3.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OP3.cost = new ConstructionCost(pStone: 19, pWood: 76, pGold: 280);
Fabrica_OP3.burnable = true;
Fabrica_OP3.build_place_single = true;
Fabrica_OP3.build_place_batch = false;
Fabrica_OP3.base_stats[S.health] = 970f;
Fabrica_OP3.base_stats[S.size] = 2f;
Fabrica_OP3.canBeLivingHouse = false;
Fabrica_OP3.canBeUpgraded = true;
Fabrica_OP3.buildRoadTo = true;
Fabrica_OP3.tech = "Fabrica_OP's";
Fabrica_OP3.housing = 4;
Fabrica_OP3.spawnUnits = true;
Fabrica_OP3.spawnUnits_asset = "Delta03";
Fabrica_OP3.upgradeLevel = 3;
Fabrica_OP3.upgradedFrom = "Fabrica_OP2";
Fabrica_OP3.upgradeTo = "Fabrica_OP4";
AssetManager.buildings.loadSprites(Fabrica_OP3);

// Nivel 4
BuildingAsset Fabrica_OP4 = AssetManager.buildings.clone("Fabrica_OP4", "!city_building");
Fabrica_OP4.type = "Fabrica_OP4";
Fabrica_OP4.priority = 1900;
Fabrica_OP4.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OP4.cost = new ConstructionCost(pStone: 20, pWood: 80, pGold: 290);
Fabrica_OP4.burnable = true;
Fabrica_OP4.build_place_single = true;
Fabrica_OP4.build_place_batch = false;
Fabrica_OP4.base_stats[S.health] = 1050f;
Fabrica_OP4.base_stats[S.size] = 2f;
Fabrica_OP4.canBeLivingHouse = false;
Fabrica_OP4.canBeUpgraded = true;
Fabrica_OP4.buildRoadTo = true;
Fabrica_OP4.tech = "Fabrica_OP's";
Fabrica_OP4.housing = 4;
Fabrica_OP4.spawnUnits = true;
Fabrica_OP4.spawnUnits_asset = "Delta04";
Fabrica_OP4.upgradeLevel = 4;
Fabrica_OP4.upgradedFrom = "Fabrica_OP3";
Fabrica_OP4.upgradeTo = "Fabrica_OP5";
AssetManager.buildings.loadSprites(Fabrica_OP4);

// Nivel 5 (final)
BuildingAsset Fabrica_OP5 = AssetManager.buildings.clone("Fabrica_OP5", "!city_building");
Fabrica_OP5.type = "Fabrica_OP5";
Fabrica_OP5.priority = 2500;
Fabrica_OP5.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OP5.cost = new ConstructionCost(pStone: 25, pWood: 80, pGold: 310);
Fabrica_OP5.burnable = true;
Fabrica_OP5.build_place_single = true;
Fabrica_OP5.build_place_batch = false;
Fabrica_OP5.base_stats[S.health] = 1200f;
Fabrica_OP5.base_stats[S.size] = 2f;
Fabrica_OP5.canBeLivingHouse = false;
Fabrica_OP5.buildRoadTo = true;
Fabrica_OP5.tech = "Fabrica_OP's";
Fabrica_OP5.housing = 4;
Fabrica_OP5.spawnUnits = true;
Fabrica_OP5.spawnUnits_asset = "Delta05";
Fabrica_OP5.upgradeLevel = 5;
Fabrica_OP5.upgradedFrom = "Fabrica_OP4";
Fabrica_OP5.canBeUpgraded = false;  
AssetManager.buildings.loadSprites(Fabrica_OP5);

// Registro de mejoras
AddBuildingOrderKeysToCivRaces("order_Fabrica_OP1", "Fabrica_OP1");
human.addBuilding("order_Fabrica_OP1", 1, pPop: 10, pBuildings: 10);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OP2", "Fabrica_OP2");
human.addUpgrade("order_Fabrica_OP1", 0, 0, 50, 10, false, false, 0);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OP3", "Fabrica_OP3");
human.addUpgrade("order_Fabrica_OP2", 0, 0, 50, 10, false, false, 0);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OP4", "Fabrica_OP4");
human.addUpgrade("order_Fabrica_OP3", 0, 0, 50, 10, false, false, 0);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OP5", "Fabrica_OP5");
human.addUpgrade("order_Fabrica_OP4", 0, 0, 50, 10, false, false, 0);
	
// Nivel 1
BuildingAsset Fabrica_OM1 = AssetManager.buildings.clone("Fabrica_OM1", "!city_building");
Fabrica_OM1.type = "Fabrica_OM1";
Fabrica_OM1.priority = 780;
Fabrica_OM1.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OM1.cost = new ConstructionCost(pStone: 21, pWood: 30, pGold: 80);
Fabrica_OM1.burnable = true;
Fabrica_OM1.build_place_single = true;
Fabrica_OM1.build_place_batch = false;
Fabrica_OM1.base_stats[S.health] = 450f;
Fabrica_OM1.base_stats[S.size] = 2f;
Fabrica_OM1.canBeLivingHouse = false;
Fabrica_OM1.buildRoadTo = true;
Fabrica_OM1.tech = "Fabrica_OM's";
Fabrica_OM1.housing = 4;
Fabrica_OM1.spawnUnits = true;
Fabrica_OM1.canBeUpgraded = true;
Fabrica_OM1.spawnUnits_asset = "Omega01";
Fabrica_OM1.upgradeTo = "Fabrica_OM2"; // Se actualiza a OM2
Fabrica_OM1.upgradeLevel = 1;
Fabrica_OM1.resources_given.Add(new ResourceContainer { id = "stone", amount = 42 });
Fabrica_OM1.resources_given.Add(new ResourceContainer { id = "wood", amount = 150 });
Fabrica_OM1.resources_given.Add(new ResourceContainer { id = "gold", amount = 400 });
AssetManager.buildings.loadSprites(Fabrica_OM1);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OM1", "Fabrica_OM1");
human.addBuilding("order_Fabrica_OM1", 1, pPop: 10, pBuildings: 10);

// Nivel 2
BuildingAsset Fabrica_OM2 = AssetManager.buildings.clone("Fabrica_OM2", "!city_building");
Fabrica_OM2.type = "Fabrica_OM2";
Fabrica_OM2.priority = 1100;
Fabrica_OM2.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OM2.cost = new ConstructionCost(pStone: 28, pWood: 45, pGold: 90);
Fabrica_OM2.burnable = true;
Fabrica_OM2.build_place_single = true;
Fabrica_OM2.build_place_batch = false;
Fabrica_OM2.base_stats[S.health] = 550f;
Fabrica_OM2.base_stats[S.size] = 2f;
Fabrica_OM2.canBeLivingHouse = false;
Fabrica_OM2.buildRoadTo = true;
Fabrica_OM2.tech = "Fabrica_OM's";
Fabrica_OM2.housing = 4;
Fabrica_OM2.spawnUnits = true;
Fabrica_OM2.spawnUnits_asset = "Omega02";
Fabrica_OM2.canBeUpgraded = true;
Fabrica_OM2.upgradeTo = "Fabrica_OM3"; // Se actualiza a OM3
Fabrica_OM2.upgradeLevel = 2;
Fabrica_OM2.upgradedFrom = "Fabrica_OM1";
AssetManager.buildings.loadSprites(Fabrica_OM2);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OM2", "Fabrica_OM2");
human.addUpgrade("order_Fabrica_OM1", 0, 0, 50, 10, false, false, 0);

// Nivel 3
BuildingAsset Fabrica_OM3 = AssetManager.buildings.clone("Fabrica_OM3", "!city_building");
Fabrica_OM3.type = "Fabrica_OM3";
Fabrica_OM3.priority = 1500;
Fabrica_OM3.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OM3.cost = new ConstructionCost(pStone: 32, pWood: 56, pGold: 100);
Fabrica_OM3.burnable = true;
Fabrica_OM3.build_place_single = true;
Fabrica_OM3.build_place_batch = false;
Fabrica_OM3.base_stats[S.health] = 650f;
Fabrica_OM3.base_stats[S.size] = 2f;
Fabrica_OM3.canBeLivingHouse = false;
Fabrica_OM3.buildRoadTo = true;
Fabrica_OM3.canBeUpgraded = true;
Fabrica_OM3.tech = "Fabrica_OM's";
Fabrica_OM3.housing = 4;
Fabrica_OM3.spawnUnits = true;
Fabrica_OM3.spawnUnits_asset = "Omega03";
Fabrica_OM3.upgradeTo = "Fabrica_OM4"; // Se actualiza a OM4
Fabrica_OM3.upgradeLevel = 3;
Fabrica_OM3.upgradedFrom = "Fabrica_OM2";
AssetManager.buildings.loadSprites(Fabrica_OM3);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OM3", "Fabrica_OM3");
human.addUpgrade("order_Fabrica_OM2", 0, 0, 50, 10, false, false, 0);

// Nivel 4
BuildingAsset Fabrica_OM4 = AssetManager.buildings.clone("Fabrica_OM4", "!city_building");
Fabrica_OM4.type = "Fabrica_OM4";
Fabrica_OM4.priority = 1700;
Fabrica_OM4.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OM4.cost = new ConstructionCost(pStone: 40, pWood: 70, pGold: 170);
Fabrica_OM4.burnable = true;
Fabrica_OM4.build_place_single = true;
Fabrica_OM4.build_place_batch = false;
Fabrica_OM4.base_stats[S.health] = 750f;
Fabrica_OM4.base_stats[S.size] = 2f;
Fabrica_OM4.canBeLivingHouse = false;
Fabrica_OM4.buildRoadTo = true;
Fabrica_OM4.tech = "Fabrica_OM's";
Fabrica_OM4.housing = 4;
Fabrica_OM4.canBeUpgraded = true;
Fabrica_OM4.spawnUnits = true;
Fabrica_OM4.spawnUnits_asset = "Omega04";
Fabrica_OM4.upgradeTo = "Fabrica_OM5"; // Se actualiza a OM5
Fabrica_OM4.upgradeLevel = 4;
Fabrica_OM4.upgradedFrom = "Fabrica_OM3";
AssetManager.buildings.loadSprites(Fabrica_OM4);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OM4", "Fabrica_OM4");
human.addUpgrade("order_Fabrica_OM3", 0, 0, 50, 10, false, false, 0);

// Nivel 5 (Final)
BuildingAsset Fabrica_OM5 = AssetManager.buildings.clone("Fabrica_OM5", "!city_building");
Fabrica_OM5.type = "Fabrica_OM5";
Fabrica_OM5.priority = 2400;
Fabrica_OM5.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OM5.cost = new ConstructionCost(pStone: 42, pWood: 150, pGold: 180);
Fabrica_OM5.burnable = true;
Fabrica_OM5.build_place_single = true;
Fabrica_OM5.build_place_batch = false;
Fabrica_OM5.base_stats[S.health] = 850f;
Fabrica_OM5.base_stats[S.size] = 2f;
Fabrica_OM5.canBeLivingHouse = false;
Fabrica_OM5.buildRoadTo = true;
Fabrica_OM5.tech = "Fabrica_OM's";
Fabrica_OM5.housing = 4;
Fabrica_OM5.spawnUnits = true;
Fabrica_OM5.spawnUnits_asset = "Omega05";
Fabrica_OM5.upgradeLevel = 5;
Fabrica_OM5.upgradedFrom = "Fabrica_OM4";
Fabrica_OM5.canBeUpgraded = false;
AssetManager.buildings.loadSprites(Fabrica_OM5);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OM5", "Fabrica_OM5");
human.addUpgrade("order_Fabrica_OM4", 0, 0, 50, 10, false, false, 0);

// Nivel 1
BuildingAsset Fabrica_GM1 = AssetManager.buildings.clone("Fabrica_GM1", "!city_building");
Fabrica_GM1.type = "Fabrica_GM1";
Fabrica_GM1.priority = 810;
Fabrica_GM1.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_GM1.cost = new ConstructionCost(pStone: 10, pWood: 30, pGold: 100);
Fabrica_GM1.burnable = true;
Fabrica_GM1.build_place_single = true;
Fabrica_GM1.build_place_batch = false;
Fabrica_GM1.base_stats[S.health] = 1000f;
Fabrica_GM1.base_stats[S.size] = 2f;
Fabrica_GM1.canBeLivingHouse = false;
Fabrica_GM1.buildRoadTo = true;
Fabrica_GM1.tech = "Fabrica_GM's";
Fabrica_GM1.housing = 4;
Fabrica_GM1.spawnUnits = true;
Fabrica_GM1.spawnUnits_asset = "Gamma01";
Fabrica_GM1.canBeUpgraded = true;
Fabrica_GM1.upgradeTo = "Fabrica_GM2";
Fabrica_GM1.upgradeLevel = 1;
AssetManager.buildings.loadSprites(Fabrica_GM1);

AddBuildingOrderKeysToCivRaces("order_Fabrica_GM1", "Fabrica_GM1");
human.addBuilding("order_Fabrica_GM1", 1, pPop: 10, pBuildings: 10);

// Nivel 2
BuildingAsset Fabrica_GM2 = AssetManager.buildings.clone("Fabrica_GM2", "!city_building");
Fabrica_GM2.type = "Fabrica_GM2";
Fabrica_GM2.priority = 1200;
Fabrica_GM2.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_GM2.cost = new ConstructionCost(pStone: 12, pWood: 40, pGold: 120);
Fabrica_GM2.burnable = true;
Fabrica_GM2.build_place_single = true;
Fabrica_GM2.build_place_batch = false;
Fabrica_GM2.base_stats[S.health] = 1200f;
Fabrica_GM2.base_stats[S.size] = 2f;
Fabrica_GM2.canBeLivingHouse = false;
Fabrica_GM2.buildRoadTo = true;
Fabrica_GM2.tech = "Fabrica_GM's";
Fabrica_GM2.housing = 4;
Fabrica_GM2.spawnUnits = true;
Fabrica_GM2.spawnUnits_asset = "Gamma02";
Fabrica_GM2.canBeUpgraded = true;
Fabrica_GM2.upgradeTo = "Fabrica_GM3";
Fabrica_GM2.upgradeLevel = 2;
Fabrica_GM2.upgradedFrom = "Fabrica_GM1";
AssetManager.buildings.loadSprites(Fabrica_GM2);

AddBuildingOrderKeysToCivRaces("order_Fabrica_GM2", "Fabrica_GM2");
human.addUpgrade("order_Fabrica_GM1", 0, 0, 50, 10, false, false, 0);

// Nivel 3
BuildingAsset Fabrica_GM3 = AssetManager.buildings.clone("Fabrica_GM3", "!city_building");
Fabrica_GM3.type = "Fabrica_GM3";
Fabrica_GM3.priority = 1700;
Fabrica_GM3.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_GM3.cost = new ConstructionCost(pStone: 12, pWood: 50, pGold: 145);
Fabrica_GM3.burnable = true;
Fabrica_GM3.build_place_single = true;
Fabrica_GM3.build_place_batch = false;
Fabrica_GM3.base_stats[S.health] = 1300f;
Fabrica_GM3.base_stats[S.size] = 2f;
Fabrica_GM3.canBeLivingHouse = false;
Fabrica_GM3.buildRoadTo = true;
Fabrica_GM3.tech = "Fabrica_GM's";
Fabrica_GM3.housing = 4;
Fabrica_GM3.spawnUnits = true;
Fabrica_GM3.spawnUnits_asset = "Gamma03";
Fabrica_GM3.canBeUpgraded = true;
Fabrica_GM3.upgradeTo = "Fabrica_GM4";
Fabrica_GM3.upgradeLevel = 3;
Fabrica_GM3.upgradedFrom = "Fabrica_GM2";
AssetManager.buildings.loadSprites(Fabrica_GM3);

AddBuildingOrderKeysToCivRaces("order_Fabrica_GM3", "Fabrica_GM3");
human.addUpgrade("order_Fabrica_GM2", 0, 0, 50, 10, false, false, 0);

// Nivel 4
BuildingAsset Fabrica_GM4 = AssetManager.buildings.clone("Fabrica_GM4", "!city_building");
Fabrica_GM4.type = "Fabrica_GM4";
Fabrica_GM4.priority = 2000;
Fabrica_GM4.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_GM4.cost = new ConstructionCost(pStone: 18, pWood: 60, pGold: 220);
Fabrica_GM4.burnable = true;
Fabrica_GM4.build_place_single = true;
Fabrica_GM4.build_place_batch = false;
Fabrica_GM4.base_stats[S.health] = 1400f;
Fabrica_GM4.base_stats[S.size] = 2f;
Fabrica_GM4.canBeLivingHouse = false;
Fabrica_GM4.buildRoadTo = true;
Fabrica_GM4.tech = "Fabrica_GM's";
Fabrica_GM4.housing = 4;
Fabrica_GM4.spawnUnits = true;
Fabrica_GM4.spawnUnits_asset = "Gamma04";
Fabrica_GM4.canBeUpgraded = true;
Fabrica_GM4.upgradeTo = "Fabrica_GM5";
Fabrica_GM4.upgradeLevel = 4;
Fabrica_GM4.upgradedFrom = "Fabrica_GM3";
AssetManager.buildings.loadSprites(Fabrica_GM4);

AddBuildingOrderKeysToCivRaces("order_Fabrica_GM4", "Fabrica_GM4");
human.addUpgrade("order_Fabrica_GM3", 0, 0, 50, 10, false, false, 0);

// Nivel 5 (Final)
BuildingAsset Fabrica_GM5 = AssetManager.buildings.clone("Fabrica_GM5", "!city_building");
Fabrica_GM5.type = "Fabrica_GM5";
Fabrica_GM5.priority = 2500;
Fabrica_GM5.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_GM5.cost = new ConstructionCost(pStone: 25, pWood: 70, pGold: 300);
Fabrica_GM5.burnable = true;
Fabrica_GM5.build_place_single = true;
Fabrica_GM5.build_place_batch = false;
Fabrica_GM5.base_stats[S.health] = 1500f;
Fabrica_GM5.base_stats[S.size] = 2f;
Fabrica_GM5.canBeLivingHouse = false;
Fabrica_GM5.buildRoadTo = true;
Fabrica_GM5.tech = "Fabrica_GM's";
Fabrica_GM5.housing = 4;
Fabrica_GM5.spawnUnits = true;
Fabrica_GM5.spawnUnits_asset = "Gamma05";
Fabrica_GM5.upgradeLevel = 5;
Fabrica_GM5.upgradedFrom = "Fabrica_GM4";
Fabrica_GM5.canBeUpgraded = false;
AssetManager.buildings.loadSprites(Fabrica_GM5);

AddBuildingOrderKeysToCivRaces("order_Fabrica_GM5", "Fabrica_GM5");
human.addUpgrade("order_Fabrica_GM4", 0, 0, 50, 10, false, false, 0);

// Nivel 1
BuildingAsset Fabrica_OV1 = AssetManager.buildings.clone("Fabrica_OV1", "!city_building");
Fabrica_OV1.type = "Fabrica_OV1";
Fabrica_OV1.priority = 789;
Fabrica_OV1.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OV1.cost = new ConstructionCost(pStone: 20, pWood: 40, pGold: 200);
Fabrica_OV1.burnable = true;
Fabrica_OV1.build_place_single = true;
Fabrica_OV1.build_place_batch = false;
Fabrica_OV1.base_stats[S.health] = 1500f;
Fabrica_OV1.base_stats[S.size] = 2f;
Fabrica_OV1.canBeLivingHouse = false;
Fabrica_OV1.buildRoadTo = true;
Fabrica_OV1.tech = "Fabrica_GM's";
Fabrica_OV1.housing = 4;
Fabrica_OV1.spawnUnits = true;
Fabrica_OV1.spawnUnits_asset = "Vortex01";
Fabrica_OV1.canBeUpgraded = true;
Fabrica_OV1.upgradeTo = "Fabrica_OV2";
Fabrica_OV1.upgradeLevel = 1;
Fabrica_OV1.resources_given.Add(new ResourceContainer { id = "stone", amount = 40 });
Fabrica_OV1.resources_given.Add(new ResourceContainer { id = "wood", amount = 90 });
AssetManager.buildings.loadSprites(Fabrica_OV1);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OV1", "Fabrica_OV1");
human.addBuilding("order_Fabrica_OV1", 2, pPop: 20, pBuildings: 20);

// Nivel 2
BuildingAsset Fabrica_OV2 = AssetManager.buildings.clone("Fabrica_OV2", "!city_building");
Fabrica_OV2.type = "Fabrica_OV2";
Fabrica_OV2.priority = 1100;
Fabrica_OV2.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OV2.cost = new ConstructionCost(pStone: 34, pWood: 45, pGold: 270);
Fabrica_OV2.burnable = true;
Fabrica_OV2.build_place_single = true;
Fabrica_OV2.build_place_batch = false;
Fabrica_OV2.base_stats[S.health] = 1500f;
Fabrica_OV2.base_stats[S.size] = 2f;
Fabrica_OV2.canBeLivingHouse = false;
Fabrica_OV2.buildRoadTo = true;
Fabrica_OV2.tech = "Fabrica_GM's";
Fabrica_OV2.housing = 4;
Fabrica_OV2.spawnUnits = true;
Fabrica_OV2.spawnUnits_asset = "Vortex02";
Fabrica_OV2.canBeUpgraded = true;
Fabrica_OV2.upgradeTo = "Fabrica_OV3";
Fabrica_OV2.upgradeLevel = 2;
Fabrica_OV2.upgradedFrom = "Fabrica_OV1";
AssetManager.buildings.loadSprites(Fabrica_OV2);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OV2", "Fabrica_OV2");
human.addUpgrade("order_Fabrica_OV1", 0, 0, 50, 10, false, false, 0);

// Nivel 3
BuildingAsset Fabrica_OV3 = AssetManager.buildings.clone("Fabrica_OV3", "!city_building");
Fabrica_OV3.type = "Fabrica_OV3";
Fabrica_OV3.priority = 1500;
Fabrica_OV3.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OV3.cost = new ConstructionCost(pStone: 35, pWood: 46, pGold: 290);
Fabrica_OV3.burnable = true;
Fabrica_OV3.build_place_single = true;
Fabrica_OV3.build_place_batch = false;
Fabrica_OV3.base_stats[S.health] = 1500f;
Fabrica_OV3.base_stats[S.size] = 2f;
Fabrica_OV3.canBeLivingHouse = false;
Fabrica_OV3.buildRoadTo = true;
Fabrica_OV3.tech = "Fabrica_GM's";
Fabrica_OV3.housing = 4;
Fabrica_OV3.spawnUnits = true;
Fabrica_OV3.spawnUnits_asset = "Vortex03";
Fabrica_OV3.canBeUpgraded = true;
Fabrica_OV3.upgradeTo = "Fabrica_OV4";
Fabrica_OV3.upgradeLevel = 3;
Fabrica_OV3.upgradedFrom = "Fabrica_OV2";
AssetManager.buildings.loadSprites(Fabrica_OV3);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OV3", "Fabrica_OV3");
human.addUpgrade("order_Fabrica_OV2", 0, 0, 50, 10, false, false, 0);

// Nivel 4
BuildingAsset Fabrica_OV4 = AssetManager.buildings.clone("Fabrica_OV4", "!city_building");
Fabrica_OV4.type = "Fabrica_OV4";
Fabrica_OV4.priority = 1700;
Fabrica_OV4.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OV4.cost = new ConstructionCost(pStone: 36, pWood: 47, pGold: 340);
Fabrica_OV4.burnable = true;
Fabrica_OV4.build_place_single = true;
Fabrica_OV4.build_place_batch = false;
Fabrica_OV4.base_stats[S.health] = 1500f;
Fabrica_OV4.base_stats[S.size] = 2f;
Fabrica_OV4.canBeLivingHouse = false;
Fabrica_OV4.buildRoadTo = true;
Fabrica_OV4.tech = "Fabrica_GM's";
Fabrica_OV4.housing = 4;
Fabrica_OV4.spawnUnits = true;
Fabrica_OV4.spawnUnits_asset = "Vortex04";
Fabrica_OV4.canBeUpgraded = true;
Fabrica_OV4.upgradeTo = "Fabrica_OV5";
Fabrica_OV4.upgradeLevel = 4;
Fabrica_OV4.upgradedFrom = "Fabrica_OV3";
AssetManager.buildings.loadSprites(Fabrica_OV4);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OV4", "Fabrica_OV4");
human.addUpgrade("order_Fabrica_OV3", 0, 0, 50, 10, false, false, 0);

// Nivel 5 (Final)
BuildingAsset Fabrica_OV5 = AssetManager.buildings.clone("Fabrica_OV5", "!city_building");
Fabrica_OV5.type = "Fabrica_OV5";
Fabrica_OV5.priority = 2100;
Fabrica_OV5.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OV5.cost = new ConstructionCost(pStone: 37, pWood: 48, pGold: 390);
Fabrica_OV5.burnable = true;
Fabrica_OV5.build_place_single = true;
Fabrica_OV5.build_place_batch = false;
Fabrica_OV5.base_stats[S.health] = 1500f;
Fabrica_OV5.base_stats[S.size] = 2f;
Fabrica_OV5.canBeLivingHouse = false;
Fabrica_OV5.buildRoadTo = true;
Fabrica_OV5.tech = "Fabrica_GM's";
Fabrica_OV5.housing = 4;
Fabrica_OV5.spawnUnits = true;
Fabrica_OV5.spawnUnits_asset = "Vortex05";
Fabrica_OV5.upgradeLevel = 5;
Fabrica_OV5.upgradedFrom = "Fabrica_OV4";
Fabrica_OV5.canBeUpgraded = false;
AssetManager.buildings.loadSprites(Fabrica_OV5);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OV5", "Fabrica_OV5");
human.addUpgrade("order_Fabrica_OV4", 0, 0, 50, 10, false, false, 0);

// Nivel 1: Trabuchet_Factory
BuildingAsset Trabuchet_Factory = AssetManager.buildings.clone("Trabuchet_Factory", "!city_building");
Trabuchet_Factory.type = "Trabuchet_Factory";
Trabuchet_Factory.priority = 270;
Trabuchet_Factory.fundament = new BuildingFundament(2, 2, 2, 0);
Trabuchet_Factory.cost = new ConstructionCost(pStone: 35, pWood: 50, pGold: 110);
Trabuchet_Factory.burnable = true;
Trabuchet_Factory.build_place_single = true;
Trabuchet_Factory.build_place_batch = false;
Trabuchet_Factory.base_stats[S.health] = 640f;
Trabuchet_Factory.base_stats[S.size] = 2f;
Trabuchet_Factory.canBeLivingHouse = false;
Trabuchet_Factory.buildRoadTo = true;
Trabuchet_Factory.tech = "Siegeweapons";
Trabuchet_Factory.housing = 4;
Trabuchet_Factory.spawnUnits = true;
Trabuchet_Factory.spawnUnits_asset = "Trabuchet";
Trabuchet_Factory.canBeUpgraded = true;
Trabuchet_Factory.upgradeTo = "OldFactoryTank1"; // Se actualiza a H4T
Trabuchet_Factory.upgradeLevel = 1;
AssetManager.buildings.loadSprites(Trabuchet_Factory);

AddBuildingOrderKeysToCivRaces("order_Trabuchet_Factory", "Trabuchet_Factory");
human.addBuilding("order_Trabuchet_Factory", 2, pPop: 20, pBuildings: 20);

// Nivel 2: OldFactoryTank1
BuildingAsset OldFactoryTank1 = AssetManager.buildings.clone("OldFactoryTank1", "!city_building");
OldFactoryTank1.type = "OldFactoryTank1";
OldFactoryTank1.priority = 270;
OldFactoryTank1.fundament = new BuildingFundament(2, 2, 2, 0);
OldFactoryTank1.cost = new ConstructionCost(pStone: 35, pWood: 62, pGold: 160);
OldFactoryTank1.burnable = true;
OldFactoryTank1.build_place_single = true;
OldFactoryTank1.build_place_batch = false;
OldFactoryTank1.base_stats[S.health] = 1400f;
OldFactoryTank1.base_stats[S.size] = 2f;
OldFactoryTank1.canBeLivingHouse = false;
OldFactoryTank1.buildRoadTo = true;
OldFactoryTank1.tech = "OldTanks_Factorys";
OldFactoryTank1.housing = 4;
OldFactoryTank1.spawnUnits = true;
OldFactoryTank1.spawnUnits_asset = "OldTank";
OldFactoryTank1.canBeUpgraded = true;
OldFactoryTank1.upgradeTo = "OldFactoryTank2"; // Se actualiza a H5T
OldFactoryTank1.upgradeLevel = 2;
OldFactoryTank1.upgradedFrom = "Trabuchet_Factory";
AssetManager.buildings.loadSprites(OldFactoryTank1);

AddBuildingOrderKeysToCivRaces("order_OldFactoryTank1", "OldFactoryTank1");
human.addUpgrade("order_Trabuchet_Factory", 0, 0, 50, 10, false, false, 0);

// Nivel 3: Fabrica_H4T
BuildingAsset OldFactoryTank2 = AssetManager.buildings.clone("OldFactoryTank2", "!city_building");
OldFactoryTank2.type = "OldFactoryTank2";
OldFactoryTank2.priority = 270;
OldFactoryTank2.fundament = new BuildingFundament(2, 2, 2, 0);
OldFactoryTank2.cost = new ConstructionCost(pStone: 35, pWood: 62, pGold: 180);
OldFactoryTank2.burnable = true;
OldFactoryTank2.build_place_single = true;
OldFactoryTank2.build_place_batch = false;
OldFactoryTank2.base_stats[S.health] = 1400f;
OldFactoryTank2.base_stats[S.size] = 2f;
OldFactoryTank2.canBeLivingHouse = false;
OldFactoryTank2.buildRoadTo = true;
OldFactoryTank2.tech = "OldTanks_Factorys";
OldFactoryTank2.housing = 4;
OldFactoryTank2.spawnUnits = true;
OldFactoryTank2.spawnUnits_asset = "OldTank2";
OldFactoryTank2.canBeUpgraded = true;
OldFactoryTank2.upgradeTo = "Fabrica_H4T"; // Se actualiza a H5T
OldFactoryTank2.upgradeLevel = 3;
OldFactoryTank2.upgradedFrom = "OldFactoryTank1";
AssetManager.buildings.loadSprites(OldFactoryTank2);

AddBuildingOrderKeysToCivRaces("order_OldFactoryTank2", "OldFactoryTank2");
human.addUpgrade("order_OldFactoryTank1", 0, 0, 50, 10, false, false, 0);

// Nivel 4: Fabrica_H4T
BuildingAsset Fabrica_H4T = AssetManager.buildings.clone("Fabrica_H4T", "!city_building");
Fabrica_H4T.type = "Fabrica_H4T";
Fabrica_H4T.priority = 270;
Fabrica_H4T.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_H4T.cost = new ConstructionCost(pStone: 35, pWood: 62, pGold: 210);
Fabrica_H4T.burnable = true;
Fabrica_H4T.build_place_single = true;
Fabrica_H4T.build_place_batch = false;
Fabrica_H4T.base_stats[S.health] = 1400f;
Fabrica_H4T.base_stats[S.size] = 2f;
Fabrica_H4T.canBeLivingHouse = false;
Fabrica_H4T.buildRoadTo = true;
Fabrica_H4T.tech = "TankfactoryH5T's";
Fabrica_H4T.housing = 4;
Fabrica_H4T.spawnUnits = true;
Fabrica_H4T.spawnUnits_asset = "H4T";
Fabrica_H4T.canBeUpgraded = true;
Fabrica_H4T.upgradeTo = "Fabrica_H5T"; // Se actualiza a H5T
Fabrica_H4T.upgradeLevel = 4;
Fabrica_H4T.upgradedFrom = "Trabuchet_Factory";
AssetManager.buildings.loadSprites(Fabrica_H4T);

AddBuildingOrderKeysToCivRaces("order_Fabrica_H4T", "Fabrica_H4T");
human.addUpgrade("order_OldFactoryTank2", 0, 0, 50, 10, false, false, 0);

// Nivel 5: Fabrica_H5T (Final)
BuildingAsset Fabrica_H5T = AssetManager.buildings.clone("Fabrica_H5T", "!city_building");
Fabrica_H5T.type = "Fabrica_H5T";
Fabrica_H5T.priority = 270;
Fabrica_H5T.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_H5T.cost = new ConstructionCost(pStone: 30, pWood: 60, pGold: 260);
Fabrica_H5T.burnable = true;
Fabrica_H5T.build_place_single = true;
Fabrica_H5T.build_place_batch = false;
Fabrica_H5T.base_stats[S.health] = 1500f;
Fabrica_H5T.base_stats[S.size] = 2f;
Fabrica_H5T.canBeLivingHouse = false;
Fabrica_H5T.buildRoadTo = true;
Fabrica_H5T.tech = "TankfactoryH5T's";
Fabrica_H5T.housing = 4;
Fabrica_H5T.spawnUnits = true;
Fabrica_H5T.spawnUnits_asset = "H5T";
Fabrica_H5T.upgradeLevel = 5;
Fabrica_H5T.upgradedFrom = "Fabrica_H4T";
Fabrica_H5T.canBeUpgraded = false;
AssetManager.buildings.loadSprites(Fabrica_H5T);

AddBuildingOrderKeysToCivRaces("order_Fabrica_H5T", "Fabrica_H5T");
human.addUpgrade("order_Fabrica_H4T", 0, 0, 50, 10, false, false, 0);

// Nivel 1: WagonSmall_Factory
BuildingAsset WagonSmall_Factory = AssetManager.buildings.clone("WagonSmall_Factory", "!city_building");
WagonSmall_Factory.type = "WagonSmall_Factory";
WagonSmall_Factory.priority = 270; 
WagonSmall_Factory.fundament = new BuildingFundament(2, 2, 2, 0);
WagonSmall_Factory.cost = new ConstructionCost(pStone: 30, pWood: 40, pGold: 112);
WagonSmall_Factory.burnable = true;
WagonSmall_Factory.build_place_single = true;
WagonSmall_Factory.build_place_batch = false;
WagonSmall_Factory.base_stats[S.health] = 290f;
WagonSmall_Factory.base_stats[S.size] = 2f;
WagonSmall_Factory.canBeLivingHouse = false;
WagonSmall_Factory.buildRoadTo = true;
WagonSmall_Factory.tech = "Siegeweapons";
WagonSmall_Factory.housing = 4;
WagonSmall_Factory.spawnUnits = true;
WagonSmall_Factory.spawnUnits_asset = "Combat_wagon_small";
WagonSmall_Factory.canBeUpgraded = true;
WagonSmall_Factory.upgradeTo = "WagonBig_Factory"; // Se actualiza a WagonBig_Factory
WagonSmall_Factory.upgradeLevel = 1;
AssetManager.buildings.loadSprites(WagonSmall_Factory);

AddBuildingOrderKeysToCivRaces("order_WagonSmall_Factory", "WagonSmall_Factory");
human.addBuilding("order_WagonSmall_Factory", 2, pPop: 20, pBuildings: 20);

// Nivel 2: WagonBig_Factory
BuildingAsset WagonBig_Factory = AssetManager.buildings.clone("WagonBig_Factory", "!city_building");
WagonBig_Factory.type = "WagonBig_Factory";
WagonBig_Factory.priority = 270;
WagonBig_Factory.fundament = new BuildingFundament(2, 2, 2, 0);
WagonBig_Factory.cost = new ConstructionCost(pStone: 29, pWood: 55, pGold: 110);
WagonBig_Factory.burnable = true;
WagonBig_Factory.build_place_single = true;
WagonBig_Factory.build_place_batch = false;
WagonBig_Factory.base_stats[S.health] = 440f;
WagonBig_Factory.base_stats[S.size] = 2f;
WagonBig_Factory.canBeLivingHouse = false;
WagonBig_Factory.buildRoadTo = true;
WagonBig_Factory.tech = "Siegeweapons";
WagonBig_Factory.housing = 4;
WagonBig_Factory.spawnUnits = true;
WagonBig_Factory.spawnUnits_asset = "Combat_wagon_big";
WagonBig_Factory.canBeUpgraded = true;
WagonBig_Factory.upgradeTo = "Fabrica_O1P";
WagonBig_Factory.upgradeLevel = 2;
WagonBig_Factory.upgradedFrom = "WagonSmall_Factory";
AssetManager.buildings.loadSprites(WagonBig_Factory);

AddBuildingOrderKeysToCivRaces("order_WagonBig_Factory", "WagonBig_Factory");
human.addUpgrade("order_WagonSmall_Factory", 0, 0, 50, 10, false, false, 0);

// Nivel 3: Fabrica_O1P
BuildingAsset Fabrica_O1P = AssetManager.buildings.clone("Fabrica_O1P", "!city_building");
Fabrica_O1P.type = "Fabrica_O1P";
Fabrica_O1P.priority = 270;
Fabrica_O1P.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_O1P.cost = new ConstructionCost(pStone: 20, pWood: 80, pGold: 280);
Fabrica_O1P.burnable = true;
Fabrica_O1P.build_place_single = true;
Fabrica_O1P.build_place_batch = false;
Fabrica_O1P.base_stats[S.health] = 1400f;
Fabrica_O1P.base_stats[S.size] = 2f;
Fabrica_O1P.canBeLivingHouse = false;
Fabrica_O1P.buildRoadTo = true;
Fabrica_O1P.tech = "TankfactoryOIP's";
Fabrica_O1P.housing = 4;
Fabrica_O1P.spawnUnits = true;
Fabrica_O1P.spawnUnits_asset = "O1P";
Fabrica_O1P.canBeUpgraded = true;
Fabrica_O1P.upgradeTo = "Fabrica_O2P"; 
Fabrica_O1P.upgradeLevel = 3;
Fabrica_O1P.upgradedFrom = "WagonBig_Factory";
AssetManager.buildings.loadSprites(Fabrica_O1P);

AddBuildingOrderKeysToCivRaces("order_Fabrica_O1P", "Fabrica_O1P");
human.addUpgrade("order_WagonBig_Factory", 0, 0, 50, 10, false, false, 0);

// Nivel 4: Fabrica_O2P (Final)
BuildingAsset Fabrica_O2P = AssetManager.buildings.clone("Fabrica_O2P", "!city_building");
Fabrica_O2P.type = "Fabrica_O2P";
Fabrica_O2P.priority = 270;
Fabrica_O2P.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_O2P.cost = new ConstructionCost(pStone: 20, pWood: 90, pGold: 380);
Fabrica_O2P.burnable = true;
Fabrica_O2P.build_place_single = true;
Fabrica_O2P.build_place_batch = false;
Fabrica_O2P.base_stats[S.health] = 1400f;
Fabrica_O2P.base_stats[S.size] = 2f;
Fabrica_O2P.canBeLivingHouse = false;
Fabrica_O2P.buildRoadTo = true;
Fabrica_O2P.tech = "TankfactoryOIP's";
Fabrica_O2P.housing = 4;
Fabrica_O2P.spawnUnits = true;
Fabrica_O2P.spawnUnits_asset = "O2P";
Fabrica_O2P.canBeUpgraded = false;
Fabrica_O2P.upgradeLevel = 4;
Fabrica_O2P.upgradedFrom = "Fabrica_O1P";
AssetManager.buildings.loadSprites(Fabrica_O2P);

AddBuildingOrderKeysToCivRaces("order_Fabrica_O2P", "Fabrica_O2P");
human.addUpgrade("order_Fabrica_O1P", 0, 0, 50, 10, false, false, 0);
			
// Nivel 1
BuildingAsset Fabrica_OI1 = AssetManager.buildings.clone("Fabrica_OI1", "!city_building");
Fabrica_OI1.type = "Fabrica_OI1";
Fabrica_OI1.priority = 800;
Fabrica_OI1.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OI1.cost = new ConstructionCost(pStone: 40, pWood: 70, pGold: 260);
Fabrica_OI1.burnable = true;
Fabrica_OI1.build_place_single = true;
Fabrica_OI1.build_place_batch = false;
Fabrica_OI1.base_stats[S.health] = 1000f;
Fabrica_OI1.base_stats[S.size] = 2f;
Fabrica_OI1.canBeLivingHouse = false;
Fabrica_OI1.buildRoadTo = true;
Fabrica_OI1.tech = "Fabrica_OI's";
Fabrica_OI1.housing = 4;
Fabrica_OI1.spawnUnits = true;
Fabrica_OI1.spawnUnits_asset = "Obtuni01";
Fabrica_OI1.canBeUpgraded = true;
Fabrica_OI1.upgradeTo = "Fabrica_OI2";
Fabrica_OI1.upgradeLevel = 1;
AssetManager.buildings.loadSprites(Fabrica_OI1);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OI1", "Fabrica_OI1");
human.addBuilding("order_Fabrica_OI1", 1, pPop: 10, pBuildings: 10);

// Nivel 2
BuildingAsset Fabrica_OI2 = AssetManager.buildings.clone("Fabrica_OI2", "!city_building");
Fabrica_OI2.type = "Fabrica_OI2";
Fabrica_OI2.priority = 1200;
Fabrica_OI2.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OI2.cost = new ConstructionCost(pStone: 47, pWood: 86, pGold: 270);
Fabrica_OI2.burnable = true;
Fabrica_OI2.build_place_single = true;
Fabrica_OI2.build_place_batch = false;
Fabrica_OI2.base_stats[S.health] = 1100f;
Fabrica_OI2.base_stats[S.size] = 2f;
Fabrica_OI2.canBeLivingHouse = false;
Fabrica_OI2.buildRoadTo = true;
Fabrica_OI2.tech = "Fabrica_OI's";
Fabrica_OI2.housing = 4;
Fabrica_OI2.spawnUnits = true;
Fabrica_OI2.spawnUnits_asset = "Obtuni02";
Fabrica_OI2.canBeUpgraded = true;
Fabrica_OI2.upgradeTo = "Fabrica_OI3";
Fabrica_OI2.upgradeLevel = 2;
Fabrica_OI2.upgradedFrom = "Fabrica_OI1";
AssetManager.buildings.loadSprites(Fabrica_OI2);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OI2", "Fabrica_OI2");
human.addUpgrade("order_Fabrica_OI1", 0, 0, 50, 10, false, false, 0);

// Nivel 3
BuildingAsset Fabrica_OI3 = AssetManager.buildings.clone("Fabrica_OI3", "!city_building");
Fabrica_OI3.type = "Fabrica_OI3";
Fabrica_OI3.priority = 1500;
Fabrica_OI3.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OI3.cost = new ConstructionCost(pStone: 51, pWood: 90, pGold: 280);
Fabrica_OI3.burnable = true;
Fabrica_OI3.build_place_single = true;
Fabrica_OI3.build_place_batch = false;
Fabrica_OI3.base_stats[S.health] = 1200f;
Fabrica_OI3.base_stats[S.size] = 2f;
Fabrica_OI3.canBeLivingHouse = false;
Fabrica_OI3.buildRoadTo = true;
Fabrica_OI3.tech = "Fabrica_OI's";
Fabrica_OI3.housing = 4;
Fabrica_OI3.spawnUnits = true;
Fabrica_OI3.spawnUnits_asset = "Obtuni03";
Fabrica_OI3.canBeUpgraded = true;
Fabrica_OI3.upgradeTo = "Fabrica_OI4";
Fabrica_OI3.upgradeLevel = 3;
Fabrica_OI3.upgradedFrom = "Fabrica_OI2";
AssetManager.buildings.loadSprites(Fabrica_OI3);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OI3", "Fabrica_OI3");
human.addUpgrade("order_Fabrica_OI2", 0, 0, 50, 10, false, false, 0);

// Nivel 4
BuildingAsset Fabrica_OI4 = AssetManager.buildings.clone("Fabrica_OI4", "!city_building");
Fabrica_OI4.type = "Fabrica_OI4";
Fabrica_OI4.priority = 2000;
Fabrica_OI4.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OI4.cost = new ConstructionCost(pStone: 54, pWood: 96, pGold: 290);
Fabrica_OI4.burnable = true;
Fabrica_OI4.build_place_single = true;
Fabrica_OI4.build_place_batch = false;
Fabrica_OI4.base_stats[S.health] = 1300f;
Fabrica_OI4.base_stats[S.size] = 2f;
Fabrica_OI4.canBeLivingHouse = false;
Fabrica_OI4.buildRoadTo = true;
Fabrica_OI4.tech = "Fabrica_OI's";
Fabrica_OI4.housing = 4;
Fabrica_OI4.spawnUnits = true;
Fabrica_OI4.spawnUnits_asset = "Obtuni04";
Fabrica_OI4.canBeUpgraded = true;
Fabrica_OI4.upgradeTo = "Fabrica_OI5";
Fabrica_OI4.upgradeLevel = 4;
Fabrica_OI4.upgradedFrom = "Fabrica_OI3";
AssetManager.buildings.loadSprites(Fabrica_OI4);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OI4", "Fabrica_OI4");
human.addUpgrade("order_Fabrica_OI3", 0, 0, 50, 10, false, false, 0);

// Nivel 5 (Final)
BuildingAsset Fabrica_OI5 = AssetManager.buildings.clone("Fabrica_OI5", "!city_building");
Fabrica_OI5.type = "Fabrica_OI5";
Fabrica_OI5.priority = 2700;
Fabrica_OI5.fundament = new BuildingFundament(2, 2, 2, 0);
Fabrica_OI5.cost = new ConstructionCost(pStone: 60, pWood: 98, pGold: 300);
Fabrica_OI5.burnable = true;
Fabrica_OI5.build_place_single = true;
Fabrica_OI5.build_place_batch = false;
Fabrica_OI5.base_stats[S.health] = 1400f;
Fabrica_OI5.base_stats[S.size] = 2f;
Fabrica_OI5.canBeLivingHouse = false;
Fabrica_OI5.buildRoadTo = true;
Fabrica_OI5.tech = "Fabrica_OI's";
Fabrica_OI5.housing = 4;
Fabrica_OI5.spawnUnits = true;
Fabrica_OI5.spawnUnits_asset = "Obtuni05";
Fabrica_OI5.upgradeLevel = 5;
Fabrica_OI5.upgradedFrom = "Fabrica_OI4";
Fabrica_OI5.canBeUpgraded = false;
AssetManager.buildings.loadSprites(Fabrica_OI5);

AddBuildingOrderKeysToCivRaces("order_Fabrica_OI5", "Fabrica_OI5");
human.addUpgrade("order_Fabrica_OI4", 0, 0, 50, 10, false, false, 0);

// Nivel 1
BuildingAsset Fabrica_UL = AssetManager.buildings.clone("Fabrica_UL", "!city_building");
Fabrica_UL.type = "Fabrica_UL";
Fabrica_UL.priority = 900;
Fabrica_UL.fundament = new BuildingFundament(0, 0, 0, 0);
Fabrica_UL.cost = new ConstructionCost(pStone: 20, pWood: 40, pGold: 260);
Fabrica_UL.burnable = true;
Fabrica_UL.build_place_single = true;
Fabrica_UL.build_place_batch = false;
Fabrica_UL.base_stats[S.health] = 1000f;
Fabrica_UL.base_stats[S.size] = 1f;
Fabrica_UL.canBeLivingHouse = false;
Fabrica_UL.buildRoadTo = true;
Fabrica_UL.tech = "Fabrica_UL's";
Fabrica_UL.housing = 1;
Fabrica_UL.spawnUnits = true;
Fabrica_UL.spawnUnits_asset = "Ultra01";
Fabrica_UL.canBeUpgraded = true;
Fabrica_UL.upgradeTo = "Fabrica_UL2";
Fabrica_UL.upgradeLevel = 1;
Fabrica_UL.resources_given.Add(new ResourceContainer { id = "stone", amount = 90 });
Fabrica_UL.resources_given.Add(new ResourceContainer { id = "wood", amount = 130 });
AssetManager.buildings.loadSprites(Fabrica_UL);

AddBuildingOrderKeysToCivRaces("order_Fabrica_UL", "Fabrica_UL");
human.addBuilding("order_Fabrica_UL", 1, pPop: 150, pBuildings: 30);

// Nivel 2
BuildingAsset Fabrica_UL2 = AssetManager.buildings.clone("Fabrica_UL2", "!city_building");
Fabrica_UL2.type = "Fabrica_UL2";
Fabrica_UL2.priority = 1000;
Fabrica_UL2.fundament = new BuildingFundament(0, 0, 0, 0);
Fabrica_UL2.cost = new ConstructionCost(pStone: 34, pWood: 50, pGold: 360);
Fabrica_UL2.burnable = true;
Fabrica_UL2.build_place_single = true;
Fabrica_UL2.build_place_batch = false;
Fabrica_UL2.base_stats[S.health] = 1000f;
Fabrica_UL2.base_stats[S.size] = 1f;
Fabrica_UL2.canBeLivingHouse = false;
Fabrica_UL2.buildRoadTo = true;
Fabrica_UL2.tech = "Fabrica_UL's";
Fabrica_UL2.housing = 4;
Fabrica_UL2.spawnUnits = true;
Fabrica_UL2.spawnUnits_asset = "Ultra02";
Fabrica_UL2.canBeUpgraded = true;
Fabrica_UL2.upgradeTo = "Fabrica_UL3";
Fabrica_UL2.upgradeLevel = 2;
Fabrica_UL2.upgradedFrom = "Fabrica_UL";
AssetManager.buildings.loadSprites(Fabrica_UL2);

AddBuildingOrderKeysToCivRaces("order_Fabrica_UL2", "Fabrica_UL2");
human.addUpgrade("order_Fabrica_UL", 0, 0, 50, 10, false, false, 0);

// Nivel 3
BuildingAsset Fabrica_UL3 = AssetManager.buildings.clone("Fabrica_UL3", "!city_building");
Fabrica_UL3.type = "Fabrica_UL3";
Fabrica_UL3.priority = 1700;
Fabrica_UL3.fundament = new BuildingFundament(0, 0, 0, 0);
Fabrica_UL3.cost = new ConstructionCost(pStone: 40, pWood: 60, pGold: 360);
Fabrica_UL3.burnable = true;
Fabrica_UL3.build_place_single = true;
Fabrica_UL3.build_place_batch = false;
Fabrica_UL3.base_stats[S.health] = 1000f;
Fabrica_UL3.base_stats[S.size] = 1f;
Fabrica_UL3.canBeLivingHouse = false;
Fabrica_UL3.buildRoadTo = true;
Fabrica_UL3.tech = "Fabrica_UL's";
Fabrica_UL3.housing = 1;
Fabrica_UL3.spawnUnits = true;
Fabrica_UL3.spawnUnits_asset = "Ultra03";
Fabrica_UL3.canBeUpgraded = true;
Fabrica_UL3.upgradeTo = "Fabrica_UL4";
Fabrica_UL3.upgradeLevel = 3;
Fabrica_UL3.upgradedFrom = "Fabrica_UL2";
AssetManager.buildings.loadSprites(Fabrica_UL3);

AddBuildingOrderKeysToCivRaces("order_Fabrica_UL3", "Fabrica_UL3");
human.addUpgrade("order_Fabrica_UL2", 0, 0, 50, 10, false, false, 0);

// Nivel 4
BuildingAsset Fabrica_UL4 = AssetManager.buildings.clone("Fabrica_UL4", "!city_building");
Fabrica_UL4.type = "Fabrica_UL4";
Fabrica_UL4.priority = 2000;
Fabrica_UL4.fundament = new BuildingFundament(0, 0, 0, 0);
Fabrica_UL4.cost = new ConstructionCost(pStone: 47, pWood: 65, pGold: 432);
Fabrica_UL4.burnable = true;
Fabrica_UL4.build_place_single = true;
Fabrica_UL4.build_place_batch = false;
Fabrica_UL4.base_stats[S.health] = 1000f;
Fabrica_UL4.base_stats[S.size] = 2f;
Fabrica_UL4.canBeLivingHouse = false;
Fabrica_UL4.buildRoadTo = true;
Fabrica_UL4.tech = "Fabrica_UL's";
Fabrica_UL4.housing = 1;
Fabrica_UL4.spawnUnits = true;
Fabrica_UL4.spawnUnits_asset = "Ultra04";
Fabrica_UL4.canBeUpgraded = true;
Fabrica_UL4.upgradeTo = "Fabrica_UL5";
Fabrica_UL4.upgradeLevel = 4;
Fabrica_UL4.upgradedFrom = "Fabrica_UL3";
AssetManager.buildings.loadSprites(Fabrica_UL4);

AddBuildingOrderKeysToCivRaces("order_Fabrica_UL4", "Fabrica_UL4");
human.addUpgrade("order_Fabrica_UL3", 0, 0, 50, 10, false, false, 0);

// Nivel 5 (Final)
BuildingAsset Fabrica_UL5 = AssetManager.buildings.clone("Fabrica_UL5", "!city_building");
Fabrica_UL5.type = "Fabrica_UL5";
Fabrica_UL5.priority = 2500;
Fabrica_UL5.fundament = new BuildingFundament(0, 0, 0, 0);
Fabrica_UL5.cost = new ConstructionCost(pStone: 50, pWood: 70, pGold: 470);
Fabrica_UL5.burnable = true;
Fabrica_UL5.build_place_single = true;
Fabrica_UL5.build_place_batch = false;
Fabrica_UL5.base_stats[S.health] = 1000f;
Fabrica_UL5.base_stats[S.size] = 2f;
Fabrica_UL5.canBeLivingHouse = false;
Fabrica_UL5.buildRoadTo = true;
Fabrica_UL5.tech = "Fabrica_UL's";
Fabrica_UL5.housing = 1;
Fabrica_UL5.spawnUnits = true;
Fabrica_UL5.spawnUnits_asset = "Ultra05";
Fabrica_UL5.upgradeLevel = 5;
Fabrica_UL5.upgradedFrom = "Fabrica_UL4";
Fabrica_UL5.canBeUpgraded = false;
AssetManager.buildings.loadSprites(Fabrica_UL5);

AddBuildingOrderKeysToCivRaces("order_Fabrica_UL5", "Fabrica_UL5");
human.addUpgrade("order_Fabrica_UL4", 0, 0, 50, 10, false, false, 0);

// Nivel 1: Battering Ram Factory
BuildingAsset Battering_Ram_Factory = AssetManager.buildings.clone("Battering_Ram_Factory", "!city_building");
Battering_Ram_Factory.type = "Battering_Ram_Factory";
Battering_Ram_Factory.priority = 270;
Battering_Ram_Factory.fundament = new BuildingFundament(2, 2, 2, 0);
Battering_Ram_Factory.cost = new ConstructionCost(pStone: 10, pWood: 70, pGold: 100);
Battering_Ram_Factory.burnable = true;
Battering_Ram_Factory.build_place_single = true;
Battering_Ram_Factory.build_place_batch = false;
Battering_Ram_Factory.base_stats[S.health] = 540f;
Battering_Ram_Factory.base_stats[S.size] = 2f;
Battering_Ram_Factory.canBeLivingHouse = false;
Battering_Ram_Factory.buildRoadTo = true;
Battering_Ram_Factory.tech = "Siegeweapons";
Battering_Ram_Factory.housing = 4;
Battering_Ram_Factory.spawnUnits = true;
Battering_Ram_Factory.spawnUnits_asset = "Battering_Ram";
Battering_Ram_Factory.canBeUpgraded = true;
Battering_Ram_Factory.upgradeTo = "WarMortar_Factory";
Battering_Ram_Factory.upgradeLevel = 1;
AssetManager.buildings.loadSprites(Battering_Ram_Factory);
AddBuildingOrderKeysToCivRaces("order_Battering_Ram_Factory", "Battering_Ram_Factory");
human.addBuilding("order_Battering_Ram_Factory", 2, pPop: 20, pBuildings: 20);

// Nivel 2: War Mortar Factory
BuildingAsset WarMortar_Factory = AssetManager.buildings.clone("WarMortar_Factory", "!city_building");
WarMortar_Factory.type = "WarMortar_Factory";
WarMortar_Factory.priority = 270;
WarMortar_Factory.fundament = new BuildingFundament(2, 2, 2, 0);
WarMortar_Factory.cost = new ConstructionCost(pStone: 34, pWood: 50, pGold: 180);
WarMortar_Factory.burnable = true;
WarMortar_Factory.build_place_single = true;
WarMortar_Factory.build_place_batch = false;
WarMortar_Factory.base_stats[S.health] = 300f;
WarMortar_Factory.base_stats[S.size] = 2f;
WarMortar_Factory.canBeLivingHouse = false;
WarMortar_Factory.buildRoadTo = true;
WarMortar_Factory.tech = "Siegeweapons";
WarMortar_Factory.housing = 4;
WarMortar_Factory.spawnUnits = true;
WarMortar_Factory.spawnUnits_asset = "War_Mortar";
WarMortar_Factory.canBeUpgraded = true;
WarMortar_Factory.upgradeTo = "Fabric_GunRobotMini";
WarMortar_Factory.upgradeLevel = 2;
WarMortar_Factory.upgradedFrom = "Battering_Ram_Factory";
AssetManager.buildings.loadSprites(WarMortar_Factory);
AddBuildingOrderKeysToCivRaces("order_WarMortar_Factory", "WarMortar_Factory");
human.addUpgrade("order_Battering_Ram_Factory", 0, 0, 50, 10, false, false, 0);

// Nivel 3: Fabric GunRobot Mini
BuildingAsset Fabric_GunRobotMini = AssetManager.buildings.clone("Fabric_GunRobotMini", "!city_building");
Fabric_GunRobotMini.type = "Fabric_GunRobotMini";
Fabric_GunRobotMini.priority = 300;
Fabric_GunRobotMini.fundament = new BuildingFundament(0, 0, 0, 0);
Fabric_GunRobotMini.cost = new ConstructionCost(pStone: 30, pWood: 70, pGold: 370);
Fabric_GunRobotMini.burnable = true;
Fabric_GunRobotMini.build_place_single = true;
Fabric_GunRobotMini.build_place_batch = false;
Fabric_GunRobotMini.base_stats[S.health] = 1000f;
Fabric_GunRobotMini.base_stats[S.size] = 2f;
Fabric_GunRobotMini.canBeLivingHouse = false;
Fabric_GunRobotMini.buildRoadTo = true;
Fabric_GunRobotMini.tech = "Sub_Robots";
Fabric_GunRobotMini.housing = 1;
Fabric_GunRobotMini.spawnUnits = true;
Fabric_GunRobotMini.spawnUnits_asset = "MiniRobotGun";
Fabric_GunRobotMini.canBeUpgraded = true;
Fabric_GunRobotMini.upgradeTo = "Fabrica_RobotGun2";
Fabric_GunRobotMini.upgradeLevel = 3;
Fabric_GunRobotMini.upgradedFrom = "WarMortar_Factory";
AssetManager.buildings.loadSprites(Fabric_GunRobotMini);
AddBuildingOrderKeysToCivRaces("order_Fabric_GunRobotMini", "Fabric_GunRobotMini");
human.addUpgrade("order_WarMortar_Factory", 0, 0, 50, 10, false, false, 0);

// Nivel 4: Fabrica RobotGun2
BuildingAsset Fabrica_RobotGun2 = AssetManager.buildings.clone("Fabrica_RobotGun2", "!city_building");
Fabrica_RobotGun2.type = "Fabrica_RobotGun2";
Fabrica_RobotGun2.priority = 300;
Fabrica_RobotGun2.fundament = new BuildingFundament(0, 0, 0, 0);
Fabrica_RobotGun2.cost = new ConstructionCost(pStone: 30, pWood: 70, pGold: 450);
Fabrica_RobotGun2.burnable = true;
Fabrica_RobotGun2.build_place_single = true;
Fabrica_RobotGun2.build_place_batch = false;
Fabrica_RobotGun2.base_stats[S.health] = 1000f;
Fabrica_RobotGun2.base_stats[S.size] = 2f;
Fabrica_RobotGun2.canBeLivingHouse = false;
Fabrica_RobotGun2.buildRoadTo = true;
Fabrica_RobotGun2.tech = "Sub_Robots";
Fabrica_RobotGun2.housing = 1;
Fabrica_RobotGun2.spawnUnits = true;
Fabrica_RobotGun2.spawnUnits_asset = "RobotGun2";
Fabrica_RobotGun2.canBeUpgraded = true;
Fabrica_RobotGun2.upgradeTo = "Fabrica_RobotGun";
Fabrica_RobotGun2.upgradeLevel = 4;
Fabrica_RobotGun2.upgradedFrom = "Fabric_GunRobotMini";
AssetManager.buildings.loadSprites(Fabrica_RobotGun2);
AddBuildingOrderKeysToCivRaces("order_Fabrica_RobotGun2", "Fabrica_RobotGun2");
human.addUpgrade("order_Fabric_GunRobotMini", 0, 0, 50, 10, false, false, 0);

// Nivel 5 (Final): Fabrica RobotGun
BuildingAsset Fabrica_RobotGun = AssetManager.buildings.clone("Fabrica_RobotGun", "!city_building");
Fabrica_RobotGun.type = "Fabrica_RobotGun";
Fabrica_RobotGun.priority = 300;
Fabrica_RobotGun.fundament = new BuildingFundament(0, 0, 0, 0);
Fabrica_RobotGun.cost = new ConstructionCost(pStone: 30, pWood: 70, pGold: 470);
Fabrica_RobotGun.burnable = true;
Fabrica_RobotGun.build_place_single = true;
Fabrica_RobotGun.build_place_batch = false;
Fabrica_RobotGun.base_stats[S.health] = 1000f;
Fabrica_RobotGun.base_stats[S.size] = 2f;
Fabrica_RobotGun.canBeLivingHouse = false;
Fabrica_RobotGun.buildRoadTo = true;
Fabrica_RobotGun.tech = "Sub_Robots";
Fabrica_RobotGun.housing = 1;
Fabrica_RobotGun.spawnUnits = true;
Fabrica_RobotGun.spawnUnits_asset = "RobotGun";
Fabrica_RobotGun.canBeUpgraded = false;
Fabrica_RobotGun.upgradeLevel = 5;
Fabrica_RobotGun.upgradedFrom = "Fabrica_RobotGun2";
AssetManager.buildings.loadSprites(Fabrica_RobotGun);
AddBuildingOrderKeysToCivRaces("order_Fabrica_RobotGun", "Fabrica_RobotGun");
human.addUpgrade("order_Fabrica_RobotGun2", 0, 0, 50, 10, false, false, 0);

			BuildingAsset R100Factory = AssetManager.buildings.clone("R100Factory", "!city_building");
            R100Factory.type = "R100Factory";
            R100Factory.priority = 330;
            R100Factory.fundament = new BuildingFundament(0, 0, 0, 0);
            R100Factory.cost = new ConstructionCost(pWood: 100, pGold: 870);
            R100Factory.burnable = true;
            R100Factory.build_place_single = true;
            R100Factory.build_place_batch = false;
            R100Factory.base_stats[S.health] = 500f;
            R100Factory.base_stats[S.size] = 2f;
            R100Factory.canBeLivingHouse = false;
			R100Factory.buildRoadTo = true;
			R100Factory.canBeUpgraded = true;
			R100Factory.upgradeLevel = 1;
			R100Factory.upgradeTo = "T100Factory";
			R100Factory.upgradedFrom = "Fabric_GunRobotMini";
            R100Factory.tech = "Sub_Robots";
			R100Factory.housing = 1;
			R100Factory.spawnUnits = true;
            R100Factory.spawnUnits_asset = "R100";
            R100Factory.base_stats[S.health] = 1000f;
            AssetManager.buildings.loadSprites(R100Factory);
			
			AddBuildingOrderKeysToCivRaces("order_R100Factory", "R100Factory");
            human.addBuilding("order_R100Factory", 1, pPop: 10, pBuildings: 10);

			BuildingAsset T100Factory = AssetManager.buildings.clone("T100Factory", "!city_building");
            T100Factory.type = "T100Factory";
            T100Factory.priority = 330;
            T100Factory.fundament = new BuildingFundament(0, 0, 0, 0);
            T100Factory.cost = new ConstructionCost(pWood: 100, pGold: 870);
            T100Factory.burnable = true;
            T100Factory.build_place_single = true;
            T100Factory.build_place_batch = false;
            T100Factory.base_stats[S.health] = 500f;
            T100Factory.base_stats[S.size] = 2f;
            T100Factory.canBeLivingHouse = false;
			T100Factory.buildRoadTo = true;
			T100Factory.canBeUpgraded = true;
			T100Factory.upgradeTo = "OVArE";
			T100Factory.upgradedFrom = "R100Factory";
            T100Factory.tech = "Sub_Robots";
			T100Factory.upgradeLevel = 2;
			T100Factory.housing = 1;
			T100Factory.spawnUnits = true;
            T100Factory.spawnUnits_asset = "T100";
            T100Factory.base_stats[S.health] = 1000f;
            AssetManager.buildings.loadSprites(T100Factory);
			
			AddBuildingOrderKeysToCivRaces("order_T100Factory", "T100Factory");
            human.addUpgrade("order_R100Factory", 0, 0, 50, 10, false, false, 0);
			
			BuildingAsset OVArE = AssetManager.buildings.clone("OVArE", "!city_building");
            OVArE.type = "OVArE";
            OVArE.priority = 330;
            OVArE.fundament = new BuildingFundament(0, 0, 0, 0);
            OVArE.cost = new ConstructionCost(pWood: 100, pGold: 870);
            OVArE.burnable = true;
            OVArE.build_place_single = true;
            OVArE.build_place_batch = false;
            OVArE.base_stats[S.health] = 500f;
            OVArE.base_stats[S.size] = 2f;
            OVArE.canBeLivingHouse = false;
			OVArE.canBeUpgraded = false;
			OVArE.buildRoadTo = true;
			OVArE.upgradedFrom = "T100Factory";
			OVArE.upgradeLevel = 3;
            OVArE.tech = "Sub_Robots";
			OVArE.housing = 1;
			OVArE.spawnUnits = true;
            OVArE.spawnUnits_asset = "OVA";
            OVArE.base_stats[S.health] = 1000f;
            AssetManager.buildings.loadSprites(OVArE);
			
			AddBuildingOrderKeysToCivRaces("order_OVArE", "OVArE");
            human.addUpgrade("order_T100Factory", 0, 0, 50, 10, false, false, 0); 
			
// Nivel 1: AereoPuerto_Jet01
BuildingAsset AereoPuerto_Jet01 = AssetManager.buildings.clone("AereoPuerto_Jet01", "!city_building");
AereoPuerto_Jet01.type = "AereoPuerto_Jet01";
AereoPuerto_Jet01.priority = 330;
AereoPuerto_Jet01.fundament = new BuildingFundament(0, 0, 0, 0);
AereoPuerto_Jet01.cost = new ConstructionCost(pWood: 80, pGold: 870);
AereoPuerto_Jet01.burnable = true;
AereoPuerto_Jet01.build_place_single = true;
AereoPuerto_Jet01.build_place_batch = false;
AereoPuerto_Jet01.base_stats[S.health] = 400f;
AereoPuerto_Jet01.base_stats[S.size] = 2f;
AereoPuerto_Jet01.canBeLivingHouse = false;
AereoPuerto_Jet01.buildRoadTo = true;
AereoPuerto_Jet01.tech = "Sub_Robots";
AereoPuerto_Jet01.housing = 1;
AereoPuerto_Jet01.spawnUnits = true;
AereoPuerto_Jet01.spawnUnits_asset = "Jet01";
AereoPuerto_Jet01.canBeUpgraded = true;
AereoPuerto_Jet01.upgradeTo = "AereoPuerto_Jet02"; // Se actualiza a AereoPuerto_Jet02
AereoPuerto_Jet01.upgradeLevel = 1;
AssetManager.buildings.loadSprites(AereoPuerto_Jet01);

AddBuildingOrderKeysToCivRaces("order_AereoPuerto_Jet01", "AereoPuerto_Jet01");
human.addBuilding("order_AereoPuerto_Jet01", 1, pPop: 10, pBuildings: 10); 

// Nivel 2: AereoPuerto_Jet02
BuildingAsset AereoPuerto_Jet02 = AssetManager.buildings.clone("AereoPuerto_Jet02", "!city_building");
AereoPuerto_Jet02.type = "AereoPuerto_Jet02";
AereoPuerto_Jet02.priority = 330;
AereoPuerto_Jet02.fundament = new BuildingFundament(0, 0, 0, 0);
AereoPuerto_Jet02.cost = new ConstructionCost(pWood: 120, pGold: 900); // Ajusta el costo según lo necesites
AereoPuerto_Jet02.burnable = true;
AereoPuerto_Jet02.build_place_single = true;
AereoPuerto_Jet02.build_place_batch = false;
AereoPuerto_Jet02.base_stats[S.health] = 500f;
AereoPuerto_Jet02.base_stats[S.size] = 2f;
AereoPuerto_Jet02.canBeLivingHouse = false;
AereoPuerto_Jet02.buildRoadTo = true;
AereoPuerto_Jet02.tech = "Sub_Robots";
AereoPuerto_Jet02.housing = 1;
AereoPuerto_Jet02.spawnUnits = true;
AereoPuerto_Jet02.spawnUnits_asset = "Jet02";
AereoPuerto_Jet02.canBeUpgraded = false;
AereoPuerto_Jet02.upgradeLevel = 2;
AereoPuerto_Jet02.upgradedFrom = "AereoPuerto_Jet01";
AssetManager.buildings.loadSprites(AereoPuerto_Jet02);

AddBuildingOrderKeysToCivRaces("order_AereoPuerto_Jet02", "AereoPuerto_Jet02");
human.addUpgrade("order_AereoPuerto_Jet01", 0, 0, 50, 10, false, false, 0);

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
