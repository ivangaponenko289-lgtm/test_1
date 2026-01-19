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

namespace AmbientWar
{
    class ResourcesNew
    {
        public static void init()
        {
            BehGetResourcesFromMine.addToPool("mineral_technotite", 2, BehGetResourcesFromMine.pool_mineral_assets_default);
			BehGetResourcesFromMine.addToPool("mineral_gems", 1, BehGetResourcesFromMine.pool_mineral_assets_default);
			BehGetResourcesFromMine.addToPool("mineral_gold", 4, BehGetResourcesFromMine.pool_mineral_assets_default);
			BehGetResourcesFromMine.addToPool("mineral_stone", 20, BehGetResourcesFromMine.pool_mineral_assets_default);
			BehGetResourcesFromMine.addToPool("mineral_metals", 10, BehGetResourcesFromMine.pool_mineral_assets_default);		

            ResourceAsset technotite = new ResourceAsset
            {
                id = "technotite",
                path_icon = "iconRestechnotite",
                path_unit_item = "technotite",
                type = ResType.Strategic,
                mineral = true
            };
            AssetManager.resources.add(technotite);
            BuildingAsset technotiteB = AssetManager.buildings.clone("mineral_technotite", "!rock_temp");
            technotiteB.sparkle_effect = true;
            addResourceNew(technotiteB, "technotite", 3, false);
            // technotiteB.sfx = "spawn_ore_deposit";
            AssetManager.buildings.add(technotiteB);
            AssetManager.buildings.loadSprites(technotiteB);
        }

        public static void addResourceNew(BuildingAsset building, string pID, int pAmount, bool pNewList = false)
        {
            if (building.resources_given == null || pNewList)
            {
                building.resources_given = new List<ResourceContainer>();
            }
            building.resources_given.Add(new ResourceContainer
            {
                id = pID,
                amount = pAmount
            });
        }
  }
}

