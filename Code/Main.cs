using NeoModLoader.api;
using System;
using NCMS;
using NCMS.Utils;
using UnityEngine;
using ReflectionUtility;
using HarmonyLib;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmbientWar;
using static Config;
using System.Reflection;
using UnityEngine.Tilemaps;
using System.IO;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http;

namespace AmbientWar
{
    [ModEntry]
    class Main : BasicMod<Main>
    {
        #region
        public static Main instance;
        #endregion
        internal static Harmony harmony;
		private static string VER = "10.4.0"; 

        
        public Construcciones Construcciones = new Construcciones();
		public RGN RGN = new RGN();
        public Units Units = new Units();
        public ConstruccionesDef ConstruccionesDef = new ConstruccionesDef();
		public Traits Traits = new Traits();
		public ConstruccionesUP ConstruccionesUP = new ConstruccionesUP();

        protected override void OnModLoad()
        {
            Nombresxd.init();
            TraitGroups.init();
            Traits.init();
            Items.init();
            Tech.init();
            Effects.init();
            EVFires.init();
            attacks.init();
            proyectiles.init();
			ItemAArmor.init();
			ItemAAccssesory.init();
			ItemAWeapon.init();
		    RGN.init();
			ConstruccionesUP.init();
           // AmbientWarKingdoms.init();
            Units.init();
            Construcciones.init();
            ResourcesNew.init();
            ConstruccionesDef.init();
            UnitsSiege.init();
			ActorMng.init();
        }
    }
}
