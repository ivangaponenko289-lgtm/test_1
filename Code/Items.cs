using System;
using NCMS;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using NCMS.Utils;
 
namespace AmbientWar
{
    class Items
    {
        public static void init()
        {
 
          craftitems();
          
 
          ItemAsset ArmaduradeAcero = AssetManager.items.clone("ArmaduradeAcero", "_equipment");
          ArmaduradeAcero.id = "ArmaduradeAcero";
          ArmaduradeAcero.base_stats[S.armor] = 9;
          ArmaduradeAcero.equipmentType = EquipmentType.Armor;
          ArmaduradeAcero.name_class = "item_class_armor";
          ArmaduradeAcero.name_templates = List.Of<string>(new string[]{ "armor_name" });
          ArmaduradeAcero.materials = List.Of<string>(new string[]{ "steel" });
          ArmaduradeAcero.tech_needed = "material_steel";
          ArmaduradeAcero.equipment_value = 0;
          AssetManager.items.list.AddItem(ArmaduradeAcero);
          Localization.addLocalization("item_ArmaduradeAcero", "Armadura de Acero");
 
  
          ItemAsset BotasdeAcero= AssetManager.items.clone("BotasdeAcero", "_equipment");
          BotasdeAcero.id = "BotasdeAcero";
          BotasdeAcero.base_stats[S.armor] = 9;
          BotasdeAcero.equipmentType = EquipmentType.Boots;
          BotasdeAcero.name_class = "item_class_armor";
          BotasdeAcero.name_templates = List.Of<string>(new string[]{ "boots_name" });
          BotasdeAcero.materials = List.Of<string>(new string[]{ "steel" });
          BotasdeAcero.tech_needed = "material_steel";
          BotasdeAcero.equipment_value = 0;
          AssetManager.items.list.AddItem(BotasdeAcero);
          Localization.addLocalization("item_BotasdeAcero", "Botas de Acero");
 
  
          ItemAsset CascodeAcero = AssetManager.items.clone("CascodeAcero", "_equipment");
          CascodeAcero.id = "CascodeAcero";
          CascodeAcero.base_stats[S.armor] = 9;
          CascodeAcero.equipmentType = EquipmentType.Helmet;
          CascodeAcero.name_class = "item_class_armor";
          CascodeAcero.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          CascodeAcero.materials = List.Of<string>(new string[]{ "steel" });
          CascodeAcero.tech_needed = "material_steel";
          CascodeAcero.equipment_value = 0;
          AssetManager.items.list.AddItem(CascodeAcero);
          Localization.addLocalization("item_CascodeAcero", "Casco de Acero");
 
  
          ItemAsset ArmaduradeAdamantito = AssetManager.items.clone("ArmaduradeAdamantito", "_equipment");
          ArmaduradeAdamantito.id = "ArmaduradeAdamantito";
          ArmaduradeAdamantito.base_stats[S.fertility] = 0.0f;
          ArmaduradeAdamantito.base_stats[S.max_children] = 0f;
          ArmaduradeAdamantito.base_stats[S.max_age] = 0f;
          ArmaduradeAdamantito.base_stats[S.attack_speed] = 0;
          ArmaduradeAdamantito.base_stats[S.damage] = 0;
          ArmaduradeAdamantito.base_stats[S.speed] = 0f;
          ArmaduradeAdamantito.base_stats[S.health] = 0;
          ArmaduradeAdamantito.base_stats[S.accuracy] = 0f;
          ArmaduradeAdamantito.base_stats[S.range] = 0;
          ArmaduradeAdamantito.base_stats[S.armor] = 11;
          ArmaduradeAdamantito.base_stats[S.scale] = 0.0f;
          ArmaduradeAdamantito.base_stats[S.dodge] = 0f;
          ArmaduradeAdamantito.base_stats[S.targets] = 0f;
          ArmaduradeAdamantito.base_stats[S.critical_chance] = 0.0f;
          ArmaduradeAdamantito.base_stats[S.knockback] = 0.0f;
          ArmaduradeAdamantito.base_stats[S.knockback_reduction] = 0.0f;
          ArmaduradeAdamantito.base_stats[S.intelligence] = 0;
          ArmaduradeAdamantito.base_stats[S.warfare] = 0;
          ArmaduradeAdamantito.base_stats[S.diplomacy] = 0;
          ArmaduradeAdamantito.base_stats[S.stewardship] = 0;
          ArmaduradeAdamantito.base_stats[S.opinion] = 0f;
          ArmaduradeAdamantito.base_stats[S.loyalty_traits] = 0f;
          ArmaduradeAdamantito.base_stats[S.cities] = 0;
          ArmaduradeAdamantito.base_stats[S.zone_range] = 0;
          ArmaduradeAdamantito.equipmentType = EquipmentType.Armor;
          ArmaduradeAdamantito.name_class = "item_class_armor";
          ArmaduradeAdamantito.name_templates = List.Of("armor_name");
          ArmaduradeAdamantito.materials = List.Of<string>(new string[]{ "adamantine" });
          ArmaduradeAdamantito.tech_needed = "material_adamantine";
          ArmaduradeAdamantito.equipment_value = 0;
          AssetManager.items.list.AddItem(ArmaduradeAdamantito);
          Localization.addLocalization("item_ArmaduradeAdamantito", "Armadura de Adamantito");
 
  
          ItemAsset BotasdeAdamantito = AssetManager.items.clone("BotasdeAdamantito", "_equipment");
          BotasdeAdamantito.id = "BotasdeAdamantito";
          BotasdeAdamantito.base_stats[S.fertility] = 0.0f;
          BotasdeAdamantito.base_stats[S.max_children] = 0f;
          BotasdeAdamantito.base_stats[S.max_age] = 0f;
          BotasdeAdamantito.base_stats[S.attack_speed] = 0;
          BotasdeAdamantito.base_stats[S.damage] = 0;
          BotasdeAdamantito.base_stats[S.speed] = 0f;
          BotasdeAdamantito.base_stats[S.health] = 0;
          BotasdeAdamantito.base_stats[S.accuracy] = 0f;
          BotasdeAdamantito.base_stats[S.range] = 0;
          BotasdeAdamantito.base_stats[S.armor] = 11;
          BotasdeAdamantito.base_stats[S.scale] = 0.0f;
          BotasdeAdamantito.base_stats[S.dodge] = 0f;
          BotasdeAdamantito.base_stats[S.targets] = 0f;
          BotasdeAdamantito.base_stats[S.critical_chance] = 0.0f;
          BotasdeAdamantito.base_stats[S.knockback] = 0.0f;
          BotasdeAdamantito.base_stats[S.knockback_reduction] = 0.0f;
          BotasdeAdamantito.base_stats[S.intelligence] = 0;
          BotasdeAdamantito.base_stats[S.warfare] = 0;
          BotasdeAdamantito.base_stats[S.diplomacy] = 0;
          BotasdeAdamantito.base_stats[S.stewardship] = 0;
          BotasdeAdamantito.base_stats[S.opinion] = 0f;
          BotasdeAdamantito.base_stats[S.loyalty_traits] = 0f;
          BotasdeAdamantito.base_stats[S.cities] = 0;
          BotasdeAdamantito.base_stats[S.zone_range] = 0;
          BotasdeAdamantito.equipmentType = EquipmentType.Boots;
          BotasdeAdamantito.name_class = "item_class_armor";
          BotasdeAdamantito.name_templates = List.Of<string>(new string[]{ "boots_name" });
          BotasdeAdamantito.materials = List.Of<string>(new string[]{ "adamantine" });
          BotasdeAdamantito.tech_needed = "material_adamantine";
          BotasdeAdamantito.equipment_value = 0;
          AssetManager.items.list.AddItem(BotasdeAdamantito);
          Localization.addLocalization("item_BotasdeAdamantito", "Botas de Adamantito");
 
  
          ItemAsset CascodeAdamantito = AssetManager.items.clone("CascodeAdamantito", "_equipment");
          CascodeAdamantito.id = "CascodeAdamantito";
          CascodeAdamantito.base_stats[S.fertility] = 0.0f;
          CascodeAdamantito.base_stats[S.max_children] = 0f;
          CascodeAdamantito.base_stats[S.max_age] = 0f;
          CascodeAdamantito.base_stats[S.attack_speed] = 0;
          CascodeAdamantito.base_stats[S.damage] = 0;
          CascodeAdamantito.base_stats[S.speed] = 0f;
          CascodeAdamantito.base_stats[S.health] = 0;
          CascodeAdamantito.base_stats[S.accuracy] = 0f;
          CascodeAdamantito.base_stats[S.range] = 0;
          CascodeAdamantito.base_stats[S.armor] = 11;
          CascodeAdamantito.base_stats[S.scale] = 0.0f;
          CascodeAdamantito.base_stats[S.dodge] = 0f;
          CascodeAdamantito.base_stats[S.targets] = 0f;
          CascodeAdamantito.base_stats[S.critical_chance] = 0.0f;
          CascodeAdamantito.base_stats[S.knockback] = 0.0f;
          CascodeAdamantito.base_stats[S.knockback_reduction] = 0.0f;
          CascodeAdamantito.base_stats[S.intelligence] = 0;
          CascodeAdamantito.base_stats[S.warfare] = 0;
          CascodeAdamantito.base_stats[S.diplomacy] = 0;
          CascodeAdamantito.base_stats[S.stewardship] = 0;
          CascodeAdamantito.base_stats[S.opinion] = 0f;
          CascodeAdamantito.base_stats[S.loyalty_traits] = 0f;
          CascodeAdamantito.base_stats[S.cities] = 0;
          CascodeAdamantito.base_stats[S.zone_range] = 0;
          CascodeAdamantito.equipmentType = EquipmentType.Helmet;
          CascodeAdamantito.name_class = "item_class_armor";
          CascodeAdamantito.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          CascodeAdamantito.materials = List.Of<string>(new string[]{ "adamantine" });
          CascodeAdamantito.tech_needed = "material_adamantine";
          CascodeAdamantito.equipment_value = 0;
          AssetManager.items.list.AddItem(CascodeAdamantito);
          Localization.addLocalization("item_CascodeAdamantito", "Casco de Adamantito");
 
  
          ItemAsset ArmaduradeBronze = AssetManager.items.clone("ArmaduradeBronze", "_equipment");
          ArmaduradeBronze.id = "ArmaduradeBronze";
          ArmaduradeBronze.base_stats[S.fertility] = 0.0f;
          ArmaduradeBronze.base_stats[S.max_children] = 0f;
          ArmaduradeBronze.base_stats[S.max_age] = 0f;
          ArmaduradeBronze.base_stats[S.attack_speed] = 0;
          ArmaduradeBronze.base_stats[S.damage] = 0;
          ArmaduradeBronze.base_stats[S.speed] = 0f;
          ArmaduradeBronze.base_stats[S.health] = 0;
          ArmaduradeBronze.base_stats[S.accuracy] = 0f;
          ArmaduradeBronze.base_stats[S.range] = 0;
          ArmaduradeBronze.base_stats[S.armor] = 6;
          ArmaduradeBronze.equipmentType = EquipmentType.Armor;
          ArmaduradeBronze.name_class = "item_class_armor";
          ArmaduradeBronze.name_templates = List.Of<string>(new string[]{ "armor_name" });
          ArmaduradeBronze.materials = List.Of<string>(new string[]{ "bronze" });
          ArmaduradeBronze.tech_needed = "material_bronze";
          ArmaduradeBronze.equipment_value = 0;
          AssetManager.items.list.AddItem(ArmaduradeBronze);
          Localization.addLocalization("item_ArmaduradeBronze", "Armadura de Bronze");
 
  
          ItemAsset BotasdeBronze = AssetManager.items.clone("BotasdeBronze", "_equipment");
          BotasdeBronze.id = "BotasdeBronze";
          BotasdeBronze.base_stats[S.fertility] = 0.0f;
          BotasdeBronze.base_stats[S.max_children] = 0f;
          BotasdeBronze.base_stats[S.max_age] = 0f;
          BotasdeBronze.base_stats[S.attack_speed] = 0;
          BotasdeBronze.base_stats[S.damage] = 0;
          BotasdeBronze.base_stats[S.speed] = 0f;
          BotasdeBronze.base_stats[S.health] = 0;
          BotasdeBronze.base_stats[S.accuracy] = 0f;
          BotasdeBronze.base_stats[S.range] = 0;
          BotasdeBronze.base_stats[S.armor] = 6;
          BotasdeBronze.base_stats[S.scale] = 0.0f;
          BotasdeBronze.base_stats[S.dodge] = 0f;
          BotasdeBronze.base_stats[S.targets] = 0f;
          BotasdeBronze.base_stats[S.critical_chance] = 0.0f;
          BotasdeBronze.base_stats[S.knockback] = 0.0f;
          BotasdeBronze.base_stats[S.knockback_reduction] = 0.0f;
          BotasdeBronze.base_stats[S.intelligence] = 0;
          BotasdeBronze.base_stats[S.warfare] = 0;
          BotasdeBronze.base_stats[S.diplomacy] = 0;
          BotasdeBronze.base_stats[S.stewardship] = 0;
          BotasdeBronze.base_stats[S.opinion] = 0f;
          BotasdeBronze.base_stats[S.loyalty_traits] = 0f;
          BotasdeBronze.base_stats[S.cities] = 0;
          BotasdeBronze.base_stats[S.zone_range] = 0;
          BotasdeBronze.equipmentType = EquipmentType.Boots;
          BotasdeBronze.name_class = "item_class_armor";
          BotasdeBronze.name_templates = List.Of<string>(new string[]{ "boots_name" });
          BotasdeBronze.materials = List.Of<string>(new string[]{ "bronze" });
          BotasdeBronze.tech_needed = "material_bronze";
          BotasdeBronze.equipment_value = 0;
          AssetManager.items.list.AddItem(BotasdeBronze);
          Localization.addLocalization("item_BotasdeBronze", "Botas de Bronze");
 
  
          ItemAsset CascodeBronze = AssetManager.items.clone("CascodeBronze", "_equipment");
          CascodeBronze.id = "CascodeBronze";
          CascodeBronze.base_stats[S.fertility] = 0.0f;
          CascodeBronze.base_stats[S.max_children] = 0f;
          CascodeBronze.base_stats[S.max_age] = 0f;
          CascodeBronze.base_stats[S.attack_speed] = 0;
          CascodeBronze.base_stats[S.damage] = 0;
          CascodeBronze.base_stats[S.speed] = 0f;
          CascodeBronze.base_stats[S.health] = 0;
          CascodeBronze.base_stats[S.accuracy] = 0f;
          CascodeBronze.base_stats[S.range] = 0;
          CascodeBronze.base_stats[S.armor] = 6;
          CascodeBronze.base_stats[S.scale] = 0.0f;
          CascodeBronze.base_stats[S.dodge] = 0f;
          CascodeBronze.base_stats[S.targets] = 0f;
          CascodeBronze.base_stats[S.critical_chance] = 0.0f;
          CascodeBronze.base_stats[S.knockback] = 0.0f;
          CascodeBronze.base_stats[S.knockback_reduction] = 0.0f;
          CascodeBronze.base_stats[S.intelligence] = 0;
          CascodeBronze.base_stats[S.warfare] = 0;
          CascodeBronze.base_stats[S.diplomacy] = 0;
          CascodeBronze.base_stats[S.stewardship] = 0;
          CascodeBronze.base_stats[S.opinion] = 0f;
          CascodeBronze.base_stats[S.loyalty_traits] = 0f;
          CascodeBronze.base_stats[S.cities] = 0;
          CascodeBronze.base_stats[S.zone_range] = 0;
          CascodeBronze.equipmentType = EquipmentType.Helmet;
          CascodeBronze.name_class = "item_class_armor";
          CascodeBronze.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          CascodeBronze.materials = List.Of<string>(new string[]{ "bronze" });
          CascodeBronze.tech_needed = "material_bronze";
          CascodeBronze.equipment_value = 0;
          AssetManager.items.list.AddItem(CascodeBronze);
          Localization.addLocalization("item_CascodeBronze", "Casco de Bronze");
 
  
          ItemAsset ArmaduradeCobre = AssetManager.items.clone("ArmaduradeCobre", "_equipment");
          ArmaduradeCobre.id = "ArmaduradeCobre";
          ArmaduradeCobre.base_stats[S.fertility] = 0.0f;
          ArmaduradeCobre.base_stats[S.max_children] = 0f;
          ArmaduradeCobre.base_stats[S.max_age] = 0f;
          ArmaduradeCobre.base_stats[S.attack_speed] = 0;
          ArmaduradeCobre.base_stats[S.damage] = 0;
          ArmaduradeCobre.base_stats[S.speed] = 0f;
          ArmaduradeCobre.base_stats[S.health] = 0;
          ArmaduradeCobre.base_stats[S.accuracy] = 0f;
          ArmaduradeCobre.base_stats[S.range] = 0;
          ArmaduradeCobre.base_stats[S.armor] = 5;
          ArmaduradeCobre.base_stats[S.scale] = 0.0f;
          ArmaduradeCobre.base_stats[S.dodge] = 0f;
          ArmaduradeCobre.base_stats[S.targets] = 0f;
          ArmaduradeCobre.base_stats[S.critical_chance] = 0.0f;
          ArmaduradeCobre.base_stats[S.knockback] = 0.0f;
          ArmaduradeCobre.base_stats[S.knockback_reduction] = 0.0f;
          ArmaduradeCobre.base_stats[S.intelligence] = 0;
          ArmaduradeCobre.base_stats[S.warfare] = 0;
          ArmaduradeCobre.base_stats[S.diplomacy] = 0;
          ArmaduradeCobre.base_stats[S.stewardship] = 0;
          ArmaduradeCobre.base_stats[S.opinion] = 0f;
          ArmaduradeCobre.base_stats[S.loyalty_traits] = 0f;
          ArmaduradeCobre.base_stats[S.cities] = 0;
          ArmaduradeCobre.base_stats[S.zone_range] = 0;
          ArmaduradeCobre.equipmentType = EquipmentType.Armor;
          ArmaduradeCobre.name_class = "item_class_armor";
          ArmaduradeCobre.name_templates = List.Of<string>(new string[]{ "armor_name" });
          ArmaduradeCobre.materials = List.Of<string>(new string[]{ "copper" });
          ArmaduradeCobre.tech_needed = "material_copper";
          ArmaduradeCobre.equipment_value = 0;
          AssetManager.items.list.AddItem(ArmaduradeCobre);
          Localization.addLocalization("item_ArmaduradeCobre", "Armadura de Cobre");
 
  
          ItemAsset BotasdeCobre = AssetManager.items.clone("BotasdeCobre", "_equipment");
          BotasdeCobre.id = "BotasdeCobre";
          BotasdeCobre.base_stats[S.fertility] = 0.0f;
          BotasdeCobre.base_stats[S.max_children] = 0f;
          BotasdeCobre.base_stats[S.max_age] = 0f;
          BotasdeCobre.base_stats[S.attack_speed] = 0;
          BotasdeCobre.base_stats[S.damage] = 0;
          BotasdeCobre.base_stats[S.speed] = 0f;
          BotasdeCobre.base_stats[S.health] = 0;
          BotasdeCobre.base_stats[S.accuracy] = 0f;
          BotasdeCobre.base_stats[S.range] = 0;
          BotasdeCobre.base_stats[S.armor] = 5;
          BotasdeCobre.base_stats[S.scale] = 0.0f;
          BotasdeCobre.base_stats[S.dodge] = 0f;
          BotasdeCobre.base_stats[S.targets] = 0f;
          BotasdeCobre.base_stats[S.critical_chance] = 0.0f;
          BotasdeCobre.base_stats[S.knockback] = 0.0f;
          BotasdeCobre.base_stats[S.knockback_reduction] = 0.0f;
          BotasdeCobre.base_stats[S.intelligence] = 0;
          BotasdeCobre.base_stats[S.warfare] = 0;
          BotasdeCobre.base_stats[S.diplomacy] = 0;
          BotasdeCobre.base_stats[S.stewardship] = 0;
          BotasdeCobre.base_stats[S.opinion] = 0f;
          BotasdeCobre.base_stats[S.loyalty_traits] = 0f;
          BotasdeCobre.base_stats[S.cities] = 0;
          BotasdeCobre.base_stats[S.zone_range] = 0;
          BotasdeCobre.equipmentType = EquipmentType.Boots;
          BotasdeCobre.name_class = "item_class_armor";
          BotasdeCobre.name_templates = List.Of<string>(new string[]{ "boots_name" });
          BotasdeCobre.materials = List.Of<string>(new string[]{ "copper" });
          BotasdeCobre.tech_needed = "material_copper";
          BotasdeCobre.equipment_value = 0;
          AssetManager.items.list.AddItem(BotasdeCobre);
          Localization.addLocalization("item_BotasdeCobre", "Botas de Cobre");
 
  
          ItemAsset CascodeCobre = AssetManager.items.clone("CascodeCobre", "_equipment");
          CascodeCobre.id = "CascodeCobre";
          CascodeCobre.base_stats[S.fertility] = 0.0f;
          CascodeCobre.base_stats[S.max_children] = 0f;
          CascodeCobre.base_stats[S.max_age] = 0f;
          CascodeCobre.base_stats[S.attack_speed] = 0;
          CascodeCobre.base_stats[S.damage] = 0;
          CascodeCobre.base_stats[S.speed] = 0f;
          CascodeCobre.base_stats[S.health] = 0;
          CascodeCobre.base_stats[S.accuracy] = 0f;
          CascodeCobre.base_stats[S.range] = 0;
          CascodeCobre.base_stats[S.armor] = 5;
          CascodeCobre.base_stats[S.scale] = 0.0f;
          CascodeCobre.base_stats[S.dodge] = 0f;
          CascodeCobre.base_stats[S.targets] = 0f;
          CascodeCobre.base_stats[S.critical_chance] = 0.0f;
          CascodeCobre.base_stats[S.knockback] = 0.0f;
          CascodeCobre.base_stats[S.knockback_reduction] = 0.0f;
          CascodeCobre.base_stats[S.intelligence] = 0;
          CascodeCobre.base_stats[S.warfare] = 0;
          CascodeCobre.base_stats[S.diplomacy] = 0;
          CascodeCobre.base_stats[S.stewardship] = 0;
          CascodeCobre.base_stats[S.opinion] = 0f;
          CascodeCobre.base_stats[S.loyalty_traits] = 0f;
          CascodeCobre.base_stats[S.cities] = 0;
          CascodeCobre.base_stats[S.zone_range] = 0;
          CascodeCobre.equipmentType = EquipmentType.Helmet;
          CascodeCobre.name_class = "item_class_armor";
          CascodeCobre.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          CascodeCobre.materials = List.Of<string>(new string[]{ "copper" });
          CascodeCobre.tech_needed = "material_copper";
          CascodeCobre.equipment_value = 0;
          AssetManager.items.list.AddItem(CascodeCobre);
          Localization.addLocalization("item_CascodeCobre", "Casco de Cobre");
 
  
          ItemAsset ArmaduradeHierro = AssetManager.items.clone("ArmaduradeHierro", "_equipment");
          ArmaduradeHierro.id = "ArmaduradeHierro";
          ArmaduradeHierro.base_stats[S.fertility] = 0.0f;
          ArmaduradeHierro.base_stats[S.max_children] = 0f;
          ArmaduradeHierro.base_stats[S.max_age] = 0f;
          ArmaduradeHierro.base_stats[S.attack_speed] = 0;
          ArmaduradeHierro.base_stats[S.damage] = 0;
          ArmaduradeHierro.base_stats[S.speed] = 0f;
          ArmaduradeHierro.base_stats[S.health] = 0;
          ArmaduradeHierro.base_stats[S.accuracy] = 0f;
          ArmaduradeHierro.base_stats[S.range] = 0;
          ArmaduradeHierro.base_stats[S.armor] = 8;
          ArmaduradeHierro.equipmentType = EquipmentType.Armor;
          ArmaduradeHierro.name_class = "item_class_armor";
          ArmaduradeHierro.name_templates = List.Of<string>(new string[]{ "armor_name" });
          ArmaduradeHierro.materials = List.Of<string>(new string[]{ "iron" });
          ArmaduradeHierro.tech_needed = "material_iron";
          ArmaduradeHierro.equipment_value = 0;
          AssetManager.items.list.AddItem(ArmaduradeHierro);
          Localization.addLocalization("item_ArmaduradeHierro", "Armadura de Hierro");
 
  
          ItemAsset BotasdeHierro = AssetManager.items.clone("BotasdeHierro", "_equipment");
          BotasdeHierro.id = "BotasdeHierro";
          BotasdeHierro.base_stats[S.fertility] = 0.0f;
          BotasdeHierro.base_stats[S.max_children] = 0f;
          BotasdeHierro.base_stats[S.max_age] = 0f;
          BotasdeHierro.base_stats[S.attack_speed] = 0;
          BotasdeHierro.base_stats[S.damage] = 0;
          BotasdeHierro.base_stats[S.speed] = 0f;
          BotasdeHierro.base_stats[S.health] = 0;
          BotasdeHierro.base_stats[S.accuracy] = 0f;
          BotasdeHierro.base_stats[S.range] = 0;
          BotasdeHierro.base_stats[S.armor] = 8;
          BotasdeHierro.equipmentType = EquipmentType.Boots;
          BotasdeHierro.name_class = "item_class_armor";
          BotasdeHierro.name_templates = List.Of<string>(new string[]{ "boots_name" });
          BotasdeHierro.materials = List.Of<string>(new string[]{ "iron" });
          BotasdeHierro.tech_needed = "material_iron";
          BotasdeHierro.equipment_value = 0;
          AssetManager.items.list.AddItem(BotasdeHierro);
          Localization.addLocalization("item_BotasdeHierro", "Botas de Hierro");
 
  
          ItemAsset CascodeHierro = AssetManager.items.clone("CascodeHierro", "_equipment");
          CascodeHierro.id = "CascodeHierro";
          CascodeHierro.base_stats[S.fertility] = 0.0f;
          CascodeHierro.base_stats[S.max_children] = 0f;
          CascodeHierro.base_stats[S.max_age] = 0f;
          CascodeHierro.base_stats[S.attack_speed] = 0;
          CascodeHierro.base_stats[S.damage] = 0;
          CascodeHierro.base_stats[S.speed] = 0f;
          CascodeHierro.base_stats[S.health] = 0;
          CascodeHierro.base_stats[S.accuracy] = 0f;
          CascodeHierro.base_stats[S.range] = 0;
          CascodeHierro.base_stats[S.armor] = 8;
          CascodeHierro.base_stats[S.scale] = 0.0f;
          CascodeHierro.base_stats[S.dodge] = 0f;
          CascodeHierro.base_stats[S.targets] = 0f;
          CascodeHierro.base_stats[S.critical_chance] = 0.0f;
          CascodeHierro.base_stats[S.knockback] = 0.0f;
          CascodeHierro.base_stats[S.knockback_reduction] = 0.0f;
          CascodeHierro.base_stats[S.intelligence] = 0;
          CascodeHierro.base_stats[S.warfare] = 0;
          CascodeHierro.base_stats[S.diplomacy] = 0;
          CascodeHierro.base_stats[S.stewardship] = 0;
          CascodeHierro.base_stats[S.opinion] = 0f;
          CascodeHierro.base_stats[S.loyalty_traits] = 0f;
          CascodeHierro.base_stats[S.cities] = 0;
          CascodeHierro.base_stats[S.zone_range] = 0;
          CascodeHierro.equipmentType = EquipmentType.Helmet;
          CascodeHierro.name_class = "item_class_armor";
          CascodeHierro.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          CascodeHierro.materials = List.Of<string>(new string[]{ "iron" });
          CascodeHierro.tech_needed = "material_iron";
          CascodeHierro.equipment_value = 0;
          AssetManager.items.list.AddItem(CascodeHierro);
          Localization.addLocalization("item_CascodeHierro", "Casco de Hierro");
 
  
          ItemAsset ArmaduradeMythril = AssetManager.items.clone("ArmaduradeMythril", "_equipment");
          ArmaduradeMythril.id = "ArmaduradeMythril";
          ArmaduradeMythril.base_stats[S.armor] = 10;
          ArmaduradeMythril.equipmentType = EquipmentType.Armor;
          ArmaduradeMythril.name_class = "item_class_armor";
          ArmaduradeMythril.name_templates = List.Of<string>(new string[]{ "armor_name" });
          ArmaduradeMythril.materials = List.Of<string>(new string[]{ "mythril" });
          ArmaduradeMythril.tech_needed = "material_mythril";
          ArmaduradeMythril.equipment_value = 0;
          AssetManager.items.list.AddItem(ArmaduradeMythril);
          Localization.addLocalization("item_ArmaduradeMythril", "Armadura de Mythril");
 
  
          ItemAsset BotasdeMythril = AssetManager.items.clone("BotasdeMythril", "_equipment");
          BotasdeMythril.id = "BotasdeMythril";
          BotasdeMythril.base_stats[S.armor] = 10;
          BotasdeMythril.equipmentType = EquipmentType.Boots;
          BotasdeMythril.name_class = "item_class_armor";
          BotasdeMythril.name_templates = List.Of<string>(new string[]{ "boots_name" });
          BotasdeMythril.materials = List.Of<string>(new string[]{ "mythril" });
          BotasdeMythril.tech_needed = "material_mythril";
          BotasdeMythril.equipment_value = 0;
          AssetManager.items.list.AddItem(BotasdeMythril);
          Localization.addLocalization("item_BotasdeMythril", "Botas de Mythril");
 
  
          ItemAsset CascodeMythril = AssetManager.items.clone("CascodeMythril", "_equipment");
          CascodeMythril.id = "CascodeMythril";
          CascodeMythril.base_stats[S.armor] = 10;
          CascodeMythril.equipmentType = EquipmentType.Helmet;
          CascodeMythril.name_class = "item_class_armor";
          CascodeMythril.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          CascodeMythril.materials = List.Of<string>(new string[]{ "mythril" });
          CascodeMythril.tech_needed = "material_mythril";
          CascodeMythril.equipment_value = 0;
          AssetManager.items.list.AddItem(CascodeMythril);
          Localization.addLocalization("item_CascodeMythril", "Casco de Mythril");
 
  
          ItemAsset ArmaduradePlata = AssetManager.items.clone("ArmaduradePlata", "_equipment");
          ArmaduradePlata.id = "ArmaduradePlata";
          ArmaduradePlata.base_stats[S.fertility] = 0.0f;
          ArmaduradePlata.base_stats[S.max_children] = 0f;
          ArmaduradePlata.base_stats[S.max_age] = 0f;
          ArmaduradePlata.base_stats[S.attack_speed] = 0;
          ArmaduradePlata.base_stats[S.damage] = 0;
          ArmaduradePlata.base_stats[S.speed] = 0f;
          ArmaduradePlata.base_stats[S.health] = 0;
          ArmaduradePlata.base_stats[S.accuracy] = 0f;
          ArmaduradePlata.base_stats[S.range] = 0;
          ArmaduradePlata.base_stats[S.armor] = 7;
          ArmaduradePlata.equipmentType = EquipmentType.Armor;
          ArmaduradePlata.name_class = "item_class_armor";
          ArmaduradePlata.name_templates = List.Of<string>(new string[]{ "armor_name" });
          ArmaduradePlata.materials = List.Of<string>(new string[]{ "silver" });
          ArmaduradePlata.tech_needed = "material_silver";
          ArmaduradePlata.equipment_value = 0;
          AssetManager.items.list.AddItem(ArmaduradePlata);
          Localization.addLocalization("item_ArmaduradePlata", "Armadurade de Plata");
 
  
          ItemAsset BotasdePlata = AssetManager.items.clone("BotasdePlata", "_equipment");
          BotasdePlata.id = "BotasdePlata";
          BotasdePlata.base_stats[S.fertility] = 0.0f;
          BotasdePlata.base_stats[S.max_children] = 0f;
          BotasdePlata.base_stats[S.max_age] = 0f;
          BotasdePlata.base_stats[S.attack_speed] = 0;
          BotasdePlata.base_stats[S.damage] = 0;
          BotasdePlata.base_stats[S.speed] = 0f;
          BotasdePlata.base_stats[S.health] = 0;
          BotasdePlata.base_stats[S.accuracy] = 0f;
          BotasdePlata.base_stats[S.range] = 0;
          BotasdePlata.base_stats[S.armor] = 7;
          BotasdePlata.base_stats[S.scale] = 0.0f;
          BotasdePlata.base_stats[S.dodge] = 0f;
          BotasdePlata.base_stats[S.targets] = 0f;
          BotasdePlata.base_stats[S.critical_chance] = 0.0f;
          BotasdePlata.base_stats[S.knockback] = 0.0f;
          BotasdePlata.base_stats[S.knockback_reduction] = 0.0f;
          BotasdePlata.base_stats[S.intelligence] = 0;
          BotasdePlata.base_stats[S.warfare] = 0;
          BotasdePlata.base_stats[S.diplomacy] = 0;
          BotasdePlata.base_stats[S.stewardship] = 0;
          BotasdePlata.base_stats[S.opinion] = 0f;
          BotasdePlata.base_stats[S.loyalty_traits] = 0f;
          BotasdePlata.base_stats[S.cities] = 0;
          BotasdePlata.base_stats[S.zone_range] = 0;
          BotasdePlata.equipmentType = EquipmentType.Boots;
          BotasdePlata.name_class = "item_class_armor";
          BotasdePlata.name_templates = List.Of<string>(new string[]{ "boots_name" });
          BotasdePlata.materials = List.Of<string>(new string[]{ "silver" });
          BotasdePlata.tech_needed = "material_silver";
          BotasdePlata.equipment_value = 0;
          AssetManager.items.list.AddItem(BotasdePlata);
          Localization.addLocalization("item_BotasdePlata", "Botas de Plata");
 
  
          ItemAsset CascodePlata = AssetManager.items.clone("CascodePlata", "_equipment");
          CascodePlata.id = "CascodePlata";
          CascodePlata.base_stats[S.fertility] = 0.0f;
          CascodePlata.base_stats[S.max_children] = 0f;
          CascodePlata.base_stats[S.max_age] = 0f;
          CascodePlata.base_stats[S.attack_speed] = 0;
          CascodePlata.base_stats[S.damage] = 0;
          CascodePlata.base_stats[S.speed] = 0f;
          CascodePlata.base_stats[S.health] = 0;
          CascodePlata.base_stats[S.accuracy] = 0f;
          CascodePlata.base_stats[S.range] = 0;
          CascodePlata.base_stats[S.armor] = 7;
          CascodePlata.base_stats[S.scale] = 0.0f;
          CascodePlata.base_stats[S.dodge] = 0f;
          CascodePlata.base_stats[S.targets] = 0f;
          CascodePlata.base_stats[S.critical_chance] = 0.0f;
          CascodePlata.base_stats[S.knockback] = 0.0f;
          CascodePlata.base_stats[S.knockback_reduction] = 0.0f;
          CascodePlata.base_stats[S.intelligence] = 0;
          CascodePlata.base_stats[S.warfare] = 0;
          CascodePlata.base_stats[S.diplomacy] = 0;
          CascodePlata.base_stats[S.stewardship] = 0;
          CascodePlata.base_stats[S.opinion] = 0f;
          CascodePlata.base_stats[S.loyalty_traits] = 0f;
          CascodePlata.base_stats[S.cities] = 0;
          CascodePlata.base_stats[S.zone_range] = 0;
          CascodePlata.equipmentType = EquipmentType.Helmet;
          CascodePlata.name_class = "item_class_armor";
          CascodePlata.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          CascodePlata.materials = List.Of<string>(new string[]{ "silver" });
          CascodePlata.tech_needed = "material_silver";
          CascodePlata.equipment_value = 0;
          AssetManager.items.list.AddItem(CascodePlata);
          Localization.addLocalization("item_CascodePlata", "Casco de Plata");
		  
          ItemAsset ArmaduradeTechnotite = AssetManager.items.clone("ArmaduradeTechnotite", "_equipment");
          ArmaduradeTechnotite.id = "ArmaduradeTechnotite";
          ArmaduradeTechnotite.base_stats[S.fertility] = 0.0f;
          ArmaduradeTechnotite.base_stats[S.max_children] = 0f;
          ArmaduradeTechnotite.base_stats[S.max_age] = 0f;
          ArmaduradeTechnotite.base_stats[S.attack_speed] = 0;
          ArmaduradeTechnotite.base_stats[S.damage] = 200;
          ArmaduradeTechnotite.base_stats[S.speed] = 0f;
          ArmaduradeTechnotite.base_stats[S.health] = 150;
          ArmaduradeTechnotite.base_stats[S.accuracy] = 0f;
          ArmaduradeTechnotite.base_stats[S.range] = 0;
          ArmaduradeTechnotite.base_stats[S.armor] = 60;
          ArmaduradeTechnotite.base_stats[S.scale] = 0.0f;
          ArmaduradeTechnotite.base_stats[S.dodge] = 0f;
          ArmaduradeTechnotite.base_stats[S.targets] = 0f;
          ArmaduradeTechnotite.base_stats[S.critical_chance] = 0.4f;
          ArmaduradeTechnotite.base_stats[S.knockback] = 0.0f;
          ArmaduradeTechnotite.base_stats[S.knockback_reduction] = 0.0f;
          ArmaduradeTechnotite.base_stats[S.intelligence] = 20;
          ArmaduradeTechnotite.equipmentType = EquipmentType.Armor;
		  ArmaduradeTechnotite.setCost(4, "technotite", 2);
          ArmaduradeTechnotite.name_class = "item_class_armor";
          ArmaduradeTechnotite.name_templates = List.Of("armor_name");
          ArmaduradeTechnotite.materials = List.Of<string>(new string[]{ "technotite" });
          ArmaduradeTechnotite.tech_needed = "material_technotite";
          ArmaduradeTechnotite.equipment_value = 0;
          AssetManager.items.list.AddItem(ArmaduradeTechnotite);
          Localization.addLocalization("item_ArmaduradeTechnotite", "Armadura de Technotite");
		  
          ItemAsset CascodeTechnotite = AssetManager.items.clone("CascodeTechnotite", "_equipment");
          CascodeTechnotite.id = "CascodeTechnotite";
          CascodeTechnotite.base_stats[S.fertility] = 0.0f;
          CascodeTechnotite.base_stats[S.max_children] = 0f;
          CascodeTechnotite.base_stats[S.max_age] = 0f;
          CascodeTechnotite.base_stats[S.attack_speed] = 0;
          CascodeTechnotite.base_stats[S.damage] = 50;
          CascodeTechnotite.base_stats[S.speed] = 0f;
          CascodeTechnotite.base_stats[S.health] = 100;
          CascodeTechnotite.base_stats[S.accuracy] = 0f;
          CascodeTechnotite.base_stats[S.range] = 0;
          CascodeTechnotite.base_stats[S.armor] = 30;
          CascodeTechnotite.base_stats[S.scale] = 0.0f;
          CascodeTechnotite.base_stats[S.dodge] = 0f;
          CascodeTechnotite.base_stats[S.targets] = 0f;
          CascodeTechnotite.base_stats[S.critical_chance] = 0.0f;
          CascodeTechnotite.base_stats[S.knockback] = 0.2f;
          CascodeTechnotite.base_stats[S.knockback_reduction] = 0.0f;
          CascodeTechnotite.base_stats[S.intelligence] = 20;
          CascodeTechnotite.equipmentType = EquipmentType.Helmet;
          CascodeTechnotite.name_class = "item_class_armor";
		  CascodeTechnotite.setCost(4, "technotite", 2);
          CascodeTechnotite.name_templates = List.Of<string>(new string[]{ "helmet_name" });
          CascodeTechnotite.materials = List.Of<string>(new string[]{ "technotite" });
          CascodeTechnotite.tech_needed = "material_technotite";
          CascodeTechnotite.equipment_value = 0;
          AssetManager.items.list.AddItem(CascodeTechnotite);
          Localization.addLocalization("item_CascodeTechnotite", "Casco de Technotite");
 
  
          ItemAsset BotasdeTechnotite = AssetManager.items.clone("BotasdeTechnotite", "_equipment");
          BotasdeTechnotite.id = "BotasdeTechnotite";
          BotasdeTechnotite.base_stats[S.fertility] = 0.0f;
          BotasdeTechnotite.base_stats[S.max_children] = 0f;
          BotasdeTechnotite.base_stats[S.max_age] = 0f;
          BotasdeTechnotite.base_stats[S.attack_speed] = 0;
          BotasdeTechnotite.base_stats[S.damage] = 50;
          BotasdeTechnotite.base_stats[S.speed] = 0f;
          BotasdeTechnotite.base_stats[S.health] = 90;
          BotasdeTechnotite.base_stats[S.accuracy] = 0f;
          BotasdeTechnotite.base_stats[S.range] = 0;
          BotasdeTechnotite.base_stats[S.armor] = 20;
          BotasdeTechnotite.base_stats[S.scale] = 0.0f;
          BotasdeTechnotite.base_stats[S.dodge] = 0f;
          BotasdeTechnotite.base_stats[S.targets] = 0f;
          BotasdeTechnotite.base_stats[S.critical_chance] = 0.2f;
          BotasdeTechnotite.base_stats[S.knockback] = 0.0f;
          BotasdeTechnotite.base_stats[S.knockback_reduction] = 0.0f;
          BotasdeTechnotite.base_stats[S.intelligence] = 20;
          BotasdeTechnotite.equipmentType = EquipmentType.Boots;
		  BotasdeTechnotite.setCost(4, "technotite", 2);
          BotasdeTechnotite.name_class = "item_class_armor";
          BotasdeTechnotite.name_templates = List.Of<string>(new string[]{ "boots_name" });
          BotasdeTechnotite.materials = List.Of<string>(new string[]{ "technotite" });
          BotasdeTechnotite.tech_needed = "material_technotite";
          BotasdeTechnotite.equipment_value = 0;
          AssetManager.items.list.AddItem(BotasdeTechnotite);
          Localization.addLocalization("item_BotasdeTechnotite", "Botas de Technotite");
 
 
          static void craftitems() {
 
          Race human = AssetManager.raceLibrary.get("human");
          Race orc = AssetManager.raceLibrary.get("orc");
          Race dwarf = AssetManager.raceLibrary.get("dwarf");
          Race elf = AssetManager.raceLibrary.get("elf");
 
 
          orc.preferred_weapons.Add("ArmaduradeAcero");
          human.preferred_weapons.Add("ArmaduradeAcero");
          dwarf.preferred_weapons.Add("ArmaduradeAcero");
          elf.preferred_weapons.Add("ArmaduradeAcero");
 
  
          orc.preferred_weapons.Add("BotasdeAcero");
          human.preferred_weapons.Add("BotasdeAcero");
          dwarf.preferred_weapons.Add("BotasdeAcero");
          elf.preferred_weapons.Add("BotasdeAcero");
 
  
          orc.preferred_weapons.Add("CascodeAcero");
          human.preferred_weapons.Add("CascodeAcero");
          dwarf.preferred_weapons.Add("CascodeAcero");
          elf.preferred_weapons.Add("CascodeAcero");
 
  
          orc.preferred_weapons.Add("ArmaduradeAdamantito");
          human.preferred_weapons.Add("ArmaduradeAdamantito");
          dwarf.preferred_weapons.Add("ArmaduradeAdamantito");
          elf.preferred_weapons.Add("ArmaduradeAdamantito");
 
  
          orc.preferred_weapons.Add("BotasdeAdamantito");
          human.preferred_weapons.Add("BotasdeAdamantito");
          dwarf.preferred_weapons.Add("BotasdeAdamantito");
          elf.preferred_weapons.Add("BotasdeAdamantito");
 
 
          orc.preferred_weapons.Add("CascodeAdamantito");
          human.preferred_weapons.Add("CascodeAdamantito");
          dwarf.preferred_weapons.Add("CascodeAdamantito");
          elf.preferred_weapons.Add("CascodeAdamantito");
 
  
          orc.preferred_weapons.Add("ArmaduradeBronze");
          human.preferred_weapons.Add("ArmaduradeBronze");
          dwarf.preferred_weapons.Add("ArmaduradeBronze");
          elf.preferred_weapons.Add("ArmaduradeBronze");
 
  
          orc.preferred_weapons.Add("BotasdeBronze");
          human.preferred_weapons.Add("BotasdeBronze");
          dwarf.preferred_weapons.Add("BotasdeBronze");
          elf.preferred_weapons.Add("BotasdeBronze");
 
 
          orc.preferred_weapons.Add("CascodeBronze");
          human.preferred_weapons.Add("CascodeBronze");
          dwarf.preferred_weapons.Add("CascodeBronze");
          elf.preferred_weapons.Add("CascodeBronze");
 
 
          orc.preferred_weapons.Add("ArmaduradeCobre");
          human.preferred_weapons.Add("ArmaduradeCobre");
          dwarf.preferred_weapons.Add("ArmaduradeCobre");
          elf.preferred_weapons.Add("ArmaduradeCobre");

 
          orc.preferred_weapons.Add("BotasdeCobre");
          human.preferred_weapons.Add("BotasdeCobre");
          dwarf.preferred_weapons.Add("BotasdeCobre");
          elf.preferred_weapons.Add("BotasdeCobre");
 
 
          orc.preferred_weapons.Add("CascodeCobre");
          human.preferred_weapons.Add("CascodeCobre");
          dwarf.preferred_weapons.Add("CascodeCobre");
          elf.preferred_weapons.Add("CascodeCobre");
 
  
          orc.preferred_weapons.Add("ArmaduradeHierro");
          human.preferred_weapons.Add("ArmaduradeHierro");
          dwarf.preferred_weapons.Add("ArmaduradeHierro");
          elf.preferred_weapons.Add("ArmaduradeHierro");
 

          orc.preferred_weapons.Add("BotasdeHierro");
          human.preferred_weapons.Add("BotasdeHierro");
          dwarf.preferred_weapons.Add("BotasdeHierro");
          elf.preferred_weapons.Add("BotasdeHierro");
 

          orc.preferred_weapons.Add("CascodeHierro");
          human.preferred_weapons.Add("CascodeHierro");
          dwarf.preferred_weapons.Add("CascodeHierro");
          elf.preferred_weapons.Add("CascodeHierro");
 
  
          orc.preferred_weapons.Add("ArmaduradeMythril");
          human.preferred_weapons.Add("ArmaduradeMythril");
          dwarf.preferred_weapons.Add("ArmaduradeMythril");
          elf.preferred_weapons.Add("ArmaduradeMythril");
 
  
          orc.preferred_weapons.Add("BotasdeMythril");
          human.preferred_weapons.Add("BotasdeMythril");
          dwarf.preferred_weapons.Add("BotasdeMythril");
          elf.preferred_weapons.Add("BotasdeMythril");
 
  
          orc.preferred_weapons.Add("CascodeMythril");
          human.preferred_weapons.Add("CascodeMythril");
          dwarf.preferred_weapons.Add("CascodeMythril");
          elf.preferred_weapons.Add("CascodeMythril");
 
  
          orc.preferred_weapons.Add("ArmaduradePlata");
          human.preferred_weapons.Add("ArmaduradePlata");
          dwarf.preferred_weapons.Add("ArmaduradePlata");
          elf.preferred_weapons.Add("ArmaduradePlata");
 
  
          orc.preferred_weapons.Add("BotasdePlata");
          human.preferred_weapons.Add("BotasdePlata");
          dwarf.preferred_weapons.Add("BotasdePlata");
          elf.preferred_weapons.Add("BotasdePlata");
		  
			human.preferred_weapons.Add("Cannon");
			human.preferred_weapons.Add("Ballista");
			human.preferred_weapons.Add("Catapult");
 
  
          orc.preferred_weapons.Add("CascodePlata");
          human.preferred_weapons.Add("CascodePlata");
          dwarf.preferred_weapons.Add("CascodePlata");
          elf.preferred_weapons.Add("CascodePlata");
		  
          orc.preferred_weapons.Add("BotasdeTechnotite");
          human.preferred_weapons.Add("BotasdeTechnotite");
          dwarf.preferred_weapons.Add("BotasdeTechnotite");
          elf.preferred_weapons.Add("BotasdeTechnotite");
		  
          orc.preferred_weapons.Add("CascodeTechnotite");
          human.preferred_weapons.Add("CascodeTechnotite");
          dwarf.preferred_weapons.Add("CascodeTechnotite");
          elf.preferred_weapons.Add("CascodeTechnotite");
		  
          orc.preferred_weapons.Add("ArmaduradeTechnotite");
          human.preferred_weapons.Add("ArmaduradeTechnotite");
          dwarf.preferred_weapons.Add("ArmaduradeTechnotite");
          elf.preferred_weapons.Add("ArmaduradeTechnotite");
		  
          human.preferred_weapons.Add("Arcabuz");
		  human.preferred_weapons.Add("Mosquete");
		  human.preferred_weapons.Add("PistolaDeMecha");
		  human.preferred_weapons.Add("Culebrina");
		  human.preferred_weapons.Add("Falconete");
		  human.preferred_weapons.Add("AK47");
		  human.preferred_weapons.Add("M16");
		  human.preferred_weapons.Add("Glock17");
		  human.preferred_weapons.Add("BarrettM82");
		  human.preferred_weapons.Add("Uzi");
		  human.preferred_weapons.Add("BenelliM4");
		  human.preferred_weapons.Add("PlasmaCutter5000");
		  human.preferred_weapons.Add("RailgunX900");
		  human.preferred_weapons.Add("FusionBlasterMk");
		  human.preferred_weapons.Add("NaniteSwarmLauncher");
		  human.preferred_weapons.Add("PhotonRifleXR");
		  human.preferred_weapons.Add("Astra");
		  
 
         }
 
        }
        public static bool NoneAttackSomeoneAction(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
 
             return false;
 
        }
        public static bool NoneRegularAction(BaseSimObject pTarget, WorldTile pTile = null)
        {
 
             return false;
 
        }
        public static bool NoneGetAttackedAction(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
        {
 
             return false;
 
        }
        public static bool NoneDeathAction(BaseSimObject pTarget, WorldTile pTile = null)
        {
 
             return false;
        
 
            }
            static void addWeaponsSprite(string id, string material)
            {
              var dictItems = Reflection.GetField(typeof(ActorAnimationLoader), null, "dictItems") as Dictionary<string, Sprite>;
              var sprite = Resources.Load<Sprite>("Weapons/w_" + id + "_" + material);
              dictItems.Add(sprite.name, sprite);
            }
        }
    }
