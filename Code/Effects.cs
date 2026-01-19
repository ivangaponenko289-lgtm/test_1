using System;
using System.Threading;
using NCMS;
using UnityEngine;
using ReflectionUtility;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using Beebyte.Obfuscator;

namespace AmbientWar
{
    class Effects
    {
        public static void init()
        {

			StatusEffect ShieldZ3 = new StatusEffect();
            ShieldZ3.name = "status_title_ShieldZ3";
            ShieldZ3.description = "status_description_ShieldZ3";
            ShieldZ3.id = "ShieldZ3";
            ShieldZ3.texture = "ShieldZ3t";
            ShieldZ3.animated = true;
            ShieldZ3.animation_speed = 0.2f;
			ShieldZ3.base_stats[S.armor] = 100;
            ShieldZ3.base_stats[S.attack_speed] = 0f;
            ShieldZ3.base_stats[S.damage] = 20;
            ShieldZ3.base_stats[S.speed] = 0f;
            ShieldZ3.duration = 10f;
            ShieldZ3.path_icon = "ui/Icons/ShieldZ3IM";
            ShieldZ3.draw_light_area = false;
            ShieldZ3.draw_light_size = 0.0f;
            AssetManager.status.add(ShieldZ3);
			
			StatusEffect ShieldOI3 = new StatusEffect();
            ShieldOI3.name = "status_title_ShieldOI3";
            ShieldOI3.description = "status_description_ShieldOI3";
            ShieldOI3.id = "ShieldOI3";
            ShieldOI3.texture = "ShieldOI3";
            ShieldOI3.animated = true;
            ShieldOI3.animation_speed = 0.2f;
			ShieldOI3.base_stats[S.armor] = 160;
            ShieldOI3.base_stats[S.attack_speed] = 15f;
            ShieldOI3.base_stats[S.damage] = 150;
            ShieldOI3.base_stats[S.speed] = 0f;
            ShieldOI3.duration = 40f;
            ShieldOI3.path_icon = "ui/Icons/ShieldOI3IM";
            ShieldOI3.draw_light_area = false;
            ShieldOI3.draw_light_size = 0.0f;
            AssetManager.status.add(ShieldOI3);
			
            StatusEffect AgressiveModeD4 = new StatusEffect();
            AgressiveModeD4.name = "status_title_AgressiveModeD4";
            AgressiveModeD4.description = "status_description_AgressiveModeD4";
            AgressiveModeD4.id = "AgressiveModeD4";
			AgressiveModeD4.base_stats[S.armor] = 0;
            AgressiveModeD4.base_stats[S.attack_speed] = 80f;
            AgressiveModeD4.base_stats[S.mod_damage] = 0.5f;
            AgressiveModeD4.base_stats[S.speed] = 80f;
            AgressiveModeD4.duration = 10f;
            AgressiveModeD4.path_icon = "ui/Icons/AgressiveModeD4IM";
            AgressiveModeD4.draw_light_area = false;
            AgressiveModeD4.draw_light_size = 0.0f;
            AssetManager.status.add(AgressiveModeD4);
			
            StatusEffect ShieldDelta01 = new StatusEffect();
            ShieldDelta01.name = "status_title_ShieldDelta01";
            ShieldDelta01.description = "status_description_ShieldDelta01";
            ShieldDelta01.id = "ShieldDelta01";
            ShieldDelta01.texture = "ShieldDelta01r";
            ShieldDelta01.animated = true;
            ShieldDelta01.animation_speed = 0.2f;
			ShieldDelta01.base_stats[S.armor] = 80;
            ShieldDelta01.base_stats[S.attack_speed] = 5f;
            ShieldDelta01.base_stats[S.damage] = 2;
            ShieldDelta01.base_stats[S.speed] = 6f;
            ShieldDelta01.duration = 50f;
            ShieldDelta01.path_icon = "ui/Icons/ShieldDelta01IM";
            ShieldDelta01.draw_light_area = false;
            ShieldDelta01.draw_light_size = 0.0f;
            AssetManager.status.add(ShieldDelta01);
			
            StatusEffect ShieldZ1 = new StatusEffect();
            ShieldZ1.name = "status_title_ShieldZ1";
            ShieldZ1.description = "status_description_ShieldZ1";
            ShieldZ1.id = "ShieldZ1";
            ShieldZ1.texture = "ShieldZ1t";
            ShieldZ1.animated = true;
            ShieldZ1.animation_speed = 0.2f;
			ShieldZ1.base_stats[S.armor] = 100;
            ShieldZ1.base_stats[S.attack_speed] = 0f;
            ShieldZ1.base_stats[S.damage] = 10;
            ShieldZ1.base_stats[S.speed] = 0f;
            ShieldZ1.duration = 10f;
            ShieldZ1.path_icon = "ui/Icons/ShieldZ1IM";
            ShieldZ1.draw_light_area = false;
            ShieldZ1.draw_light_size = 0.0f;
            AssetManager.status.add(ShieldZ1);
			
            StatusEffect ShieldV4 = new StatusEffect();
            ShieldV4.name = "status_title_ShieldV4";
            ShieldV4.description = "status_description_ShieldV4";
            ShieldV4.id = "ShieldV4";
            ShieldV4.texture = "ShieldVO04";
            ShieldV4.animated = true;
            ShieldV4.animation_speed = 0.2f;
			ShieldV4.base_stats[S.armor] = 140;
            ShieldV4.base_stats[S.attack_speed] = 0f;
            ShieldV4.base_stats[S.damage] = 10;
            ShieldV4.base_stats[S.speed] = 20f;
            ShieldV4.duration = 10f;
            ShieldV4.path_icon = "ui/Icons/ShieldV4IM";
            ShieldV4.draw_light_area = false;
            ShieldV4.draw_light_size = 0.0f;
            AssetManager.status.add(ShieldV4);
			
            StatusEffect ShieldOM5 = new StatusEffect();
            ShieldOM5.name = "status_title_ShieldOM5";
            ShieldOM5.description = "status_description_ShieldOM5";
            ShieldOM5.id = "ShieldOM5";
            ShieldOM5.texture = "ShieldOM5r";
            ShieldOM5.animated = true;
            ShieldOM5.animation_speed = 0.2f;
			ShieldOM5.base_stats[S.armor] = 100;
            ShieldOM5.base_stats[S.attack_speed] = 0f;
            ShieldOM5.base_stats[S.damage] = 40;
            ShieldOM5.base_stats[S.speed] = 10f;
            ShieldOM5.duration = 10f;
            ShieldOM5.path_icon = "ui/Icons/ShieldOM5IM";
            ShieldOM5.draw_light_area = false;
            ShieldOM5.draw_light_size = 0.0f;
            AssetManager.status.add(ShieldOM5);
			
            StatusEffect FastModeOM3 = new StatusEffect();
            FastModeOM3.name = "status_title_FastModeOM3";
            FastModeOM3.description = "status_description_FastModeOM3";
            FastModeOM3.id = "FastModeOM3";
            FastModeOM3.texture = "FastModeOM3r";
            FastModeOM3.animated = true;
            FastModeOM3.animation_speed = 0.2f;
			FastModeOM3.base_stats[S.armor] = -10;
            FastModeOM3.base_stats[S.attack_speed] = 57f;
            FastModeOM3.base_stats[S.damage] = 0;
            FastModeOM3.base_stats[S.speed] = 57f;
            FastModeOM3.duration = 10f;
            FastModeOM3.path_icon = "ui/Icons/FastModeOM3IM";
            FastModeOM3.draw_light_area = false;
            FastModeOM3.draw_light_size = 0.0f;
            AssetManager.status.add(FastModeOM3);
			
            StatusEffect AgressiveModeOM2 = new StatusEffect();
            AgressiveModeOM2.name = "status_title_AgressiveModeOM2";
            AgressiveModeOM2.description = "status_description_AgressiveModeOM2";
            AgressiveModeOM2.id = "AgressiveModeOM2";
            AgressiveModeOM2.texture = "AgressiveModeOM2r";
            AgressiveModeOM2.animated = true;
            AgressiveModeOM2.animation_speed = 0.2f;
			AgressiveModeOM2.base_stats[S.armor] = 0;
            AgressiveModeOM2.base_stats[S.attack_speed] = 0f;
            AgressiveModeOM2.base_stats[S.damage] = 400;
            AgressiveModeOM2.base_stats[S.speed] = 10f;
			AgressiveModeOM2.base_stats[S.critical_chance] = 1.0f;
            AgressiveModeOM2.duration = 10f;
            AgressiveModeOM2.path_icon = "ui/Icons/AgressiveModeOM2IM";
            AgressiveModeOM2.draw_light_area = false;
            AgressiveModeOM2.draw_light_size = 0.0f;
            AssetManager.status.add(AgressiveModeOM2);
			
			StatusEffect FastModeGM2 = new StatusEffect();
            FastModeGM2.name = "status_title_FastModeGM2";
            FastModeGM2.description = "status_description_FastModeGM2";
            FastModeGM2.id = "FastModeGM2";
            FastModeGM2.texture = "FastModeGM2r";
            FastModeGM2.animated = true;
            FastModeGM2.animation_speed = 0.2f;
			FastModeGM2.base_stats[S.armor] = 0;
            FastModeGM2.base_stats[S.attack_speed] = 130f;
            FastModeGM2.base_stats[S.damage] = -50;
            FastModeGM2.base_stats[S.speed] = 90f;
            FastModeGM2.duration = 10f;
            FastModeGM2.path_icon = "ui/Icons/FastModeGM2IM";
            FastModeGM2.draw_light_area = false;
            FastModeGM2.draw_light_size = 0.0f;
            AssetManager.status.add(FastModeGM2);
			
			StatusEffect ShieldGM4 = new StatusEffect();
            ShieldGM4.name = "status_title_ShieldGM4";
            ShieldGM4.description = "status_description_ShieldGM4";
            ShieldGM4.id = "ShieldGM4";
            ShieldGM4.texture = "ShieldGM4r";
            ShieldGM4.animated = true;
            ShieldGM4.animation_speed = 0.2f;
			ShieldGM4.base_stats[S.armor] = 170;
            ShieldGM4.base_stats[S.attack_speed] = 20f;
            ShieldGM4.base_stats[S.damage] = 100;
            ShieldGM4.base_stats[S.speed] = 0f;
            ShieldGM4.duration = 10f;
            ShieldGM4.path_icon = "ui/Icons/ShieldGM4IM";
            ShieldGM4.draw_light_area = false;
            ShieldGM4.draw_light_size = 0.0f;
            AssetManager.status.add(ShieldGM4);
			
			StatusEffect SobreCalentamientoEffect = new StatusEffect();
            SobreCalentamientoEffect.name = "status_title_SobreCalentamiento";
            SobreCalentamientoEffect.description = "status_description_SobreCalentamiento";
            SobreCalentamientoEffect.id = "SobreCalentamiento";
            SobreCalentamientoEffect.texture = "SobreCalentamiento";
            SobreCalentamientoEffect.animated = true;
            SobreCalentamientoEffect.animation_speed = 0.2f;
            SobreCalentamientoEffect.base_stats[S.fertility] = 0f;
            SobreCalentamientoEffect.base_stats[S.max_children] = 0f;
            SobreCalentamientoEffect.base_stats[S.max_age] = 0f;
            SobreCalentamientoEffect.base_stats[S.attack_speed] = -29f;
            SobreCalentamientoEffect.base_stats[S.damage] = -20;
            SobreCalentamientoEffect.base_stats[S.speed] = -20f;
            SobreCalentamientoEffect.base_stats[S.health] = 0;
            SobreCalentamientoEffect.duration = 30f;
            SobreCalentamientoEffect.path_icon = "ui/Icons/Sobre_Calentamiento";
            SobreCalentamientoEffect.draw_light_area = false;
            SobreCalentamientoEffect.draw_light_size = 0.0f;
            AssetManager.status.add(SobreCalentamientoEffect);
			
			StatusEffect MechanicalFailureEffect = new StatusEffect();
			MechanicalFailureEffect.name = "status_title_MechanicalFailure";
			MechanicalFailureEffect.description = "status_description_MechanicalFailure";
			MechanicalFailureEffect.id = "MechanicalFailure";
			MechanicalFailureEffect.base_stats[S.speed] = -30f;
			MechanicalFailureEffect.base_stats[S.attack_speed] = -25f;
			MechanicalFailureEffect.base_stats[S.damage] = -15f;
			MechanicalFailureEffect.duration = 40f;
			MechanicalFailureEffect.path_icon = "ui/Icons/Mechanical_Failure";
			MechanicalFailureEffect.draw_light_area = false;
			MechanicalFailureEffect.draw_light_size = 0.0f;
			AssetManager.status.add(MechanicalFailureEffect);
			
			StatusEffect SensorFailureEffect = new StatusEffect();
			SensorFailureEffect.name = "status_title_SensorFailure";
			SensorFailureEffect.description = "status_description_SensorFailure";
			SensorFailureEffect.id = "SensorFailure";
			SensorFailureEffect.base_stats[S.attack_speed] = -40f;
			SensorFailureEffect.base_stats[S.damage] = 0f;
			SensorFailureEffect.base_stats[S.accuracy] = -70f;
			SensorFailureEffect.duration = 30f;
			SensorFailureEffect.path_icon = "ui/Icons/Sensor_Failure";
			SensorFailureEffect.draw_light_area = false;
			SensorFailureEffect.draw_light_size = 0.0f;
			AssetManager.status.add(SensorFailureEffect);
			
			StatusEffect MechanicalWearEffect = new StatusEffect();
			MechanicalWearEffect.name = "status_title_MechanicalWear";
			MechanicalWearEffect.description = "status_description_MechanicalWear";
			MechanicalWearEffect.id = "MechanicalWear";
			MechanicalWearEffect.base_stats[S.speed] = -55f;
			MechanicalWearEffect.base_stats[S.attack_speed] = -35f;
			MechanicalWearEffect.base_stats[S.damage] = 0f;
			MechanicalWearEffect.base_stats[S.armor] = -5f;
			MechanicalWearEffect.duration = 50f;
			MechanicalWearEffect.path_icon = "ui/Icons/Mechanical_Wear";
			MechanicalWearEffect.draw_light_area = false;
			MechanicalWearEffect.draw_light_size = 0.0f;
			AssetManager.status.add(MechanicalWearEffect);
		
			StatusEffect StructuralDamageEffect = new StatusEffect();
			StructuralDamageEffect.name = "status_title_StructuralDamage";
			StructuralDamageEffect.description = "status_description_StructuralDamage";
			StructuralDamageEffect.id = "StructuralDamage";
			StructuralDamageEffect.base_stats[S.speed] = -50f;
			StructuralDamageEffect.base_stats[S.damage] = 0f;
			StructuralDamageEffect.base_stats[S.armor] = -30f;
			StructuralDamageEffect.duration = 45f;
			StructuralDamageEffect.path_icon = "ui/Icons/Structural_Damage";
			StructuralDamageEffect.draw_light_area = false;
			StructuralDamageEffect.draw_light_size = 0.0f;
			AssetManager.status.add(StructuralDamageEffect);

			StatusEffect MisalignmentEffect = new StatusEffect();
			MisalignmentEffect.name = "status_title_Misalignment";
			MisalignmentEffect.description = "status_description_Misalignment";
			MisalignmentEffect.id = "Misalignment";
			MisalignmentEffect.base_stats[S.speed] = -50f;
			MisalignmentEffect.base_stats[S.attack_speed] = -60f;
			MisalignmentEffect.base_stats[S.accuracy] = -60f;
			MisalignmentEffect.duration = 35f;
			MisalignmentEffect.path_icon = "ui/Icons/Misalignment";
			MisalignmentEffect.draw_light_area = false;
			MisalignmentEffect.draw_light_size = 0.0f;
			AssetManager.status.add(MisalignmentEffect);

			StatusEffect DebilidadCriticaE = new StatusEffect();
            DebilidadCriticaE.name = "status_title_DebilidadCriticaE";
            DebilidadCriticaE.description = "status_description_DebilidadCriticaE";
            DebilidadCriticaE.id = "DebilidadCriticaE";
            DebilidadCriticaE.texture = "Critical_WeaknessAN";
            DebilidadCriticaE.animated = true;
            DebilidadCriticaE.animation_speed = 0.2f;
            DebilidadCriticaE.base_stats[S.fertility] = 0f;
            DebilidadCriticaE.base_stats[S.max_children] = 0f;
            DebilidadCriticaE.base_stats[S.max_age] = 0f;
            DebilidadCriticaE.base_stats[S.attack_speed] = -20f;
			DebilidadCriticaE.base_stats[S.armor] = -70;
            DebilidadCriticaE.base_stats[S.damage] = -50;
            DebilidadCriticaE.base_stats[S.speed] = -30f;
            DebilidadCriticaE.base_stats[S.health] = 0;
            DebilidadCriticaE.duration = 150f;
            DebilidadCriticaE.path_icon = "ui/Icons/Critical_Weakness";
            DebilidadCriticaE.draw_light_area = false;
            DebilidadCriticaE.draw_light_size = 0.0f;
            AssetManager.status.add(DebilidadCriticaE);
			
			StatusEffect DebilidadCriticaEX = new StatusEffect();
            DebilidadCriticaEX.name = "status_title_DebilidadCriticaEX";
            DebilidadCriticaEX.description = "status_description_DebilidadCriticaEX";
            DebilidadCriticaEX.id = "DebilidadCriticaEX";
            DebilidadCriticaEX.texture = "Critical_WeaknessAN";
            DebilidadCriticaEX.animated = true;
            DebilidadCriticaEX.animation_speed = 0.2f;
            DebilidadCriticaEX.base_stats[S.fertility] = 0f;
            DebilidadCriticaEX.base_stats[S.max_children] = 0f;
            DebilidadCriticaEX.base_stats[S.max_age] = 0f;
            DebilidadCriticaEX.base_stats[S.attack_speed] = -100f;
			DebilidadCriticaEX.base_stats[S.armor] = -120;
            DebilidadCriticaEX.base_stats[S.damage] = -300;
            DebilidadCriticaEX.base_stats[S.speed] = -90f;
            DebilidadCriticaEX.base_stats[S.health] = 0;
            DebilidadCriticaEX.duration = 30f;
            DebilidadCriticaEX.path_icon = "ui/Icons/Extreme_Critical_Weakness";
            DebilidadCriticaEX.draw_light_area = false;
            DebilidadCriticaEX.draw_light_size = 0.0f;
            AssetManager.status.add(DebilidadCriticaEX);
			
			StatusEffect EnergyFistsZ4 = new StatusEffect();
            EnergyFistsZ4.name = "status_title_EnergyFistsZ4";
            EnergyFistsZ4.description = "status_description_EnergyFistsZ4";
            EnergyFistsZ4.id = "EnergyFistsZ4";
            EnergyFistsZ4.texture = "EnergyFistsZ4AN";
            EnergyFistsZ4.animated = true;
            EnergyFistsZ4.animation_speed = 0.2f;
            EnergyFistsZ4.base_stats[S.attack_speed] = 60f;
            EnergyFistsZ4.base_stats[S.damage] = 500;
            EnergyFistsZ4.base_stats[S.speed] = 0f;
            EnergyFistsZ4.duration = 10f;
            EnergyFistsZ4.path_icon = "ui/Icons/EnergyFistsZ4";
            EnergyFistsZ4.draw_light_area = false;
            EnergyFistsZ4.draw_light_size = 0.0f;
            AssetManager.status.add(EnergyFistsZ4);
			
			StatusEffect FuegoAzul = new StatusEffect();
            FuegoAzul.name = "status_title_FuegoAzul";
            FuegoAzul.description = "status_description_FuegoAzul";
            FuegoAzul.id = "FuegoAzul";
            FuegoAzul.texture = "FuegoAzulAN";
            FuegoAzul.animated = true;
            FuegoAzul.animation_speed = 0.2f;
			FuegoAzul.action = new WorldAction(FireBlueEff);
			FuegoAzul.action_interval = 1f;
            FuegoAzul.duration = 50f;
            FuegoAzul.path_icon = "ui/Icons/FuegoAzul";
            FuegoAzul.draw_light_area = true;
            FuegoAzul.draw_light_size = 0.8f;
            AssetManager.status.add(FuegoAzul);
			
            StatusEffect ShieldU12 = new StatusEffect();
            ShieldU12.name = "status_title_ShieldU12";
            ShieldU12.description = "status_description_ShieldU12";
            ShieldU12.id = "ShieldU12";
            ShieldU12.texture = "ShieldU12t";
            ShieldU12.animated = true;
            ShieldU12.animation_speed = 0.2f;
			ShieldU12.base_stats[S.armor] = 100;
            ShieldU12.duration = 10f;
            ShieldU12.path_icon = "ui/Icons/ShieldU12IM";
            ShieldU12.draw_light_area = false;
			ShieldU12.action_get_hit = new GetHitAction(ShieldAdvan);
            ShieldU12.draw_light_size = 0.0f;
            AssetManager.status.add(ShieldU12);
			
            StatusEffect ShieldU34 = new StatusEffect();
            ShieldU34.name = "status_title_ShieldU34";
            ShieldU34.description = "status_description_ShieldU34";
            ShieldU34.id = "ShieldU34";
            ShieldU34.texture = "ShieldU34t";
            ShieldU34.animated = true;
            ShieldU34.animation_speed = 0.2f;
			ShieldU34.base_stats[S.armor] = 120;
            ShieldU34.duration = 10f;
            ShieldU34.path_icon = "ui/Icons/ShieldU34IM";
            ShieldU34.draw_light_area = false;
			ShieldU34.action_get_hit = new GetHitAction(ShieldAdvan);
            ShieldU34.draw_light_size = 0.0f;
            AssetManager.status.add(ShieldU34);
			
            StatusEffect ShieldU5 = new StatusEffect();
            ShieldU5.name = "status_title_ShieldU5";
            ShieldU5.description = "status_description_ShieldU5";
            ShieldU5.id = "ShieldU5";
            ShieldU5.texture = "ShieldU5t";
            ShieldU5.animated = true;
            ShieldU5.animation_speed = 0.2f;
			ShieldU5.base_stats[S.armor] = 150;
            ShieldU5.duration = 10f;
            ShieldU5.path_icon = "ui/Icons/ShieldU5IM";
            ShieldU5.draw_light_area = false;
			ShieldU5.action_get_hit = new GetHitAction(ShieldAdvan);
            ShieldU5.draw_light_size = 0.0f;
            AssetManager.status.add(ShieldU5);
			
			StatusEffect INDESTEM = new StatusEffect();
            INDESTEM.name = "status_title_INDESTEM";
            INDESTEM.description = "status_description_INDESTEM";
            INDESTEM.id = "INDESTEM";
            INDESTEM.texture = "INDESTEMAN";
            INDESTEM.animated = true;
            INDESTEM.animation_speed = 0.2f;
			INDESTEM.action_interval = 1f;
            INDESTEM.duration = 50f;
            INDESTEM.path_icon = "ui/Icons/INDESTEMeffect";
            INDESTEM.draw_light_area = true;
			INDESTEM.action = new WorldAction(INDESTEMasaD);
            INDESTEM.draw_light_size = 0.8f;
            AssetManager.status.add(INDESTEM);

           //COMPATIBILIDAD: REMOVER ESTADOS POR OTRO ESTADO 
        }
        public static bool INDESTEMasaD(BaseSimObject pTarget, WorldTile pTile = null)
        {
            if (pTarget.a.hasTrait("infected"))
            {
                return false; 
            }
            bool canRegenerate = true;
            if (pTarget.a.asset.needFood)
            {
                canRegenerate = pTarget.a.data.hunger > 20; 
            }
            if (pTarget.a.data.health < pTarget.getMaxHealth() && canRegenerate)
            {
                float regenerationChance = 0.5f; 
                int healthRestorationAmount = 5; 
                if (Toolbox.randomChance(regenerationChance))
                {
                    pTarget.a.restoreHealth(healthRestorationAmount); 
                    pTarget.a.spawnParticle(Toolbox.color_heal); 
                }
            }
            return true; 
        }
        public static bool FireBlueEff(BaseSimObject pTarget, WorldTile pTile = null)
        {
            if (pTarget.isActor() && pTarget.a.asset.has_skin)
            {
                pTarget.a.addTrait("skin_burns", false);
            }
            int damage = (int)((float)pTarget.getMaxHealth() * 0.5f) + 10;
            if (pTarget.isBuilding() && pTarget.b.isRuin())
            {
                damage = (int)((float)damage * 0.5f + 10f);
            }
            pTarget.getHit((float)damage, true, AttackType.Fire, null, true, false);
            if (MapBox.isRenderGameplay() && Toolbox.randomChance(1.0f))
            {
                World.world.particlesFire.spawn(pTarget.currentPosition.x, pTarget.currentPosition.y, true);
            }
            return false; 
        }
        public static bool ShieldAdvan(BaseSimObject pSelf, BaseSimObject pAttackedBy, WorldTile pTile = null)
        {
            BaseEffect baseEffect = EffectsLibrary.spawnAt("fx_shield_hit", pSelf.currentPosition, 1f);
            if (baseEffect == null)
            {
                return false;
            }
            baseEffect.attachTo(pSelf.a);
            return true;
        }

    }
}
