using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace AmbientWar
{
    internal static class ActorMng
    {
        private static Color32 _skin_color_0;
        private static Color32 _skin_color_1;
        private static Color32 _skin_color_2;   
        private static Color32 _skin_color_3;      
        private static bool _drawSkinColor;

        private static Dictionary<SpecialColorCacheKey, Sprite> _specialSpriteCache = new Dictionary<SpecialColorCacheKey, Sprite>();

        public static void init()
        {
            initUnit("MiniRobotGun", 8, 2, 4, 4, 4, new int[] { 100, 100, 100, 100, 100 }); // 8 frames para caminar, 2 para nadar, 4 para idle, 4 para ataque, 4 para ataque en agua
            initUnit("RobotGun", 6, 2, 1, 2, 2, new int[] { 150, 150, 150, 100, 100 });
            initUnit("OVA", 18, 2, 1, 1, 1, new int[] { 80, 120, 200, 150, 150 });
            initUnit("RobotGun2", 8, 2, 1, 2, 2, new int[] { 120, 120, 120, 80, 80 });
            initUnit("OldTank", 2, 2, 1, 26, 26, new int[] { 110, 80, 20, 100, 100 });
            initUnit("OldTank2", 2, 2, 1, 26, 26, new int[] { 110, 80, 20, 100, 100 });
            initUnit("T100", 8, 4, 4, 3, 3, new int[] { 90, 90, 90, 70, 70 });
            initUnit("R100", 6, 2, 1, 9, 9, new int[] { 110, 110, 110, 50, 50 }); 
        }
        
        private static void initUnit(string unitName, int walkFrames, int swimFrames, int idleFrames, int attackFrames, int attackWaterFrames, int[] frameTimesMs)
        {
            var walkSprites = GetSpritePaths(unitName, "walk", walkFrames);
            var swimSprites = GetSpritePaths(unitName, "swim", swimFrames);
            var idleSprites = GetSpritePaths(unitName, "idle", idleFrames);
            var attackSprites = GetSpritePaths("AtkActors", unitName, "atk", attackFrames);
            var attackWaterSprites = GetSpritePaths("AtkActors", unitName, "atkW", attackWaterFrames);

            float[] frameTimes = frameTimesMs.Select(ms => ms / 1000f).ToArray(); 

            var asset = AssetManager.actor_library.get(unitName);
            asset.has_override_sprite = true;
            asset.get_override_sprite = (actor) => get_override_sprite(actor, walkSprites, swimSprites, idleSprites, attackSprites, attackWaterSprites, frameTimes);
        }
        
        private static string[] GetSpritePaths(string unitName, string action, int frames)
        {
            return Enumerable.Range(0, frames).Select(i => $"actors/{unitName}/{action}_{i}").ToArray();
        }
        
        private static string[] GetSpritePaths(string category, string unitName, string action, int frames)
        {
            return Enumerable.Range(0, frames).Select(i => $"{category}/{unitName}/{action}_{i}").ToArray();
        }
        
        private static Sprite get_override_sprite(Actor actor, string[] walkSprites, string[] swimSprites, string[] idleSprites, string[] attackSprites, string[] attackWaterSprites, float[] frameTimes)
        {
            actor.data.get("last_anim_frame_idx", out int lastFrame);
            actor.data.get("last_anim_state", out string lastAnimState);
            actor.data.get("last_anim_timer", out float lastAnimTimer);

            string animState = actor.isAffectedByLiquid() ? "swim" : actor.is_moving ? "walk" : "idle";

            if (Mathf.Abs(actor.attackTimer - actor.s_attackSpeed_seconds) < 0.01f)
            {
                lastFrame = 0;
                lastAnimState = "attack";
            }
            if (actor.attackTimer > 0 && lastAnimState == "attack")
            {
                animState = actor.isAffectedByLiquid() ? "attackWater" : "attack";
            }
            int animIndex = animState switch
            {
                "walk" => 0,
                "swim" => 1,
                "idle" => 2,
                "attack" => 3,
                "attackWater" => 4,
                _ => 2
            };
            float frameDuration = frameTimes[animIndex]; 
			
            lastAnimTimer += Time.deltaTime;
            if (lastAnimTimer > frameDuration)
            {
                lastAnimTimer = 0;
                lastFrame++;
            }
            actor.data.set("last_anim_timer", lastAnimTimer);

            if (actor.has_status_frozen || Config.paused || MapBox.instance.isGameplayControlsLocked())
            {
                return applySpecialColors(actor, get_single_sprite(animState == "swim" ? swimSprites[0] : animState == "walk" ? walkSprites[0] : idleSprites[0]));
            }

            string[] currentSprites = animState switch
            {
                "walk" => walkSprites,
                "swim" => swimSprites,
                "attack" => attackSprites,
                "attackWater" => attackWaterSprites,
                _ => idleSprites
            };

            lastFrame %= currentSprites.Length;
            actor.data.set("last_anim_frame_idx", lastFrame);
            actor.data.set("last_anim_state", animState);

            return applySpecialColors(actor, get_single_sprite(currentSprites[lastFrame]));
        }
        
        private static Sprite get_single_sprite(string path)
        {
            var components = path.Split('/');
            var folderPath = string.Join("/", components.Take(components.Length - 1));
            var spriteList = SpriteTextureLoader.getSpriteList(folderPath);
            return spriteList.FirstOrDefault(x => x.name == components.Last());
        }
        
        private static Sprite applySpecialColors(Actor actor, Sprite originalSprite)
        {
            if (originalSprite == null)
                return null;
            
            Texture2D originalTexture = originalSprite.texture;
            if (!originalTexture.isReadable)
            {
                Debug.LogError($"Texture {originalTexture.name} is not readable. Check import settings.");
                return originalSprite; 
            }
            int textureId = originalTexture.GetInstanceID();
            int rectHash = originalSprite.rect.GetHashCode();
            int kingdomColorHash = 0;
            ColorAsset kingdomColor = actor.kingdom?.kingdomColor;
            if (kingdomColor != null)
            {
                unchecked
                {
                    kingdomColorHash = 17;
                    kingdomColorHash = kingdomColorHash * 23 + kingdomColor.k_color_0.GetHashCode();
                    kingdomColorHash = kingdomColorHash * 23 + kingdomColor.k_color_1.GetHashCode();
                    kingdomColorHash = kingdomColorHash * 23 + kingdomColor.k_color_2.GetHashCode();
                    kingdomColorHash = kingdomColorHash * 23 + kingdomColor.k_color_3.GetHashCode();
                    kingdomColorHash = kingdomColorHash * 23 + kingdomColor.k_color_4.GetHashCode();
                    kingdomColorHash = kingdomColorHash * 23 + kingdomColor.k2_color_0.GetHashCode();
                    kingdomColorHash = kingdomColorHash * 23 + kingdomColor.k2_color_1.GetHashCode();
                    kingdomColorHash = kingdomColorHash * 23 + kingdomColor.k2_color_2.GetHashCode();
                    kingdomColorHash = kingdomColorHash * 23 + kingdomColor.k2_color_3.GetHashCode();
                    kingdomColorHash = kingdomColorHash * 23 + kingdomColor.k2_color_4.GetHashCode();
                }
            }
            int skinColorHash = 0;
            if (_drawSkinColor)
            {
                unchecked
                {
                    skinColorHash = 17;
                    skinColorHash = skinColorHash * 23 + _skin_color_0.GetHashCode();
                    skinColorHash = skinColorHash * 23 + _skin_color_1.GetHashCode();
                    skinColorHash = skinColorHash * 23 + _skin_color_2.GetHashCode();
                    skinColorHash = skinColorHash * 23 + _skin_color_3.GetHashCode();
                }
            }

            SpecialColorCacheKey cacheKey = new SpecialColorCacheKey(textureId, rectHash, kingdomColorHash, _drawSkinColor, skinColorHash);

            if (_specialSpriteCache.TryGetValue(cacheKey, out Sprite cachedSprite))
            {
                return cachedSprite;
            }
            
            Color32[] pixels = originalTexture.GetPixels32();
            
            for (int i = 0; i < pixels.Length; i++)
            {
                pixels[i] = checkSpecialColors(pixels[i], kingdomColor);
            }
            Texture2D newTexture = new Texture2D(originalTexture.width, originalTexture.height, TextureFormat.RGBA32, false)
            {
                filterMode = FilterMode.Point,
                wrapMode = TextureWrapMode.Clamp
            };
            newTexture.SetPixels32(pixels);
            newTexture.Apply();

            Sprite newSprite = Sprite.Create(newTexture, originalSprite.rect, new Vector2(0.5f, 0.5f), originalSprite.pixelsPerUnit);

            _specialSpriteCache[cacheKey] = newSprite;
            
            return newSprite;
        }
        
        public static Color32 checkSpecialColors(Color32 pColor, ColorAsset pKingdomColor, bool pCheckForLightColors = false)
        {
            if (Config.EVERYTHING_MAGIC_COLOR)
            {
                return Toolbox.EVERYTHING_MAGIC_COLOR32;
            }
            if (pCheckForLightColors && Toolbox.areColorsEqual(pColor, Toolbox.color_light))
            {
                pColor = Toolbox.color_light_replace;
                return pColor;
            }
            if (pKingdomColor != null)
            {
                if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_0))
                { pColor = pKingdomColor.k_color_0; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_1))
                { pColor = pKingdomColor.k_color_1; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_2))
                { pColor = pKingdomColor.k_color_2; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_3))
                { pColor = pKingdomColor.k_color_3; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_magenta_4))
                { pColor = pKingdomColor.k_color_4; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_0))
                { pColor = pKingdomColor.k2_color_0; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_1))
                { pColor = pKingdomColor.k2_color_1; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_2))
                { pColor = pKingdomColor.k2_color_2; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_3))
                { pColor = pKingdomColor.k2_color_3; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_teal_4))
                { pColor = pKingdomColor.k2_color_4; }
            }
            if (_drawSkinColor)
            {
                if (Toolbox.areColorsEqual(pColor, Toolbox.color_green_0))
                { pColor = _skin_color_0; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_green_1))
                { pColor = _skin_color_1; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_green_2))
                { pColor = _skin_color_2; }
                else if (Toolbox.areColorsEqual(pColor, Toolbox.color_green_3))
                { pColor = _skin_color_3; }
            }
            return pColor;
        }
        private struct SpecialColorCacheKey : IEquatable<SpecialColorCacheKey>
        {
            private int _textureId;
            private int _rectHash;
            private int _kingdomColorHash;
            private bool _drawSkinColor;
            private int _skinColorHash;
            
            public SpecialColorCacheKey(int textureId, int rectHash, int kingdomColorHash, bool drawSkinColor, int skinColorHash)
            {
                _textureId = textureId;
                _rectHash = rectHash;
                _kingdomColorHash = kingdomColorHash;
                _drawSkinColor = drawSkinColor;
                _skinColorHash = skinColorHash;
            }
            
            public bool Equals(SpecialColorCacheKey other)
            {
                return _textureId == other._textureId &&
                       _rectHash == other._rectHash &&
                       _kingdomColorHash == other._kingdomColorHash &&
                       _drawSkinColor == other._drawSkinColor &&
                       _skinColorHash == other._skinColorHash;
            }
            
            public override bool Equals(object obj)
            {
                return obj is SpecialColorCacheKey other && Equals(other);
            }
            
            public override int GetHashCode()
            {
                unchecked
                {
                    int hash = 17;
                    hash = hash * 23 + _textureId;
                    hash = hash * 23 + _rectHash;
                    hash = hash * 23 + _kingdomColorHash;
                    hash = hash * 23 + _drawSkinColor.GetHashCode();
                    hash = hash * 23 + _skinColorHash;
                    return hash;
                }
            }
        }
    }
}
