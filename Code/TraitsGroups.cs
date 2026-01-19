using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReflectionUtility;
 
namespace AmbientWar
{
    class TraitGroups
    {
 
        public static string AmbientWar = "AmbientWar";
		public static string RobotsSkill = "RobotsSkill";
		public static string ConceRasgos = "ConceRasgos";
 
        public static void init()
        {
         
 
            ActorTraitGroupAsset AmbientWar = new ActorTraitGroupAsset();
            AmbientWar.id = "AmbientWar";
            AmbientWar.name = "trait_group_AmbientWar";
            AmbientWar.color = Toolbox.makeColor("#9EFFFF", -1f);
            AssetManager.trait_groups.add(AmbientWar);
			
            ActorTraitGroupAsset RobotsSkill = new ActorTraitGroupAsset();
            RobotsSkill.id = "RobotsSkill";
            RobotsSkill.name = "trait_group_RobotsSkill";
            RobotsSkill.color = Toolbox.makeColor("#7888CC", -1f);
            AssetManager.trait_groups.add(RobotsSkill);
			
            ActorTraitGroupAsset ConceRasgos = new ActorTraitGroupAsset();
            ConceRasgos.id = "ConceRasgos";
            ConceRasgos.name = "trait_group_ConceRasgos";
            ConceRasgos.color = Toolbox.makeColor("#243344", -1f);
            AssetManager.trait_groups.add(ConceRasgos);
 

        }
    }
}
