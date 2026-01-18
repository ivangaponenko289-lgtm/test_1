using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using ReflectionUtility;
using System.Reflection;
using HarmonyLib;
using Newtonsoft.Json;
using static Config;
 
namespace AmbientWar
{
    class EVFires
    {
        public static void init()
        {
            TerraformOptions EventH4TFire = new TerraformOptions();
            EventH4TFire.id = "EventH4TFire";
            EventH4TFire.flash = true;
            EventH4TFire.damageBuildings = true;
            EventH4TFire.damage = 80;
            EventH4TFire.applyForce = false;
            EventH4TFire.explode_and_set_random_fire = true;
            EventH4TFire.explode_tile = true;
            EventH4TFire.explosion_pixel_effect = false;
            EventH4TFire.explode_strength = 1;
            EventH4TFire.shake = false;
            EventH4TFire.removeTornado = true;
            AssetManager.terraform.add(EventH4TFire);
			
			TerraformOptions BallistaPRFire = new TerraformOptions();
            BallistaPRFire.id = "BallistaPRFire";
            BallistaPRFire.flash = false;
            BallistaPRFire.damageBuildings = true;
            BallistaPRFire.damage = 90;
            BallistaPRFire.applyForce = false;
            BallistaPRFire.explode_tile = false;
            BallistaPRFire.explosion_pixel_effect = false;
            BallistaPRFire.explode_strength = 1;
            BallistaPRFire.shake = false;
            BallistaPRFire.removeTornado = true;
            AssetManager.terraform.add(BallistaPRFire);
			
			TerraformOptions CannnonPRFire = new TerraformOptions();
            CannnonPRFire.id = "CannnonPRFire";
            CannnonPRFire.flash = false;
            CannnonPRFire.damageBuildings = true;
            CannnonPRFire.damage = 50;
            CannnonPRFire.applyForce = false;
            CannnonPRFire.explode_tile = true;
            CannnonPRFire.explosion_pixel_effect = true;
            CannnonPRFire.explode_strength = 1;
            CannnonPRFire.shake = false;
            CannnonPRFire.removeTornado = true;
            AssetManager.terraform.add(CannnonPRFire);
			
            TerraformOptions BalaPRFire = new TerraformOptions();
            BalaPRFire.id = "BalaPRFire";
            BalaPRFire.flash = false;
            BalaPRFire.damageBuildings = true;
            BalaPRFire.damage = 70;
            BalaPRFire.applyForce = false;
            BalaPRFire.explode_tile = true;
            BalaPRFire.explosion_pixel_effect = true;
            BalaPRFire.explode_strength = 1;
            BalaPRFire.shake = false;
            BalaPRFire.removeTornado = true;
            AssetManager.terraform.add(BalaPRFire);
			
			TerraformOptions mortarPRFire = new TerraformOptions();
            mortarPRFire.id = "mortarPRFire";
            mortarPRFire.flash = false;
            mortarPRFire.damageBuildings = true;
            mortarPRFire.damage = 52;
            mortarPRFire.applyForce = false;
            mortarPRFire.explode_tile = true;
            mortarPRFire.explosion_pixel_effect = true;
            mortarPRFire.explode_strength = 1;
            mortarPRFire.shake = false;
            mortarPRFire.removeTornado = true;
            AssetManager.terraform.add(mortarPRFire);
			
			TerraformOptions trabuchetPRFire = new TerraformOptions();
            trabuchetPRFire.id = "trabuchetPRFire";
            trabuchetPRFire.flash = false;
            trabuchetPRFire.damageBuildings = true;
            trabuchetPRFire.damage = 50;
            trabuchetPRFire.applyForce = false;
            trabuchetPRFire.explode_tile = true;
            trabuchetPRFire.explosion_pixel_effect = true;
            trabuchetPRFire.explode_strength = 1;
            trabuchetPRFire.shake = false;
            trabuchetPRFire.removeTornado = true;
            AssetManager.terraform.add(trabuchetPRFire);
			
            TerraformOptions EventH5TFire = new TerraformOptions();
            EventH5TFire.id = "EventH5TFire";
            EventH5TFire.flash = true;
            EventH5TFire.damageBuildings = true;
            EventH5TFire.damage = 90;
            EventH5TFire.applyForce = false;
            EventH5TFire.explode_and_set_random_fire = true;
            EventH5TFire.explode_tile = true;
            EventH5TFire.explosion_pixel_effect = false;
            EventH5TFire.explode_strength = 1;
            EventH5TFire.shake = false;
            EventH5TFire.removeTornado = true;
            AssetManager.terraform.add(EventH5TFire);
			
			TerraformOptions CatapultPRFire = new TerraformOptions();
            CatapultPRFire.id = "CatapultPRFire";
            CatapultPRFire.flash = true;
            CatapultPRFire.damageBuildings = true;
            CatapultPRFire.damage = 40;
            CatapultPRFire.applyForce = false;
            CatapultPRFire.explode_and_set_random_fire = false;
            CatapultPRFire.explode_tile = true;
            CatapultPRFire.explosion_pixel_effect = true;
            CatapultPRFire.explode_strength = 1;
            CatapultPRFire.shake = false;
            CatapultPRFire.removeTornado = true;
            AssetManager.terraform.add(CatapultPRFire);
			
			TerraformOptions SlashOm1Fire = new TerraformOptions();
            SlashOm1Fire.id = "SlashOm1Fire";
            SlashOm1Fire.flash = true;
            SlashOm1Fire.damageBuildings = true;
            SlashOm1Fire.damage = 30;
            SlashOm1Fire.applyForce = false;
			SlashOm1Fire.addBurned = true;
			SlashOm1Fire.addTrait = "MaldiR";
            SlashOm1Fire.explode_and_set_random_fire = true;
            SlashOm1Fire.explode_tile = true;
            SlashOm1Fire.explosion_pixel_effect = false;
            SlashOm1Fire.explode_strength = 1;
            SlashOm1Fire.shake = false;
            SlashOm1Fire.removeTornado = true;
            AssetManager.terraform.add(SlashOm1Fire);
			
			TerraformOptions Obtuni04ATRFire = new TerraformOptions();
            Obtuni04ATRFire.id = "Obtuni04ATRFire";
            Obtuni04ATRFire.flash = false;
            Obtuni04ATRFire.damageBuildings = true;
            Obtuni04ATRFire.damage = 310;
            Obtuni04ATRFire.applyForce = false;
            Obtuni04ATRFire.explode_and_set_random_fire = true;
            Obtuni04ATRFire.explode_tile = true;
            Obtuni04ATRFire.explosion_pixel_effect = true;
            Obtuni04ATRFire.explode_strength = 1;
            Obtuni04ATRFire.shake = false;
            Obtuni04ATRFire.removeTornado = true;
            AssetManager.terraform.add(Obtuni04ATRFire);
			
			TerraformOptions BallLaserBlueRFire = new TerraformOptions();
            BallLaserBlueRFire.id = "BallLaserBlueRFire";
            BallLaserBlueRFire.flash = false;
            BallLaserBlueRFire.damageBuildings = true;
            BallLaserBlueRFire.damage = 390;
            BallLaserBlueRFire.applyForce = false;
            BallLaserBlueRFire.explode_and_set_random_fire = false;
            BallLaserBlueRFire.explode_tile = true;
            BallLaserBlueRFire.explosion_pixel_effect = true;
            BallLaserBlueRFire.explode_strength = 1;
            BallLaserBlueRFire.shake = false;
            BallLaserBlueRFire.removeTornado = true;
            AssetManager.terraform.add(BallLaserBlueRFire);
			
			TerraformOptions BlueLaserRFire = new TerraformOptions(); 
            BlueLaserRFire.id = "BlueLaserRFire";
            BlueLaserRFire.flash = false;
            BlueLaserRFire.damageBuildings = true;
            BlueLaserRFire.damage = 500;
            BlueLaserRFire.applyForce = true;
			BlueLaserRFire.addTrait = "Traumado";
            BlueLaserRFire.explode_and_set_random_fire = false;
            BlueLaserRFire.explode_tile = false;
            BlueLaserRFire.explosion_pixel_effect = true;
            BlueLaserRFire.explode_strength = 1;
            BlueLaserRFire.shake = false;
            BlueLaserRFire.removeTornado = false;
            AssetManager.terraform.add(BlueLaserRFire);
			
			TerraformOptions SharpLaser5RFire = new TerraformOptions(); 
            SharpLaser5RFire.id = "SharpLaser5RFire";
            SharpLaser5RFire.flash = false;
            SharpLaser5RFire.damageBuildings = true;
            SharpLaser5RFire.damage = 1200;
            SharpLaser5RFire.applyForce = false;
            SharpLaser5RFire.explode_and_set_random_fire = false;
            SharpLaser5RFire.explode_tile = true;
            SharpLaser5RFire.explosion_pixel_effect = true;
            SharpLaser5RFire.explode_strength = 1;
            SharpLaser5RFire.shake = false;
            SharpLaser5RFire.removeTornado = true;
            AssetManager.terraform.add(SharpLaser5RFire);
			
			TerraformOptions RiflePlaster200FIRERFire = new TerraformOptions(); 
            RiflePlaster200FIRERFire.id = "RiflePlaster200FIRERFire";
            RiflePlaster200FIRERFire.flash = false;
            RiflePlaster200FIRERFire.damageBuildings = true;
            RiflePlaster200FIRERFire.damage = 1200;
            RiflePlaster200FIRERFire.applyForce = false;
            RiflePlaster200FIRERFire.explode_and_set_random_fire = false;
            RiflePlaster200FIRERFire.explode_tile = false;
            RiflePlaster200FIRERFire.explosion_pixel_effect = true;
            RiflePlaster200FIRERFire.explode_strength = 1;
            RiflePlaster200FIRERFire.shake = false;
            RiflePlaster200FIRERFire.removeTornado = true;
            AssetManager.terraform.add(RiflePlaster200FIRERFire);
			
			TerraformOptions Jet01ProyeRFire = new TerraformOptions(); 
            Jet01ProyeRFire.id = "Jet01ProyeRFire";
            Jet01ProyeRFire.flash = false;
            Jet01ProyeRFire.damageBuildings = true;
            Jet01ProyeRFire.damage = 1200;
            Jet01ProyeRFire.applyForce = false;
            Jet01ProyeRFire.explode_and_set_random_fire = true;
            Jet01ProyeRFire.explode_tile = true;
            Jet01ProyeRFire.explosion_pixel_effect = true;
            Jet01ProyeRFire.explode_strength = 1;
            Jet01ProyeRFire.shake = false;
            Jet01ProyeRFire.removeTornado = true;
            AssetManager.terraform.add(Jet01ProyeRFire);
			
			TerraformOptions UltraCannonPoryectileRFire = new TerraformOptions(); 
            UltraCannonPoryectileRFire.id = "UltraCannonPoryectileRFire";
            UltraCannonPoryectileRFire.flash = true;
            UltraCannonPoryectileRFire.damageBuildings = true;
            UltraCannonPoryectileRFire.damage = 1900;
            UltraCannonPoryectileRFire.applyForce = false;
			UltraCannonPoryectileRFire.addTrait = "Traumado";
            UltraCannonPoryectileRFire.explode_and_set_random_fire = true;
            UltraCannonPoryectileRFire.explode_tile = true;
            UltraCannonPoryectileRFire.explosion_pixel_effect = true;
            UltraCannonPoryectileRFire.explode_strength = 1;
            UltraCannonPoryectileRFire.shake = false;
            UltraCannonPoryectileRFire.removeTornado = true;
            AssetManager.terraform.add(UltraCannonPoryectileRFire);
			
			
            TerraformOptions OVMbombRFire = new TerraformOptions(); 
            OVMbombRFire.id = "OVMbombRFire";
            OVMbombRFire.flash = true;
            OVMbombRFire.damageBuildings = true;
            OVMbombRFire.damage = 80000;
            OVMbombRFire.applyForce = true;
            OVMbombRFire.explode_and_set_random_fire = true;
			OVMbombRFire.addTrait = "Traumado";
            OVMbombRFire.explode_tile = true;
            OVMbombRFire.explosion_pixel_effect = true;
            OVMbombRFire.explode_strength = 1;
            OVMbombRFire.shake = true;
            OVMbombRFire.removeRuins = true;
            OVMbombRFire.removeTornado = false;
            AssetManager.terraform.add(OVMbombRFire);
			
            TerraformOptions UltraProyectileRFire = new TerraformOptions(); 
            UltraProyectileRFire.id = "UltraProyectileRFire";
            UltraProyectileRFire.flash = false;
            UltraProyectileRFire.damageBuildings = true;
            UltraProyectileRFire.damage = 60000;
            UltraProyectileRFire.applyForce = false;
            UltraProyectileRFire.explode_and_set_random_fire = true;
            UltraProyectileRFire.explode_tile = true;
            UltraProyectileRFire.explosion_pixel_effect = true;
			UltraProyectileRFire.addTrait = "Traumado";
            UltraProyectileRFire.explode_strength = 1;
            UltraProyectileRFire.shake = false;
            UltraProyectileRFire.removeRuins = true;
            UltraProyectileRFire.removeTornado = false;
            AssetManager.terraform.add(UltraProyectileRFire);
		}
    }
}

