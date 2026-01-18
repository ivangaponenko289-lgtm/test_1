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
    public class ConstruccionesUP
    {
        public void init()
{
    RaceBuildOrderAsset human = AssetManager.race_build_orders.get("kingdom_base");

    // Crear el edificio mejorado primero
    BuildingAsset Fabric_Aegis2 = AssetManager.buildings.clone("Fabric_Aegis2", "!city_building");
    Fabric_Aegis2.type = "Fabric_Aegis2";
    Fabric_Aegis2.priority = 330;
    Fabric_Aegis2.fundament = new BuildingFundament(0, 0, 0, 0);
    Fabric_Aegis2.cost = new ConstructionCost(pWood: 120, pGold: 1000);
    Fabric_Aegis2.burnable = true;
    Fabric_Aegis2.build_place_single = true;
    Fabric_Aegis2.build_place_batch = false;
    Fabric_Aegis2.base_stats[S.health] = 700f;
    Fabric_Aegis2.base_stats[S.size] = 2f;
    Fabric_Aegis2.canBeLivingHouse = false;
    Fabric_Aegis2.buildRoadTo = true;
    Fabric_Aegis2.tech = "Sub_Robots";
    Fabric_Aegis2.housing = 2;
    Fabric_Aegis2.spawnUnits = true;
    Fabric_Aegis2.spawnUnits_asset = "Aegis02";
    Fabric_Aegis2.upgradeLevel = 2;
    Fabric_Aegis2.upgradedFrom = "Fabric_Aegis";  // <--- Agregado
    AssetManager.buildings.loadSprites(Fabric_Aegis2);

    // Crear el edificio base
    BuildingAsset Fabric_Aegis = AssetManager.buildings.clone("Fabric_Aegis", "!city_building");
    Fabric_Aegis.type = "Fabric_Aegis";
    Fabric_Aegis.priority = 330;
    Fabric_Aegis.fundament = new BuildingFundament(0, 0, 0, 0);
    Fabric_Aegis.cost = new ConstructionCost(pWood: 80, pGold: 870);
    Fabric_Aegis.burnable = true;
    Fabric_Aegis.build_place_single = true;
    Fabric_Aegis.build_place_batch = false;
    Fabric_Aegis.base_stats[S.health] = 500f;
    Fabric_Aegis.base_stats[S.size] = 2f;
    Fabric_Aegis.canBeUpgraded = true;
    Fabric_Aegis.upgradeTo = "Fabric_Aegis2";
    Fabric_Aegis.upgradeLevel = 1;
    Fabric_Aegis.canBeLivingHouse = false;
    Fabric_Aegis.buildRoadTo = true;
    Fabric_Aegis.tech = "Sub_Robots";
    Fabric_Aegis.housing = 1;
    Fabric_Aegis.spawnUnits = true;
    Fabric_Aegis.spawnUnits_asset = "Aegis";
    AssetManager.buildings.loadSprites(Fabric_Aegis);

    // Agregar edificios al orden de construcción
    AddBuildingOrderKeysToCivRaces("order_Fabric_Aegis", "Fabric_Aegis");
    human.addBuilding("order_Fabric_Aegis", 1, 10, 10, 0, false, false, 0);

    // Agregar la mejora en la orden de construcción
    AddBuildingOrderKeysToCivRaces("order_Fabric_Aegis2", "Fabric_Aegis2");
    human.addUpgrade("order_Fabric_Aegis", 0, 0, 50, 10, false, false, 0);
}

        private void AddBuildingOrderKeysToCivRaces(string key, string value)
        {
            foreach (Race race in AssetManager.raceLibrary.list.Where(race => race.civilization))
            {
                race.building_order_keys[key] = value;
            }
        }
    }
}
