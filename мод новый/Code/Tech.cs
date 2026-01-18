using System;
using System.Reflection;
using NCMS;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using NCMS.Utils;
using System.Runtime.CompilerServices;
using DG.Tweening;
using EpPathFinding.cs;
using life.taxi;
using SleekRender;
using tools.debug;
using UnityEngine.EventSystems;
using WorldBoxConsole;
using Newtonsoft.Json;
using UnityEngine.Scripting;
using System.ComponentModel;

 namespace AmbientWar
 { public class Tech
  {
    public static void init(){

            CultureTechAsset OldTanks = new CultureTechAsset();
            OldTanks.id = "OldTanks_Factorys";
            OldTanks.path_icon = "OldTanks_Factory";
            OldTanks.priority = false;
            OldTanks.required_level = 35; 
            LocalizedTextManager.getText("tech_OldTanks_Factorys");
			OldTanks.requirements = new List<string> { "ModernGuns" };
            OldTanks.stats.bonus_max_army.add(2f);
            AssetManager.culture_tech.add(OldTanks); 

            CultureTechAsset Industria = new CultureTechAsset();
            Industria.id = "Industria_HT's";
            Industria.path_icon = "Industria_HT";
            Industria.priority = false;
            Industria.required_level = 35; 
            LocalizedTextManager.getText("tech_Industria_HT's");
			Industria.requirements = new List<string> { "Sub_Robots" };
            Industria.stats.bonus_max_army.add(2f);
            AssetManager.culture_tech.add(Industria);
			
            CultureTechAsset Fabrica = new CultureTechAsset();
            Fabrica.id = "Fabrica_OP's";
            Fabrica.path_icon = "Fabrica_OP";
            Fabrica.priority = false;
            Fabrica.required_level = 45;
            LocalizedTextManager.getText("tech_Fabrica_OP's");
            Fabrica.stats.bonus_max_army.add(2f);
			Fabrica.requirements = new List<string> { "Industria_HT's" };
            AssetManager.culture_tech.add(Fabrica);
			
            CultureTechAsset FabricaOM = new CultureTechAsset();
            FabricaOM.id = "Fabrica_OM's";
            FabricaOM.path_icon = "Fabrica_OM";
            FabricaOM.priority = false;
            FabricaOM.required_level = 45;
            LocalizedTextManager.getText("tech_Fabrica_OM's");
            FabricaOM.stats.bonus_max_army.add(2f);
			FabricaOM.requirements = new List<string> { "Fabrica_OP's" };
            AssetManager.culture_tech.add(FabricaOM);
			
            CultureTechAsset FabricaGM = new CultureTechAsset();
            FabricaGM.id = "Fabrica_GM's";
            FabricaGM.path_icon = "Fabrica_GM";
            FabricaGM.priority = false;
            FabricaGM.required_level = 40;
            LocalizedTextManager.getText("tech_Fabrica_GM's");
            FabricaGM.stats.bonus_max_army.add(2f);
			FabricaGM.requirements = new List<string> { "Fabrica_OM's" }; 
            AssetManager.culture_tech.add(FabricaGM);
			
            CultureTechAsset FabricaOV = new CultureTechAsset();
            FabricaOV.id = "Fabrica_OV's";
            FabricaOV.path_icon = "Fabrica_OV";
            FabricaOV.priority = false;
            FabricaOV.required_level = 40;
            LocalizedTextManager.getText("tech_Fabrica_OV's");
            FabricaOV.stats.bonus_max_army.add(2f);
			FabricaOV.requirements = new List<string> { "Fabrica_GM's" }; 
            AssetManager.culture_tech.add(FabricaOV);
			
            CultureTechAsset FabricaOI = new CultureTechAsset();
            FabricaOI.id = "Fabrica_OI's";
            FabricaOI.path_icon = "Fabrica_OI";
            FabricaOI.priority = false;
            FabricaOI.required_level = 40;
            LocalizedTextManager.getText("tech_Fabrica_OI's");
            FabricaOI.stats.bonus_max_army.add(2f);
			FabricaOI.requirements = new List<string> { "Fabrica_OV's" }; 
            AssetManager.culture_tech.add(FabricaOI);
			
            CultureTechAsset FabricaUL = new CultureTechAsset();
            FabricaUL.id = "Fabrica_UL's";
            FabricaUL.path_icon = "Fabrica_UL";
            FabricaUL.priority = false;
            FabricaUL.required_level = 44;
            LocalizedTextManager.getText("tech_Fabrica_UL's");
            FabricaUL.stats.bonus_max_army.add(2f);
			FabricaUL.requirements = new List<string> { "Fabrica_OP's" }; 
            AssetManager.culture_tech.add(FabricaUL);
			
            CultureTechAsset TankfactoryH5T = new CultureTechAsset();
            TankfactoryH5T.id = "TankfactoryH5T's";
            TankfactoryH5T.path_icon = "Tank_factory_H5T";
            TankfactoryH5T.priority = false;
            TankfactoryH5T.required_level = 40;
            LocalizedTextManager.getText("tech_TankfactoryH5T's");
            TankfactoryH5T.stats.bonus_max_army.add(2f);
			TankfactoryH5T.requirements = new List<string> { "TankfactoryOIP's" }; 
            AssetManager.culture_tech.add(TankfactoryH5T);
			
			CultureTechAsset TankfactoryOIP = new CultureTechAsset();
            TankfactoryOIP.id = "TankfactoryOIP's";
            TankfactoryOIP.path_icon = "Tank_factory_OIP";
            TankfactoryOIP.priority = false;
            TankfactoryOIP.required_level = 40;
            LocalizedTextManager.getText("tech_TankfactoryOIP's");
            TankfactoryOIP.stats.bonus_max_army.add(2f);
			TankfactoryOIP.requirements = new List<string> { "OldTanks_Factorys" }; 
            AssetManager.culture_tech.add(TankfactoryOIP);
			
			CultureTechAsset Siegeweapons = new CultureTechAsset();
            Siegeweapons.id = "Siegeweapons";
            Siegeweapons.path_icon = "Siege_Weapons";
            Siegeweapons.priority = false;
            Siegeweapons.required_level = 20;
            LocalizedTextManager.getText("tech_Siegeweapons");
            Siegeweapons.stats.bonus_max_army.add(2f);
			Siegeweapons.requirements = new List<string> { "material_iron" }; 
            AssetManager.culture_tech.add(Siegeweapons);
			
			CultureTechAsset WeaponsPlus = new CultureTechAsset();
            WeaponsPlus.id = "WeaponsPlus";
            WeaponsPlus.path_icon = "Weapons_Plus";
            WeaponsPlus.priority = false;
            WeaponsPlus.required_level = 20;
            LocalizedTextManager.getText("tech_WeaponsPlus");
            WeaponsPlus.stats.bonus_max_army.add(2f);
			WeaponsPlus.requirements = new List<string> { "Siegeweapons" }; 
            AssetManager.culture_tech.add(WeaponsPlus);
			
			CultureTechAsset OldGuns = new CultureTechAsset();
            OldGuns.id = "OldGuns";
            OldGuns.path_icon = "Old_Guns";
            OldGuns.priority = false;
            OldGuns.required_level = 20;
            LocalizedTextManager.getText("tech_OldGuns");
            OldGuns.stats.bonus_max_army.add(2f);
			OldGuns.requirements = new List<string> { "Siegeweapons" }; 
            AssetManager.culture_tech.add(OldGuns);
			
			CultureTechAsset ModernGuns = new CultureTechAsset();
            ModernGuns.id = "ModernGuns";
            ModernGuns.path_icon = "Modern_Guns";
            ModernGuns.priority = false;
            ModernGuns.required_level = 20;
            LocalizedTextManager.getText("tech_ModernGuns");
            ModernGuns.stats.bonus_max_army.add(2f);
			ModernGuns.requirements = new List<string> { "OldGuns" }; 
            AssetManager.culture_tech.add(ModernGuns);
			
			CultureTechAsset SubRobots = new CultureTechAsset();
            SubRobots.id = "Sub_Robots";
            SubRobots.path_icon = "Sub_Robots";
            SubRobots.priority = false;
            SubRobots.required_level = 20;
            LocalizedTextManager.getText("tech_Sub_Robots");
            SubRobots.stats.bonus_max_army.add(2f);
			SubRobots.requirements = new List<string> { "ModernGuns" }; 
            AssetManager.culture_tech.add(SubRobots);
			
			CultureTechAsset FuturisticGuns = new CultureTechAsset();
            FuturisticGuns.id = "FuturisticGuns";
            FuturisticGuns.path_icon = "Futuristic_Guns";
            FuturisticGuns.priority = false;
            FuturisticGuns.required_level = 20;
            LocalizedTextManager.getText("tech_FuturisticGuns");
            FuturisticGuns.stats.bonus_max_army.add(2f);
			FuturisticGuns.requirements = new List<string> { "Industria_HT's" }; 
            AssetManager.culture_tech.add(FuturisticGuns);
			
			CultureTechAsset technotite_tech = new CultureTechAsset();
            technotite_tech.id = "material_technotite";
            technotite_tech.path_icon = "tech/TechnotiteTech";
            technotite_tech.required_level = 50;
			LocalizedTextManager.getText("tech_material_technotite");
            technotite_tech.requirements = new List<string> { "material_adamantine" }; 
            AssetManager.culture_tech.add(technotite_tech);
			
		
        }
    }
}


 