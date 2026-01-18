using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionUtility;
 
namespace AmbientWar
{
    class ItemAWeapon
    {
                         public static void init()
        {
			ItemAsset technotite = new ItemAsset();
            technotite.id = "technotite";
			technotite.metallic = true;
            technotite.equipment_value = 90;
            technotite.tech_needed = "material_technotite";
            technotite.setCost(0, "technotite", 1);
            technotite.base_stats[S.damage] = 25;
            technotite.base_stats[S.attack_speed] = 10f;
            technotite.base_stats[S.critical_damage_multiplier] = 10f;
            AssetManager.items_material_weapon.add(technotite);
			AssetManager.items_material_weapon.add(AssetManager.items_material_weapon.get("technotite"));
			}
    }
}
