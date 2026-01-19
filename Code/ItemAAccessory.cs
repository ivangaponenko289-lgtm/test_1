using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionUtility;
 
namespace AmbientWar
{
    class ItemAAccssesory
    {
      public static void init()
        {
		    ItemAsset technotite = new ItemAsset();
            technotite.id = "technotite";
            technotite.equipment_value = 100;
            technotite.tech_needed = "material_technotite";
            technotite.setCost(0, "technotite", 1);
            technotite.base_stats[S.critical_chance] = 0.15f;
            technotite.base_stats[S.critical_damage_multiplier] = 10f;
			AssetManager.items_material_accessory.add(technotite);
			AssetManager.items_material_accessory.add(AssetManager.items_material_accessory.get("technotite"));
        }
  } 
	
}
