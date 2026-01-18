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
    class proyectiles
    {
        public static void init()
        {
 
          craftitems();
 
          static void craftitems() {
 
          Race human = AssetManager.raceLibrary.get("human");
          Race orc = AssetManager.raceLibrary.get("orc");
          Race dwarf = AssetManager.raceLibrary.get("dwarf");
          Race elf = AssetManager.raceLibrary.get("elf");
		  }
		  ProjectileAsset Catapult = new ProjectileAsset();
          Catapult.id = "Catapult4";
          Catapult.texture = "PiedraCatapulta";
          Catapult.trailEffect_enabled = true;
          Catapult.look_at_target = true;
          Catapult.parabolic = true;
          Catapult.looped = false;
          Catapult.hitShake = false;
          Catapult.terraformOption = "CatapultPRFire";
          Catapult.terraformRange = 4;
          Catapult.startScale = 0.1f;
          Catapult.targetScale = 0.1f; 
          Catapult.speed = 10f;
          AssetManager.projectiles.add(Catapult);
		  
		  ProjectileAsset Cannnon = new ProjectileAsset();
          Cannnon.id = "Cannon4";
          Cannnon.texture = "PiedraCatapulta";
          Cannnon.trailEffect_enabled = true;
          Cannnon.look_at_target = true;
          Cannnon.parabolic = true;
          Cannnon.looped = false;
          Cannnon.hitShake = false;
          Cannnon.terraformOption = "CannnonPRFire";
          Cannnon.terraformRange = 5;
          Cannnon.startScale = 0.1f;
          Cannnon.targetScale = 0.1f; 
          Cannnon.speed = 15f;
          AssetManager.projectiles.add(Cannnon);
		  
		  ProjectileAsset Ballista = new ProjectileAsset();
          Ballista.id = "Ballista4";
          Ballista.texture = "BallistaBal";
          Ballista.trailEffect_enabled = true;
          Ballista.look_at_target = true;
          Ballista.parabolic = false;
          Ballista.looped = false;
          Ballista.hitShake = false;
          Ballista.terraformOption = "BallistaPRFire";
          Ballista.terraformRange = 1;
          Ballista.startScale = 0.1f;
          Ballista.targetScale = 0.1f; 
          Ballista.speed = 30f;
          AssetManager.projectiles.add(Ballista);
 
          ProjectileAsset BalaH4T = new ProjectileAsset();
          BalaH4T.id = "BalaH4T4";
          BalaH4T.texture = "BalaH4T";
          BalaH4T.trailEffect_enabled = true;
          BalaH4T.look_at_target = true;
          BalaH4T.parabolic = false;
          BalaH4T.looped = false;
          BalaH4T.hitShake = false;
          BalaH4T.endEffect = "fx_fireball_explosion"; 
          BalaH4T.terraformOption = "EventH4TFire";
          BalaH4T.terraformRange = 5;
          BalaH4T.startScale = 0.1f;
          BalaH4T.targetScale = 0.1f;
          BalaH4T.speed = 40f;
          BalaH4T.sound_impact = "event:/SFX/WEAPONS/WeaponPlasmaBallLand";
          AssetManager.projectiles.add(BalaH4T);
		  
		  
		  ProjectileAsset BalaH5T = new ProjectileAsset();
          BalaH5T.id = "BalaH5T4";
          BalaH5T.texture = "BalaH4T";
          BalaH5T.trailEffect_enabled = true;
          BalaH5T.look_at_target = true;
          BalaH5T.parabolic = false;
          BalaH5T.looped = false;
          BalaH5T.hitShake = false;
          BalaH5T.endEffect = "fx_fireball_explosion"; 
          BalaH5T.terraformOption = "EventH5TFire";
		  BalaH5T.sound_impact = "event:/SFX/WEAPONS/WeaponFireballLand";
          BalaH5T.terraformRange = 5;
          BalaH5T.startScale = 0.1f;
          BalaH5T.targetScale = 0.1f; 
          BalaH5T.speed = 60f;
          AssetManager.projectiles.add(BalaH5T);
		  
		  ProjectileAsset SlashOm = new ProjectileAsset();
          SlashOm.id = "SlashOm11";
          SlashOm.texture = "SlashOm1";
          SlashOm.trailEffect_enabled = true;
          SlashOm.look_at_target = true;
          SlashOm.parabolic = false;
          SlashOm.looped = false;
          SlashOm.hitShake = false;
          SlashOm.endEffect = "fx_fireball_explosion"; 
          SlashOm.terraformOption = "SlashOm1Fire";
		  SlashOm.sound_impact = "event:/SFX/WEAPONS/WeaponFireballLand";
          SlashOm.terraformRange = 5;
          SlashOm.startScale = 0.1f;
          SlashOm.targetScale = 0.1f; 
          SlashOm.speed = 60f;
          AssetManager.projectiles.add(SlashOm);
		  
		  ProjectileAsset mortarP = new ProjectileAsset();
          mortarP.id = "mortarP4";
          mortarP.texture = "trabuchetP";
          mortarP.trailEffect_enabled = true;
          mortarP.look_at_target = true;
          mortarP.parabolic = true;
          mortarP.looped = false;
          mortarP.hitShake = false;
          mortarP.endEffect = "fx_fireball_explosion"; 
          mortarP.terraformOption = "mortarPRFire";
		  mortarP.sound_impact = "event:/SFX/WEAPONS/WeaponFireballLand";
          mortarP.terraformRange = 5;
          mortarP.startScale = 0.12f;
          mortarP.targetScale = 0.12f; 
          mortarP.speed = 10f;
          AssetManager.projectiles.add(mortarP);
		  
		  ProjectileAsset trabuchetP = new ProjectileAsset();
          trabuchetP.id = "TrabuchetP4";
          trabuchetP.texture = "trabuchetP";
          trabuchetP.trailEffect_enabled = true;
          trabuchetP.look_at_target = true;
          trabuchetP.parabolic = true;
          trabuchetP.looped = false;
          trabuchetP.hitShake = false;
          trabuchetP.endEffect = "fx_fireball_explosion"; 
          trabuchetP.terraformOption = "trabuchetPRFire";
		  trabuchetP.sound_impact = "event:/SFX/WEAPONS/WeaponFireballLand";
          trabuchetP.terraformRange = 14;
          trabuchetP.startScale = 0.15f;
          trabuchetP.targetScale = 0.15f; 
          trabuchetP.speed = 20f;
          AssetManager.projectiles.add(trabuchetP);
		  
            ProjectileAsset Bala = new ProjectileAsset();
            Bala.id = "Bala";
            Bala.speed = 50f;
            Bala.parabolic = false;
            Bala.texture = "shotgun_bullet";
            Bala.sound_launch = "event:/SFX/WEAPONS/WeaponShotgunStart";
		    Bala.sound_impact = "event:/SFX/WEAPONS/WeaponShotgunLand";
            Bala.hitShake = false;
            Bala.endEffect = "fx_shotgun_bullet_explosion"; 
            Bala.terraformOption = "BalaPRFire";
            Bala.terraformRange = 1;
            Bala.startScale = 0.1f;
            Bala.targetScale = 0.1f;
            AssetManager.projectiles.add(Bala);
			
            ProjectileAsset Bala12 = new ProjectileAsset();
            Bala12.id = "Bala12";
            Bala12.speed = 180f;
            Bala12.parabolic = false;
            Bala12.texture = "shotgun_bullet";
            Bala12.sound_launch = "event:/SFX/WEAPONS/WeaponShotgunStart";
		    Bala12.sound_impact = "event:/SFX/WEAPONS/WeaponShotgunLand";
            Bala12.hitShake = false;
            Bala12.endEffect = "fx_shotgun_bullet_explosion"; 
            Bala12.terraformRange = 1;
            Bala12.startScale = 0.1f;
            Bala12.targetScale = 0.1f;
            AssetManager.projectiles.add(Bala12);
 
 
		  ProjectileAsset Obtuni04AT = new ProjectileAsset();
          Obtuni04AT.id = "Obtuni04AT4";
          Obtuni04AT.texture = "Obtuni04AT";
          Obtuni04AT.trailEffect_enabled = true;
          Obtuni04AT.look_at_target = true;
          Obtuni04AT.parabolic = false;
          Obtuni04AT.looped = false;
          Obtuni04AT.hitShake = false;
          Obtuni04AT.endEffect = "fx_fireball_explosion"; 
          Obtuni04AT.terraformOption = "Obtuni04ATRFire";
		  Obtuni04AT.sound_impact = "event:/SFX/WEAPONS/WeaponPlasmaBallLand";
          Obtuni04AT.terraformRange = 5;
          Obtuni04AT.startScale = 0.01f;
          Obtuni04AT.targetScale = 0.01f; 
          Obtuni04AT.speed = 180f;
          AssetManager.projectiles.add(Obtuni04AT);
		  
		  ProjectileAsset SharpLaser5 = new ProjectileAsset();
          SharpLaser5.id = "SharpLaser54";
          SharpLaser5.texture = "SharpLaser5";
          SharpLaser5.trailEffect_enabled = false;
          SharpLaser5.look_at_target = true;
          SharpLaser5.parabolic = false;
          SharpLaser5.looped = false;
          SharpLaser5.hitShake = false;
          SharpLaser5.endEffect = "fx_fireball_explosion"; 
          SharpLaser5.terraformOption = "SharpLaser5RFire";
		  SharpLaser5.sound_impact = "event:/SFX/WEAPONS/WeaponPlasmaBallLand";
		  SharpLaser5.sound_launch = "event:/SFX/WEAPONS/WeaponPlasmaBallStart";
          SharpLaser5.terraformRange = 0;
          SharpLaser5.startScale = 0.1f;
          SharpLaser5.targetScale = 0.1f; 
          SharpLaser5.speed = 38f;
          AssetManager.projectiles.add(SharpLaser5);
		  
		  ProjectileAsset RiflePlaster200FIRE = new ProjectileAsset();
          RiflePlaster200FIRE.id = "RiflePlaster200FIRE4";
          RiflePlaster200FIRE.texture = "RiflePlaster200FIRE";
          RiflePlaster200FIRE.trailEffect_enabled = false;
          RiflePlaster200FIRE.look_at_target = true;
          RiflePlaster200FIRE.parabolic = false;
          RiflePlaster200FIRE.looped = false;
          RiflePlaster200FIRE.hitShake = false;
          RiflePlaster200FIRE.endEffect = "fx_fireball_explosion"; 
          RiflePlaster200FIRE.terraformOption = "RiflePlaster200FIRERFire";
		  RiflePlaster200FIRE.sound_impact = "event:/SFX/WEAPONS/WeaponPlasmaBallLand";
		  RiflePlaster200FIRE.sound_launch = "event:/SFX/WEAPONS/WeaponPlasmaBallStart";
          RiflePlaster200FIRE.terraformRange = 5;
          RiflePlaster200FIRE.startScale = 0.1f;
          RiflePlaster200FIRE.targetScale = 0.1f; 
          RiflePlaster200FIRE.speed = 80f;
          AssetManager.projectiles.add(RiflePlaster200FIRE);
		  
		  ProjectileAsset LaserBlueSmall = new ProjectileAsset();
          LaserBlueSmall.id = "LaserBlueSmall4";
          LaserBlueSmall.texture = "LaserBlueSmall";
          LaserBlueSmall.trailEffect_enabled = false;
          LaserBlueSmall.look_at_target = true;
          LaserBlueSmall.parabolic = false;
          LaserBlueSmall.looped = false;
          LaserBlueSmall.hitShake = false;
		  LaserBlueSmall.sound_impact = "event:/SFX/WEAPONS/WeaponPlasmaBallLand";
		  LaserBlueSmall.sound_launch = "event:/SFX/WEAPONS/WeaponPlasmaBallStart";
          LaserBlueSmall.startScale = 0.1f;
          LaserBlueSmall.targetScale = 0.1f; 
          LaserBlueSmall.speed = 40f;
          AssetManager.projectiles.add(LaserBlueSmall);
		  
		  ProjectileAsset BlueLaser = new ProjectileAsset();
          BlueLaser.id = "BlueLaser4";
          BlueLaser.texture = "BlueLaser";
          BlueLaser.trailEffect_enabled = false;
          BlueLaser.look_at_target = true;
          BlueLaser.parabolic = false;
          BlueLaser.looped = false;
          BlueLaser.hitShake = false;
          BlueLaser.endEffect = "fx_fireball_explosion"; 
          BlueLaser.terraformOption = "BlueLaserRFire";
		  BlueLaser.sound_impact = "event:/SFX/WEAPONS/WeaponFireballLand";
		  BlueLaser.sound_launch = "event:/SFX/WEAPONS/WeaponFireballStart";
          BlueLaser.terraformRange = 5;
          BlueLaser.startScale = 0.1f;
          BlueLaser.targetScale = 0.1f; 
          BlueLaser.speed = 27f;
          AssetManager.projectiles.add(BlueLaser);
		  
		  ProjectileAsset BallLaserBlue = new ProjectileAsset();
          BallLaserBlue.id = "BallLaserBlue4";
          BallLaserBlue.texture = "BallLaserBlue";
          BallLaserBlue.trailEffect_enabled = false;
          BallLaserBlue.look_at_target = true;
          BallLaserBlue.parabolic = false;
          BallLaserBlue.looped = false;
          BallLaserBlue.hitShake = false;
          BallLaserBlue.endEffect = "fx_fireball_explosion"; 
          BallLaserBlue.terraformOption = "BallLaserBlueRFire";
		  BallLaserBlue.sound_impact = "event:/SFX/WEAPONS/WeaponPlasmaBallLand";
		  BallLaserBlue.sound_launch = "event:/SFX/WEAPONS/WeaponPlasmaBallStart";
          BallLaserBlue.terraformRange = 4;
          BallLaserBlue.startScale = 0.1f;
          BallLaserBlue.targetScale = 0.1f; 
          BallLaserBlue.speed = 20f;
          AssetManager.projectiles.add(BallLaserBlue);
		  
		  ProjectileAsset UltraProyectile = new ProjectileAsset();
          UltraProyectile.id = "UltraProyectile4";
          UltraProyectile.texture = "UltraProyectile";
          UltraProyectile.trailEffect_enabled = false;
          UltraProyectile.look_at_target = true;
          UltraProyectile.parabolic = false;
          UltraProyectile.looped = false;
		  UltraProyectile.hitFreeze = true;
          UltraProyectile.hitShake = false;
          UltraProyectile.endEffect = "fx_fireball_explosion"; 
          UltraProyectile.terraformOption = "UltraProyectileRFire";
		  UltraProyectile.sound_impact = "event:/SFX/WEAPONS/WeaponPlasmaBallLand";
		  UltraProyectile.sound_launch = "event:/SFX/WEAPONS/WeaponPlasmaBallStart";
          UltraProyectile.terraformRange = 8;
          UltraProyectile.startScale = 0.1f;
          UltraProyectile.targetScale = 0.1f; 
          UltraProyectile.speed = 30f;
          AssetManager.projectiles.add(UltraProyectile);
		  
		  
		  ProjectileAsset UltraCannonPoryectile = new ProjectileAsset();
          UltraCannonPoryectile.id = "UltraCannonPoryectile4";
          UltraCannonPoryectile.texture = "UltraCannonPoryectile";
          UltraCannonPoryectile.trailEffect_enabled = false;
          UltraCannonPoryectile.look_at_target = true;
          UltraCannonPoryectile.parabolic = true;
          UltraCannonPoryectile.looped = false;
          UltraCannonPoryectile.hitShake = false;
		  UltraCannonPoryectile.hitFreeze = true;
          UltraCannonPoryectile.endEffect = "fx_fireball_explosion"; 
          UltraCannonPoryectile.terraformOption = "UltraCannonPoryectileRFire";
		  UltraCannonPoryectile.sound_impact = "event:/SFX/WEAPONS/WeaponPlasmaBallLand";
		  UltraCannonPoryectile.sound_launch = "event:/SFX/WEAPONS/WeaponPlasmaBallStart";
          UltraCannonPoryectile.terraformRange = 16;
          UltraCannonPoryectile.startScale = 0.1f;
          UltraCannonPoryectile.targetScale = 0.1f; 
          UltraCannonPoryectile.speed = 60f;
          AssetManager.projectiles.add(UltraCannonPoryectile);
		  
		  ProjectileAsset OVArEProt = new ProjectileAsset();
          OVArEProt.id = "OVArEProt4";
          OVArEProt.texture = "UltraCannonPoryectile";
          OVArEProt.trailEffect_enabled = false;
          OVArEProt.look_at_target = true;
          OVArEProt.parabolic = false;
          OVArEProt.looped = false;
          OVArEProt.hitShake = false;
          OVArEProt.endEffect = "fx_fireball_explosion"; 
          OVArEProt.terraformOption = "CatapultPRFire";
		  OVArEProt.sound_impact = "event:/SFX/WEAPONS/WeaponPlasmaBallLand";
		  OVArEProt.sound_launch = "event:/SFX/WEAPONS/WeaponPlasmaBallStart";
          OVArEProt.terraformRange = 6;
          OVArEProt.startScale = 0.05f;
          OVArEProt.targetScale = 0.05f; 
          OVArEProt.speed = 50f;
          AssetManager.projectiles.add(OVArEProt);
		  
		  ProjectileAsset OVMbomb = new ProjectileAsset();
          OVMbomb.id = "OVMbomb4";
          OVMbomb.texture = "OVMbomb";
          OVMbomb.trailEffect_enabled = true;
          OVMbomb.look_at_target = true;
          OVMbomb.parabolic = true;
          OVMbomb.looped = false;
          OVMbomb.hitShake = false;
          OVMbomb.endEffect = "fx_fireball_explosion"; 
          OVMbomb.terraformOption = "OVMbombRFire";
		  OVMbomb.sound_impact = "event:/SFX/WEAPONS/WeaponPlasmaBallLand";
		  OVMbomb.sound_launch = "event:/SFX/WEAPONS/WeaponPlasmaBallStart";
          OVMbomb.terraformRange = 43;
          OVMbomb.startScale = 0.1f;
          OVMbomb.targetScale = 0.1f; 
          OVMbomb.speed = 3.5f;
          AssetManager.projectiles.add(OVMbomb);
		  
		  ProjectileAsset Jet01Proye = new ProjectileAsset();
          Jet01Proye.id = "Jet01Proye4";
          Jet01Proye.texture = "Jet01Proye";
          Jet01Proye.trailEffect_enabled = false;
          Jet01Proye.look_at_target = true;
          Jet01Proye.parabolic = false;
          Jet01Proye.looped = false;
          Jet01Proye.hitShake = false;
          Jet01Proye.endEffect = "fx_fireball_explosion"; 
          Jet01Proye.terraformOption = "Jet01ProyeRFire";
		  Jet01Proye.sound_launch = "event:/SFX/WEAPONS/WeaponShotgunStart";
		  Jet01Proye.sound_impact = "event:/SFX/WEAPONS/WeaponShotgunLand";
          Jet01Proye.terraformRange = 4;
          Jet01Proye.startScale = 0.1f;
          Jet01Proye.targetScale = 0.1f; 
          Jet01Proye.speed = 80f;
          AssetManager.projectiles.add(Jet01Proye);
		  
         
        }
        public static bool Jet01ProyeasaD(BaseSimObject pSelf, BaseSimObject pTarget, WorldTile pTile = null)
        {
		if(pTarget != null){
        Actor a = pSelf.a;
        if(Toolbox.randomChance(0.059988895f)){
         pSelf.CallMethod("addStatusEffect", "FuegoAzul", 15f);
		}
		 
            
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
            static void addWeaponsSprite(string id, string material)
            {
              var dictItems = Reflection.GetField(typeof(ActorAnimationLoader), null, "dictItems") as Dictionary<string, Sprite>;
              var sprite = Resources.Load<Sprite>("Weapons/w_" + id + "_" + material);
              dictItems.Add(sprite.name, sprite);
            }
        }
    }
