using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionUtility;
 
namespace AmbientWar
{
    class ItemAArmor
    {
                public static void init()
        {
			ItemAsset technotite = new ItemAsset();
            technotite.id = "technotite";
            technotite.equipment_value = 90;
			technotite.metallic = true;
            technotite.tech_needed = "material_technotite";
            technotite.setCost(0, "technotite", 1);
            technotite.base_stats[S.armor] = 15;
			AssetManager.items_material_armor.add(technotite);
			AssetManager.items_material_armor.add(AssetManager.items_material_armor.get("technotite"));
			}
    }
}
