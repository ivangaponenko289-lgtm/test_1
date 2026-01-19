using System;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using ReflectionUtility;
using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using life;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Config;
using System.Reflection;
using UnityEngine.Tilemaps;
using System.IO;
using ai;
 
namespace AmbientWar
{
    class Traits
    {
        //Traits
        public static void init()
        { 
         ActorTrait Traumado = new ActorTrait();
         Traumado.id = "Traumado";
         Traumado.path_icon = "ui/IconsTraitR/Traumado";
         Traumado.group_id = TraitGroup.mind;
         Traumado.can_be_cured = true;
         Traumado.base_stats[S.mod_attack_speed] = -0.8f;
         Traumado.base_stats[S.mod_damage] = -0.85f;
         Traumado.base_stats[S.mod_speed] = -0.50f;
         Traumado.base_stats[S.mod_health] = -0.9f;
         Traumado.base_stats[S.armor] = -160;
         Traumado.base_stats[S.critical_chance] = -1.0f;
         Traumado.base_stats[S.intelligence] = -10;
         Traumado.base_stats[S.diplomacy] = -20;
         Traumado.base_stats[S.loyalty_traits] = -25f;
		 Traumado.opposite = "Mark 2,Mark 3,Mark 4,Mark 5,Mark 1"; 
         AssetManager.traits.add(Traumado);
         PlayerConfig.unlockTrait("Traumado");
		 
         ActorTrait MaldiR = new ActorTrait();
         MaldiR.id = "MaldiR";
         MaldiR.path_icon = "ui/IconsTraitR/MaldiR4";
         MaldiR.group_id = TraitGroups.ConceRasgos;
         MaldiR.can_be_cured = true;
		 MaldiR.action_special_effect = new WorldAction(MaldiRasaD);
		 MaldiR.opposite = "Mark 2,Mark 3,Mark 4,Mark 5"; 
         AssetManager.traits.add(MaldiR);
         PlayerConfig.unlockTrait("MaldiR");
		
         ActorTrait Mark_1 = new ActorTrait();
         Mark_1.id = "Mark 1";
         Mark_1.path_icon = "ui/Icons/Mark1";
         Mark_1.type = TraitType.Other;
         Mark_1.group_id = TraitGroups.AmbientWar;
         Mark_1.can_be_cured = false;
         Mark_1.needs_to_be_explored = false;
         Mark_1.can_be_given = false;
         Mark_1.can_be_removed = true;
         Mark_1.only_active_on_era_flag = false;
         Mark_1.era_active_night = false;
         Mark_1.era_active_moon = false;
         Mark_1.birth = 0.0f;
         Mark_1.inherit = 0.0f;
         Mark_1.action_death = new WorldAction(NoneDeathAction);
         Mark_1.action_special_effect = new WorldAction(NoneRegularAction);
         Mark_1.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
         Mark_1.action_get_hit = new GetHitAction(Mark1P);
		 Mark_1.opposite = "Mark_2,Mark_3,Mark_4,Mark_5,Traumado"; 
         AssetManager.traits.add(Mark_1);
         PlayerConfig.unlockTrait("Mark_1");
		 
		 ActorTrait Mark_2 = new ActorTrait();
         Mark_2.id = "Mark 2";
         Mark_2.path_icon = "ui/Icons/Mark2";
         Mark_2.type = TraitType.Other;
         Mark_2.group_id = TraitGroups.AmbientWar;
         Mark_2.can_be_cured = false;
         Mark_2.needs_to_be_explored = false;
         Mark_2.can_be_given = false;
         Mark_2.can_be_removed = true;
         Mark_2.only_active_on_era_flag = false;
         Mark_2.era_active_night = false;
         Mark_2.era_active_moon = false;
         Mark_2.birth = 0.0f;
         Mark_2.inherit = 0.0f;
         Mark_2.action_death = new WorldAction(NoneDeathAction);
         Mark_2.action_special_effect = new WorldAction(NoneRegularAction);
         Mark_2.action_attack_target = new AttackAction(Mark2Pa);
         Mark_2.action_get_hit = new GetHitAction(Mark2P);
		 Mark_2.opposite = "Mark_1,Mark_3,Mark_4,Mark_5,Traumado,MaldiR";
         AssetManager.traits.add(Mark_2);
         PlayerConfig.unlockTrait("Mark_2");
		 
		 ActorTrait Mark_3 = new ActorTrait();
         Mark_3.id = "Mark 3";
         Mark_3.path_icon = "ui/Icons/Mark3";
         Mark_3.type = TraitType.Other;
         Mark_3.group_id = TraitGroups.AmbientWar;
         Mark_3.can_be_cured = false;
         Mark_3.needs_to_be_explored = false;
         Mark_3.can_be_given = false;
         Mark_3.can_be_removed = true;
         Mark_3.only_active_on_era_flag = false;
         Mark_3.era_active_night = false;
         Mark_3.era_active_moon = false;
         Mark_3.birth = 0.0f;
         Mark_3.inherit = 0.0f;
         Mark_3.action_death = new WorldAction(NoneDeathAction);
         Mark_3.action_special_effect = new WorldAction(NoneRegularAction);
         Mark_3.action_attack_target = new AttackAction(Mark3Pa);
         Mark_3.action_get_hit = new GetHitAction(Mark3P);
		 Mark_3.opposite = "Mark_2,Mark_1,Mark_4,Mark_5,Traumado,MaldiR";
         AssetManager.traits.add(Mark_3);
         PlayerConfig.unlockTrait("Mark_3");
		 
		 ActorTrait Mark_4 = new ActorTrait();
         Mark_4.id = "Mark 4";
         Mark_4.path_icon = "ui/Icons/Mark4";
         Mark_4.type = TraitType.Other;
         Mark_4.group_id = TraitGroups.AmbientWar;
         Mark_4.can_be_cured = false;
         Mark_4.needs_to_be_explored = false;
         Mark_4.can_be_given = false;
         Mark_4.can_be_removed = true;
         Mark_4.only_active_on_era_flag = false;
         Mark_4.era_active_night = false;
         Mark_4.era_active_moon = false;
         Mark_4.birth = 0.0f;
         Mark_4.inherit = 0.0f;
         Mark_4.action_death = new WorldAction(NoneDeathAction);
         Mark_4.action_special_effect = new WorldAction(NoneRegularAction);
         Mark_4.action_attack_target = new AttackAction(Mark4Pa);
         Mark_4.action_get_hit = new GetHitAction(Mark4P);
		 Mark_4.opposite = "Mark_2,Mark_3,Mark_1,Mark_5,Traumado,MaldiR";
         AssetManager.traits.add(Mark_4);
         PlayerConfig.unlockTrait("Mark_4");
		 
		 ActorTrait Mark_5 = new ActorTrait();
         Mark_5.id = "Mark 5";
         Mark_5.path_icon = "ui/Icons/Mark5";
         Mark_5.type = TraitType.Other;
         Mark_5.group_id = TraitGroups.AmbientWar;
         Mark_5.can_be_cured = false;
         Mark_5.needs_to_be_explored = false;
         Mark_5.can_be_given = false;
         Mark_5.can_be_removed = true;
         Mark_5.only_active_on_era_flag = false;
         Mark_5.era_active_night = false;
         Mark_5.era_active_moon = false;
         Mark_5.birth = 0.0f;
         Mark_5.inherit = 0.0f;
         Mark_5.action_death = new WorldAction(NoneDeathAction);
         Mark_5.action_special_effect = new WorldAction(NoneRegularAction);
         Mark_5.action_attack_target = new AttackAction(Mark5Pow);
         Mark_5.action_get_hit = new GetHitAction(Mark5P);
		 Mark_5.opposite = "Mark_2,Mark_3,Mark_4,Mark_1,Traumado,MaldiR";
         AssetManager.traits.add(Mark_5);
         PlayerConfig.unlockTrait("Mark_5");
		 
		 
		 ActorTrait Gamma04 = new ActorTrait();
         Gamma04.id = "Gamma 04 Power";
         Gamma04.path_icon = "ui/Icons/Gamma04";
         Gamma04.type = TraitType.Other;
         Gamma04.group_id = TraitGroups.RobotsSkill;
         Gamma04.can_be_cured = false;
         Gamma04.needs_to_be_explored = false;
         Gamma04.can_be_given = false;
         Gamma04.can_be_removed = true;
         Gamma04.only_active_on_era_flag = false;
         Gamma04.era_active_night = false;
         Gamma04.era_active_moon = false;
         Gamma04.birth = 0.0f;
         Gamma04.inherit = 0.0f;
         Gamma04.action_death = new WorldAction(NoneDeathAction);
         Gamma04.action_special_effect = new WorldAction(NoneRegularAction);
         Gamma04.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
         Gamma04.action_get_hit = new GetHitAction(Gamma04PowerATTR);
		 Gamma04.opposite = "";
         AssetManager.traits.add(Gamma04);
         PlayerConfig.unlockTrait("Gamma04");
		 
		 ActorTrait Gamma02 = new ActorTrait();
         Gamma02.id = "Gamma 02 Power";
         Gamma02.path_icon = "ui/Icons/Gamma02";
         Gamma02.type = TraitType.Other;
         Gamma02.group_id = TraitGroups.RobotsSkill;
         Gamma02.can_be_cured = false;
         Gamma02.needs_to_be_explored = false;
         Gamma02.can_be_given = false;
         Gamma02.can_be_removed = true;
         Gamma02.only_active_on_era_flag = false;
         Gamma02.era_active_night = false;
         Gamma02.era_active_moon = false;
         Gamma02.birth = 0.0f;
         Gamma02.inherit = 0.0f;
         Gamma02.action_death = new WorldAction(NoneDeathAction);
         Gamma02.action_special_effect = new WorldAction(NoneRegularAction);
         Gamma02.action_attack_target = new AttackAction(Gamma02PowerATT);
         Gamma02.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Gamma02.opposite = "";
         AssetManager.traits.add(Gamma02);
         PlayerConfig.unlockTrait("Gamma02");
		 
		 ActorTrait Delta01 = new ActorTrait();
         Delta01.id = "Delta 01 Power";
         Delta01.path_icon = "ui/Icons/Delta01";
         Delta01.type = TraitType.Other;
         Delta01.group_id = TraitGroups.RobotsSkill;
         Delta01.can_be_cured = false;
         Delta01.needs_to_be_explored = false;
         Delta01.can_be_given = false;
         Delta01.can_be_removed = true;
         Delta01.only_active_on_era_flag = false;
         Delta01.era_active_night = false;
         Delta01.era_active_moon = false;
         Delta01.birth = 0.0f;
         Delta01.inherit = 0.0f;
         Delta01.action_death = new WorldAction(NoneDeathAction);
         Delta01.action_special_effect = new WorldAction(NoneRegularAction);
         Delta01.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
         Delta01.action_get_hit = new GetHitAction(Delta01PowerATTR);
		 Delta01.opposite = "";
         AssetManager.traits.add(Delta01);
         PlayerConfig.unlockTrait("Delta01");
		 
		 ActorTrait Delta02 = new ActorTrait();
         Delta02.id = "Delta 02 Power";
         Delta02.path_icon = "ui/Icons/Delta02";
         Delta02.type = TraitType.Other;
         Delta02.group_id = TraitGroups.RobotsSkill;
         Delta02.can_be_cured = false;
         Delta02.needs_to_be_explored = false;
         Delta02.can_be_given = false;
         Delta02.can_be_removed = true;
         Delta02.only_active_on_era_flag = false;
         Delta02.era_active_night = false;
         Delta02.era_active_moon = false;
         Delta02.birth = 0.0f;
         Delta02.inherit = 0.0f;
         Delta02.action_death = new WorldAction(NoneDeathAction);
         Delta02.action_special_effect = new WorldAction(NoneRegularAction);
         Delta02.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
         Delta02.action_get_hit = new GetHitAction(Delta02PowerATTR);
		 Delta02.opposite = "";
         AssetManager.traits.add(Delta02);
         PlayerConfig.unlockTrait("Delta02");
		 
	     ActorTrait Delta03 = new ActorTrait();
         Delta03.id = "Delta 03 Power";
         Delta03.path_icon = "ui/Icons/Delta03";
         Delta03.type = TraitType.Other;
         Delta03.group_id = TraitGroups.RobotsSkill;
         Delta03.can_be_cured = false;
         Delta03.needs_to_be_explored = false;
         Delta03.can_be_given = false;
         Delta03.can_be_removed = true;
         Delta03.only_active_on_era_flag = false;
         Delta03.era_active_night = false;
         Delta03.era_active_moon = false;
         Delta03.birth = 0.0f;
         Delta03.inherit = 0.0f;
         Delta03.action_death = new WorldAction(NoneDeathAction);
         Delta03.action_special_effect = new WorldAction(NoneRegularAction);
         Delta03.action_attack_target = new AttackAction(Delta03PowerATT);
         Delta03.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Delta03.opposite = "";
         AssetManager.traits.add(Delta03);
         PlayerConfig.unlockTrait("Delta03");
		 
	     ActorTrait Delta04 = new ActorTrait();
         Delta04.id = "Delta 04 Power";
         Delta04.path_icon = "ui/Icons/Delta04";
         Delta04.type = TraitType.Other;
         Delta04.group_id = TraitGroups.RobotsSkill;
         Delta04.can_be_cured = false;
         Delta04.needs_to_be_explored = false;
         Delta04.can_be_given = false;
         Delta04.can_be_removed = true;
         Delta04.only_active_on_era_flag = false;
         Delta04.era_active_night = false;
         Delta04.era_active_moon = false;
         Delta04.birth = 0.0f;
         Delta04.inherit = 0.0f;
         Delta04.action_death = new WorldAction(NoneDeathAction);
         Delta04.action_special_effect = new WorldAction(NoneRegularAction);
         Delta04.action_attack_target = new AttackAction(Delta04PowerATT);
         Delta04.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Delta04.opposite = "";
         AssetManager.traits.add(Delta04);
         PlayerConfig.unlockTrait("Delta04");
		 
	     ActorTrait Omega02 = new ActorTrait();
         Omega02.id = "Omega 02 Power";
         Omega02.path_icon = "ui/Icons/Omega02";
         Omega02.type = TraitType.Other;
         Omega02.group_id = TraitGroups.RobotsSkill;
         Omega02.can_be_cured = false;
         Omega02.needs_to_be_explored = false;
         Omega02.can_be_given = false;
         Omega02.can_be_removed = true;
         Omega02.only_active_on_era_flag = false;
         Omega02.era_active_night = false;
         Omega02.era_active_moon = false;
         Omega02.birth = 0.0f;
         Omega02.inherit = 0.0f;
         Omega02.action_death = new WorldAction(NoneDeathAction);
         Omega02.action_special_effect = new WorldAction(NoneRegularAction);
         Omega02.action_attack_target = new AttackAction(Vortex02PowerATT); 
         Omega02.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Omega02.opposite = "";
         AssetManager.traits.add(Omega02);
         PlayerConfig.unlockTrait("Omega02");
		 
	     ActorTrait Omega03 = new ActorTrait();
         Omega03.id = "Omega 03 Power";
         Omega03.path_icon = "ui/Icons/Omega03";
         Omega03.type = TraitType.Other;
         Omega03.group_id = TraitGroups.RobotsSkill;
         Omega03.can_be_cured = false;
         Omega03.needs_to_be_explored = false;
         Omega03.can_be_given = false;
         Omega03.can_be_removed = true;
         Omega03.only_active_on_era_flag = false;
         Omega03.era_active_night = false;
         Omega03.era_active_moon = false;
         Omega03.birth = 0.0f;
         Omega03.inherit = 0.0f;
         Omega03.action_death = new WorldAction(NoneDeathAction);
         Omega03.action_special_effect = new WorldAction(NoneRegularAction);
         Omega03.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
         Omega03.action_get_hit = new GetHitAction(Omega03PowerATTR);
		 Omega03.opposite = "";
         AssetManager.traits.add(Omega03);
         PlayerConfig.unlockTrait("Omega03");
		 
         ActorTrait Omega05 = new ActorTrait();
         Omega05.id = "Omega 05 Power";
         Omega05.path_icon = "ui/Icons/Omega05";
         Omega05.type = TraitType.Other;
         Omega05.group_id = TraitGroups.RobotsSkill;
         Omega05.can_be_cured = false;
         Omega05.needs_to_be_explored = false;
         Omega05.can_be_given = false;
         Omega05.can_be_removed = true;
         Omega05.only_active_on_era_flag = false;
         Omega05.era_active_night = false;
         Omega05.era_active_moon = false;
         Omega05.birth = 0.0f;
         Omega05.inherit = 0.0f;
         Omega05.action_death = new WorldAction(NoneDeathAction);
         Omega05.action_special_effect = new WorldAction(NoneRegularAction);
         Omega05.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
         Omega05.action_get_hit = new GetHitAction(Omega05PowerATTR);
		 Omega05.opposite = "";
         AssetManager.traits.add(Omega05);
         PlayerConfig.unlockTrait("Omega05");
		 
         ActorTrait Vortex05 = new ActorTrait();
         Vortex05.id = "Vortex 05 Power";
         Vortex05.path_icon = "ui/Icons/Vortex05";
         Vortex05.type = TraitType.Other;
         Vortex05.group_id = TraitGroups.RobotsSkill;
         Vortex05.can_be_cured = false;
         Vortex05.needs_to_be_explored = false;
         Vortex05.can_be_given = false;
         Vortex05.can_be_removed = true;
         Vortex05.only_active_on_era_flag = false;
         Vortex05.era_active_night = false;
         Vortex05.era_active_moon = false;
         Vortex05.birth = 0.0f;
         Vortex05.inherit = 0.0f;
         Vortex05.action_death = new WorldAction(NoneDeathAction);
         Vortex05.action_special_effect = new WorldAction(NoneRegularAction);
         Vortex05.action_attack_target = new AttackAction(Vortex05PowerATT);
         Vortex05.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Vortex05.opposite = "";
         AssetManager.traits.add(Vortex05);
         PlayerConfig.unlockTrait("Vortex05");
		 
         ActorTrait Vortex04 = new ActorTrait();
         Vortex04.id = "Vortex 04 Power";
         Vortex04.path_icon = "ui/Icons/Vortex04";
         Vortex04.type = TraitType.Other;
         Vortex04.group_id = TraitGroups.RobotsSkill;
         Vortex04.can_be_cured = false;
         Vortex04.needs_to_be_explored = false;
         Vortex04.can_be_given = false;
         Vortex04.can_be_removed = true;
         Vortex04.only_active_on_era_flag = false;
         Vortex04.era_active_night = false;
         Vortex04.era_active_moon = false;
         Vortex04.birth = 0.0f;
         Vortex04.inherit = 0.0f;
         Vortex04.action_death = new WorldAction(NoneDeathAction);
         Vortex04.action_special_effect = new WorldAction(NoneRegularAction);
         Vortex04.action_attack_target = new AttackAction(Vortex04PowerATT);
         Vortex04.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Vortex04.opposite = "";
         AssetManager.traits.add(Vortex04);
         PlayerConfig.unlockTrait("Vortex04");
		 
         ActorTrait Vortex02 = new ActorTrait();
         Vortex02.id = "Vortex 02 Power";
         Vortex02.path_icon = "ui/Icons/Vortex02";
         Vortex02.type = TraitType.Other;
         Vortex02.group_id = TraitGroups.RobotsSkill;
         Vortex02.can_be_cured = false;
         Vortex02.needs_to_be_explored = false;
         Vortex02.can_be_given = false;
         Vortex02.can_be_removed = true;
         Vortex02.only_active_on_era_flag = false;
         Vortex02.era_active_night = false;
         Vortex02.era_active_moon = false;
         Vortex02.birth = 0.0f;
         Vortex02.inherit = 0.0f;
         Vortex02.action_death = new WorldAction(NoneDeathAction);
         Vortex02.action_special_effect = new WorldAction(NoneRegularAction);
         Vortex02.action_attack_target = new AttackAction(Vortex02PowerATT);
         Vortex02.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Vortex02.opposite = "";
         AssetManager.traits.add(Vortex02);
         PlayerConfig.unlockTrait("Vortex02");
		 
		 ActorTrait Zeta3 = new ActorTrait();
         Zeta3.id = "Zeta 03 Power";
         Zeta3.path_icon = "ui/IconsTraitR/Zeta3";
         Zeta3.type = TraitType.Other;
         Zeta3.group_id = TraitGroups.RobotsSkill;
         Zeta3.can_be_cured = false;
         Zeta3.needs_to_be_explored = false;
         Zeta3.can_be_given = false;
         Zeta3.can_be_removed = true;
         Zeta3.only_active_on_era_flag = false;
         Zeta3.era_active_night = false;
         Zeta3.era_active_moon = false;
         Zeta3.birth = 0.0f;
         Zeta3.inherit = 0.0f;
         Zeta3.action_death = new WorldAction(NoneDeathAction);
         Zeta3.action_special_effect = new WorldAction(NoneRegularAction);
         Zeta3.action_attack_target = new AttackAction(Zeta03PowerATT);
         Zeta3.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Zeta3.opposite = "";
         AssetManager.traits.add(Zeta3);
         PlayerConfig.unlockTrait("Zeta3");
		 
		 
		 ActorTrait Zeta1 = new ActorTrait();
         Zeta1.id = "Zeta 01 Power";
         Zeta1.path_icon = "ui/IconsTraitR/Zeta1";
         Zeta1.type = TraitType.Other;
         Zeta1.group_id = TraitGroups.RobotsSkill;
         Zeta1.can_be_cured = false;
         Zeta1.needs_to_be_explored = false;
         Zeta1.can_be_given = false;
         Zeta1.can_be_removed = true;
         Zeta1.only_active_on_era_flag = false;
         Zeta1.era_active_night = false;
         Zeta1.era_active_moon = false;
         Zeta1.birth = 0.0f;
         Zeta1.inherit = 0.0f;
         Zeta1.action_death = new WorldAction(NoneDeathAction);
         Zeta1.action_special_effect = new WorldAction(NoneRegularAction);
         Zeta1.action_attack_target = new AttackAction(Zeta01PowerATT);
         Zeta1.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Zeta1.opposite = "";
         AssetManager.traits.add(Zeta1);
         PlayerConfig.unlockTrait("Zeta1");
		 
		 
		 ActorTrait Zeta4 = new ActorTrait();
         Zeta4.id = "Zeta 04 Power";
         Zeta4.path_icon = "ui/IconsTraitR/Zeta4";
         Zeta4.type = TraitType.Other;
         Zeta4.group_id = TraitGroups.RobotsSkill;
         Zeta4.can_be_cured = false;
         Zeta4.needs_to_be_explored = false;
         Zeta4.can_be_given = false;
         Zeta4.can_be_removed = true;
         Zeta4.only_active_on_era_flag = false;
         Zeta4.era_active_night = false;
         Zeta4.era_active_moon = false;
         Zeta4.birth = 0.0f;
         Zeta4.inherit = 0.0f;
         Zeta4.action_death = new WorldAction(NoneDeathAction);
         Zeta4.action_special_effect = new WorldAction(NoneRegularAction);
         Zeta4.action_attack_target = new AttackAction(Zeta04PowerATT);
         Zeta4.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Zeta4.opposite = "";
         AssetManager.traits.add(Zeta4);
         PlayerConfig.unlockTrait("Zeta4");
		 
		 ActorTrait Gamma5 = new ActorTrait();
         Gamma5.id = "Gamma 05 Power";
         Gamma5.path_icon = "ui/IconsTraitR/Gamma05";
         Gamma5.type = TraitType.Other;
         Gamma5.group_id = TraitGroups.RobotsSkill;
         Gamma5.can_be_cured = false;
         Gamma5.needs_to_be_explored = false;
         Gamma5.can_be_given = false;
         Gamma5.can_be_removed = true;
         Gamma5.only_active_on_era_flag = false;
         Gamma5.era_active_night = false;
         Gamma5.era_active_moon = false;
         Gamma5.birth = 0.0f;
         Gamma5.inherit = 0.0f;
         Gamma5.action_death = new WorldAction(NoneDeathAction);
         Gamma5.action_special_effect = new WorldAction(NoneRegularAction);
         Gamma5.action_attack_target = new AttackAction(Gamma5PowerATT);
         Gamma5.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Gamma5.opposite = "";
         AssetManager.traits.add(Gamma5);
         PlayerConfig.unlockTrait("Gamma5");  
		 
		 ActorTrait Obtuni01 = new ActorTrait();
         Obtuni01.id = "Obtuni 01 Power";
         Obtuni01.path_icon = "ui/IconsTraitR/Obtuni01_Power";
         Obtuni01.type = TraitType.Other;
         Obtuni01.group_id = TraitGroups.RobotsSkill;
         Obtuni01.can_be_cured = false;
         Obtuni01.needs_to_be_explored = false;
         Obtuni01.can_be_given = false;
         Obtuni01.can_be_removed = true;
         Obtuni01.only_active_on_era_flag = false;
         Obtuni01.era_active_night = false;
         Obtuni01.era_active_moon = false;
         Obtuni01.birth = 0.0f;
         Obtuni01.inherit = 0.0f;
         Obtuni01.action_death = new WorldAction(NoneDeathAction);
         Obtuni01.action_special_effect = new WorldAction(NoneRegularAction);
       //  Obtuni01.action_attack_target = new AttackAction(Obtuni01PowerATT);
         Obtuni01.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Obtuni01.opposite = "";
         AssetManager.traits.add(Obtuni01);
         PlayerConfig.unlockTrait("Obtuni01");
		
		 ActorTrait Obtuni02 = new ActorTrait();
         Obtuni02.id = "Obtuni 02 Power";
         Obtuni02.path_icon = "ui/IconsTraitR/Obtuni02_Power";
         Obtuni02.type = TraitType.Other;
         Obtuni02.group_id = TraitGroups.RobotsSkill;
         Obtuni02.can_be_cured = false;
         Obtuni02.needs_to_be_explored = false;
         Obtuni02.can_be_given = false;
         Obtuni02.can_be_removed = true;
         Obtuni02.only_active_on_era_flag = false;
         Obtuni02.era_active_night = false;
         Obtuni02.era_active_moon = false;
         Obtuni02.birth = 0.0f;
         Obtuni02.inherit = 0.0f;
         Obtuni02.action_death = new WorldAction(NoneDeathAction);
         Obtuni02.action_special_effect = new WorldAction(NoneRegularAction);
        // Obtuni02.action_attack_target = new AttackAction(Obtuni02PowerATT);
         Obtuni02.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Obtuni02.opposite = "";
         AssetManager.traits.add(Obtuni02);
         PlayerConfig.unlockTrait("Obtuni02");
		 
		 ActorTrait Obtuni03 = new ActorTrait();
         Obtuni03.id = "Obtuni 03 Power";
         Obtuni03.path_icon = "ui/IconsTraitR/Obtuni03_Power";
         Obtuni03.type = TraitType.Other;
         Obtuni03.group_id = TraitGroups.RobotsSkill;
         Obtuni03.can_be_cured = false;
         Obtuni03.needs_to_be_explored = false;
         Obtuni03.can_be_given = false;
         Obtuni03.can_be_removed = true;
         Obtuni03.only_active_on_era_flag = false;
         Obtuni03.era_active_night = false;
         Obtuni03.era_active_moon = false;
         Obtuni03.birth = 0.0f;
         Obtuni03.inherit = 0.0f;
         Obtuni03.action_death = new WorldAction(NoneDeathAction);
         Obtuni03.action_special_effect = new WorldAction(NoneRegularAction);
         Obtuni03.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
      //   Obtuni03.action_get_hit = new GetHitAction(Obtuni03a);
		 Obtuni03.opposite = "";
         AssetManager.traits.add(Obtuni03);
         PlayerConfig.unlockTrait("Obtuni03");
		 
		ActorTrait Obtuni04 = new ActorTrait();
         Obtuni04.id = "Obtuni 04 Power";
         Obtuni04.path_icon = "ui/IconsTraitR/Obtuni04_Power";
         Obtuni04.type = TraitType.Other;
         Obtuni04.group_id = TraitGroups.RobotsSkill;
         Obtuni04.can_be_cured = false;
         Obtuni04.needs_to_be_explored = false;
         Obtuni04.can_be_given = false;
         Obtuni04.can_be_removed = true;
         Obtuni04.only_active_on_era_flag = false;
         Obtuni04.era_active_night = false;
         Obtuni04.era_active_moon = false;
         Obtuni04.birth = 0.0f;
         Obtuni04.inherit = 0.0f;
         Obtuni04.action_death = new WorldAction(NoneDeathAction);
         Obtuni04.action_special_effect = new WorldAction(NoneRegularAction);
        // Obtuni04.action_attack_target = new AttackAction(Obtuni04PowerATT);
         Obtuni04.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Obtuni04.opposite = "";
         AssetManager.traits.add(Obtuni04);
         PlayerConfig.unlockTrait("Obtuni04");
		 
		ActorTrait Obtuni05 = new ActorTrait();
         Obtuni05.id = "Obtuni 05 Power";
         Obtuni05.path_icon = "ui/IconsTraitR/Obtuni05_Power";
         Obtuni05.type = TraitType.Other;
         Obtuni05.group_id = TraitGroups.RobotsSkill;
         Obtuni05.can_be_cured = false;
         Obtuni05.needs_to_be_explored = false;
         Obtuni05.can_be_given = false;
         Obtuni05.can_be_removed = true;
         Obtuni05.only_active_on_era_flag = false;
         Obtuni05.era_active_night = false;
         Obtuni05.era_active_moon = false;
         Obtuni05.birth = 0.0f;
         Obtuni05.inherit = 0.0f;
         Obtuni05.action_death = new WorldAction(NoneDeathAction);
         Obtuni05.action_special_effect = new WorldAction(NoneRegularAction);
         //Obtuni05.action_attack_target = new AttackAction(Obtuni05PowerATT);
         Obtuni05.action_get_hit = new GetHitAction(NoneGetAttackedAction);
		 Obtuni05.opposite = "";
         AssetManager.traits.add(Obtuni05);
         PlayerConfig.unlockTrait("Obtuni05");
		 
		 ActorTrait Ultra01 = new ActorTrait();
         Ultra01.id = "Ultra 01 Power";
         Ultra01.path_icon = "ui/IconsTraitR/Ultra01_Power";
         Ultra01.type = TraitType.Other;
         Ultra01.group_id = TraitGroups.RobotsSkill;
         Ultra01.can_be_cured = false;
         Ultra01.needs_to_be_explored = false;
         Ultra01.can_be_given = false;
         Ultra01.can_be_removed = true;
         Ultra01.only_active_on_era_flag = false;
         Ultra01.era_active_night = false;
         Ultra01.era_active_moon = false;
         Ultra01.birth = 0.0f;
         Ultra01.inherit = 0.0f;
         Ultra01.action_death = new WorldAction(NoneDeathAction);
         Ultra01.action_special_effect = new WorldAction(NoneRegularAction);
         Ultra01.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
         Ultra01.action_get_hit = new GetHitAction(Ultra01PowerATTR);
		 Ultra01.opposite = "";
         AssetManager.traits.add(Ultra01);
         PlayerConfig.unlockTrait("Ultra01");
		
		 ActorTrait Ultra02 = new ActorTrait();
         Ultra02.id = "Ultra 02 Power";
         Ultra02.path_icon = "ui/IconsTraitR/Ultra02_Power";
         Ultra02.type = TraitType.Other;
         Ultra02.group_id = TraitGroups.RobotsSkill;
         Ultra02.can_be_cured = false;
         Ultra02.needs_to_be_explored = false;
         Ultra02.can_be_given = false;
         Ultra02.can_be_removed = true;
         Ultra02.only_active_on_era_flag = false;
         Ultra02.era_active_night = false;
         Ultra02.era_active_moon = false;
         Ultra02.birth = 0.0f;
         Ultra02.inherit = 0.0f;
         Ultra02.action_death = new WorldAction(NoneDeathAction);
        // Ultra02.action_special_effect = new WorldAction(NoneRegularAction);
        // Ultra02.action_attack_target = new AttackAction(Ultra02PowerATT);
         Ultra02.action_get_hit = new GetHitAction(Ultra01PowerATTR);
		 Ultra02.opposite = "";
         AssetManager.traits.add(Ultra02);
         PlayerConfig.unlockTrait("Ultra02");
		 
		 ActorTrait Ultra03 = new ActorTrait();
         Ultra03.id = "Ultra 03 Power";
         Ultra03.path_icon = "ui/IconsTraitR/Ultra03_Power";
         Ultra03.type = TraitType.Other;
         Ultra03.group_id = TraitGroups.RobotsSkill;
         Ultra03.can_be_cured = false;
         Ultra03.needs_to_be_explored = false;
         Ultra03.can_be_given = false;
         Ultra03.can_be_removed = true;
         Ultra03.only_active_on_era_flag = false;
         Ultra03.era_active_night = false;
         Ultra03.era_active_moon = false;
         Ultra03.birth = 0.0f;
         Ultra03.inherit = 0.0f;
         Ultra03.action_death = new WorldAction(NoneDeathAction);
         Ultra03.action_special_effect = new WorldAction(NoneRegularAction);
         Ultra03.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
         Ultra03.action_get_hit = new GetHitAction(Ultra03a);
		 Ultra03.opposite = "";
         AssetManager.traits.add(Ultra03);
         PlayerConfig.unlockTrait("Ultra03");
		 
		ActorTrait Ultra04 = new ActorTrait();
         Ultra04.id = "Ultra 04 Power";
         Ultra04.path_icon = "ui/IconsTraitR/Ultra04_Power";
         Ultra04.type = TraitType.Other;
         Ultra04.group_id = TraitGroups.RobotsSkill;
         Ultra04.can_be_cured = false;
         Ultra04.needs_to_be_explored = false;
         Ultra04.can_be_given = false;
         Ultra04.can_be_removed = true;
         Ultra04.only_active_on_era_flag = false;
         Ultra04.era_active_night = false;
         Ultra04.era_active_moon = false;
         Ultra04.birth = 0.0f;
         Ultra04.inherit = 0.0f;
         Ultra04.action_death = new WorldAction(NoneDeathAction);
         Ultra04.action_special_effect = new WorldAction(NoneRegularAction);
         Ultra04.action_attack_target = new AttackAction(NoneAttackSomeoneAction);
         Ultra04.action_get_hit = new GetHitAction(Ultra03a);
		 Ultra04.opposite = "";
         AssetManager.traits.add(Ultra04);
         PlayerConfig.unlockTrait("Ultra04");
		 
		ActorTrait Ultra05 = new ActorTrait();
         Ultra05.id = "Ultra 05 Power";
         Ultra05.path_icon = "ui/IconsTraitR/Ultra05_Power";
         Ultra05.type = TraitType.Other;
         Ultra05.group_id = TraitGroups.RobotsSkill;
         Ultra05.can_be_cured = false;
         Ultra05.needs_to_be_explored = false;
         Ultra05.can_be_given = false;
         Ultra05.can_be_removed = true;
         Ultra05.only_active_on_era_flag = false;
         Ultra05.era_active_night = false;
         Ultra05.era_active_moon = false;
         Ultra05.birth = 0.0f;
         Ultra05.inherit = 0.0f;
         Ultra05.action_death = new WorldAction(NoneDeathAction);
         Ultra05.action_special_effect = new WorldAction(NoneRegularAction);
        // Ultra05.action_attack_target = new AttackAction(Ultra05PowerATT);
         Ultra05.action_get_hit = new GetHitAction(Ultra05P);
		 Ultra05.opposite = "";
         AssetManager.traits.add(Ultra05);
         PlayerConfig.unlockTrait("Ultra05"); 
		 
		ActorTrait Aegis01 = new ActorTrait();
         Aegis01.id = "Aegis 01";
         Aegis01.path_icon = "ui/IconsTraitR/Aegis01_Power";
         Aegis01.type = TraitType.Other;
         Aegis01.group_id = TraitGroups.RobotsSkill;
         Aegis01.can_be_cured = false;
         Aegis01.needs_to_be_explored = false;
         Aegis01.can_be_given = false;
         Aegis01.can_be_removed = true;
         Aegis01.only_active_on_era_flag = false;
         Aegis01.era_active_night = false;
         Aegis01.era_active_moon = false;
		 Aegis01.action_get_hit = new GetHitAction(Aegis01asa);
         Aegis01.birth = 0.0f;
         Aegis01.inherit = 0.0f;
         AssetManager.traits.add(Aegis01);
         PlayerConfig.unlockTrait("Aegis01"); 
              
        }
        public static bool Aegis01asa(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.6f)){
         pSelf.CallMethod("addStatusEffect", "INDESTEM", 10f);
		 
		 
		 
            
		}
        return false;
 
        }
        public static bool MaldiRasaD(BaseSimObject pTarget, WorldTile pTile = null)
        {
        if(Toolbox.randomChance(0.8f)){
         pTarget.CallMethod("addStatusEffect", "FuegoAzul", 30f);
          
          
          
        }
        return false;

        }
        public static bool Ultra05P(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(1.0f)){
         pSelf.CallMethod("addStatusEffect", "ShieldU5", 15f);
		 
		 
		 
            
		}
        return false;
 
        }
        public static bool Mark4Pa(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pSelf.a;
             
            if (pTarget != null && Toolbox.randomChance(0.6f)){
                pTarget.addStatusEffect("DebilidadCriticaE", 60f);
            }


            return false;
        }
        public static bool Mark3Pa(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pSelf.a;
             
            if (pTarget != null && Toolbox.randomChance(0.6f)){
                pTarget.addStatusEffect("DebilidadCriticaE", 60f);
            }


            return false;
        }
        public static bool Mark2Pa(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pSelf.a;
             
            if (pTarget != null && Toolbox.randomChance(0.6f)){
                pTarget.addStatusEffect("DebilidadCriticaE", 60f);
            }


            return false;
        }
        public static bool Ultra03a(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(1.0f)){
         pSelf.CallMethod("addStatusEffect", "ShieldU34", 15f);
		 
		 
		 
            
		}
        return false;
 
        }
        public static bool Ultra01PowerATTR(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(1.0f)){
         pSelf.CallMethod("addStatusEffect", "ShieldU12", 10f);
		 
		 
		 
            
		}
        return false;
 
        }
        public static bool Obtuni04PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null) 
		{
                if (pTarget != null)
        {
            
            Actor a = pTarget as Actor; 
            if (a != null && Toolbox.randomChance(40.0f))
            {
                Vector2Int pos = pTile.pos;
                float pDist = Vector2.Distance(pTarget.currentPosition, pos);
                Vector3 startPoint = Toolbox.getNewPoint(
                    pSelf.currentPosition.x, 
                    pSelf.currentPosition.y, 
                    pos.x, 
                    pos.y, 
                    pDist, 
                    true
                );
                Vector3 targetPoint = Toolbox.getNewPoint(
                    pTarget.currentPosition.x, 
                    pTarget.currentPosition.y, 
                    pos.x, 
                    pos.y, 
                    a.stats[S.size], 
                    true
                );
                EffectsLibrary.spawnProjectile("Obtuni04AT4", startPoint, targetPoint, 0.0f);
               }
        }
        return false;
		
        }
        public static bool Obtuni05PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pSelf.a;
             
            if (pTarget != null && Toolbox.randomChance(0.2f)){
                pTarget.addStatusEffect("DebilidadCriticaE", 3f);
				pTarget.addStatusEffect("frozen", 6f);
            }

            return false;
        }
        public static bool Gamma04PowerATTR(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.3f)){
         pSelf.CallMethod("addStatusEffect", "ShieldGM4", 10f);
		 
		 
            
		}
        return false;
 
        }
        public static bool Gamma02PowerATT(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.3f)){
         pSelf.CallMethod("addStatusEffect", "FastModeGM2", 10f);
		 
		 
            
		}
        return false;
 
        }
        public static bool Delta01PowerATTR(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.1f)){
         pSelf.CallMethod("addStatusEffect", "ShieldDelta01", 20f);
		 
		 
            
		}
        return false;
 
        }
        public static bool Delta02PowerATTR(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.1f)){
         pSelf.CallMethod("addStatusEffect", "invincible", 4f);
		 
		 
            
		}
        return false;
 
        }
        public static bool Delta03PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pSelf.a;
             
            if (pTarget != null && Toolbox.randomChance(0.2f)){
                pTarget.addStatusEffect("DebilidadCriticaE", 3f);
            }

            return false;
        }
        public static bool Delta04PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
		{
		if(pTarget != null){
        Actor a = pSelf.a;
        if(Toolbox.randomChance(0.20f)){
         pSelf.CallMethod("addStatusEffect", "AgressiveModeD4", 10f);
		}
		 
            
		}
        return false;
 
        }
        public static bool Omega02PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
		if(pTarget != null){
        Actor a = pSelf.a;
        if(Toolbox.randomChance(0.20f)){
         pSelf.CallMethod("addStatusEffect", "AgressiveModeOM2", 10f);
		}
		 
            
		}
        return false;
 
        }
        public static bool Omega03PowerATTR(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.2f)){
         pSelf.CallMethod("addStatusEffect", "FastModeOM3", 12f);
		 
		 
            
		}
        return false;
 
        }
        public static bool Omega05PowerATTR(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.2f)){
         pSelf.CallMethod("addStatusEffect", "ShieldOM5", 12f);
		 
		 
            
		}
        return false;
 
        }
        public static bool Vortex04PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
          Actor a = pSelf.a;

    
            if (pTarget != null)
            {
        
             if (Toolbox.randomChance(0.2f))
            {
             pTarget.addStatusEffect("DebilidadCriticaE", 8f);
            }
          
         
        if (Toolbox.randomChance(0.2f))
        {
            pSelf.CallMethod("addStatusEffect", "ShieldV4", 10f);
           }
        }

        return false;
        }
        public static bool Vortex05PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pSelf.a;
             
            if (pTarget != null && Toolbox.randomChance(0.2f)){
                pTarget.addStatusEffect("DebilidadCriticaE", 3f);
            }

            return false;
        }
        public static bool Vortex02PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pSelf.a;
             
            if (pTarget != null && Toolbox.randomChance(0.2f)){
                pTarget.a.addStatusEffect("DebilidadCriticaE", 3f);
            }

            return false;
        }
        public static bool Mark1P(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.023f)){
         pSelf.CallMethod("addStatusEffect", "StructuralDamage", 12f);
		}
		if(Toolbox.randomChance(0.012f)){
         pSelf.CallMethod("addStatusEffect", "Misalignment", 8f);
		}
		if(Toolbox.randomChance(0.022f)){
         pSelf.CallMethod("addStatusEffect", "MechanicalWear", 8f);
		}
		if(Toolbox.randomChance(0.0122f)){
         pSelf.CallMethod("addStatusEffect", "SensorFailure", 8f);
		}
		if(Toolbox.randomChance(0.0022f)){
         pSelf.CallMethod("addStatusEffect", "MechanicalFailure", 8f);
		 
		 
            
		}
        return false;
 
        }
        public static bool Mark2P(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.023f)){
         pSelf.CallMethod("addStatusEffect", "StructuralDamage", 12f);
		}
		if(Toolbox.randomChance(0.012f)){
         pSelf.CallMethod("addStatusEffect", "Misalignment", 8f);
		}
		if(Toolbox.randomChance(0.022f)){
         pSelf.CallMethod("addStatusEffect", "MechanicalWear", 8f);
		}
		if(Toolbox.randomChance(0.0122f)){
         pSelf.CallMethod("addStatusEffect", "SensorFailure", 8f);
		 
		 
            
		}
        return false;
 
        }
        public static bool Mark3P(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.023f)){
         pSelf.CallMethod("addStatusEffect", "StructuralDamage", 12f);
		}
		if(Toolbox.randomChance(0.012f)){
         pSelf.CallMethod("addStatusEffect", "Misalignment", 8f);
		}
		if(Toolbox.randomChance(0.022f)){
         pSelf.CallMethod("addStatusEffect", "MechanicalWear", 8f);
		 
		 
            
		}
        return false;
 
        }
        public static bool Mark4P(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.03f)){
         pSelf.CallMethod("addStatusEffect", "StructuralDamage", 5f);
		}
		if(Toolbox.randomChance(0.02f)){
         pSelf.CallMethod("addStatusEffect", "Misalignment", 6f);
		 
		 
            
		}
        return false;
 
        }
        public static bool Mark5P(BaseSimObject pSelf, BaseSimObject pAttackedBy = null, WorldTile pTile = null)
		{
        Actor a = pSelf.a;
		if(Toolbox.randomChance(0.03f)){
         pSelf.CallMethod("addStatusEffect", "StructuralDamage", 5f);
		 
		 
            
		}
        return false;
 
        }
        public static bool Mark5Pow(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pSelf.a;
             
            if (pTarget != null && Toolbox.randomChance(0.6f)){
                pTarget.addStatusEffect("DebilidadCriticaEX", 10f);
            }


            return false;
        }
        public static bool Zeta04PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pSelf.a;
            if(Toolbox.randomChance(0.2f)){
                pSelf.CallMethod("addStatusEffect", "EnergyFistsZ4", 5f);
            
			
        }
        return false;
 
        }
        public static bool Gamma5PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pSelf.a;
             
            if (pTarget != null && Toolbox.randomChance(0.8f)){
                pTarget.a.addStatusEffect("DebilidadCriticaE", 6f);
            }

            return false;
        }
        public static bool Zeta03PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
		{
		if(pTarget != null){
        Actor a = pSelf.a;
        if(Toolbox.randomChance(0.2f)){
         pSelf.CallMethod("addStatusEffect", "ShieldZ3", 15f);
		}
		 
            
		}
        return false;

        }
        public static bool Zeta01PowerATT(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
            Actor a = pSelf.a;
            if(Toolbox.randomChance(0.05f)){
                pSelf.CallMethod("addStatusEffect", "ShieldZ1", 2f);
            }
        

            if (pTarget != null && Toolbox.randomChance(0.211f)){
                pTarget.addStatusEffect("DebilidadCriticaE", 3f);
            
         
           
        }
        return false;
 
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
    }
}
