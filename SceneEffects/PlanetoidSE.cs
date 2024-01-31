using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ID;

namespace CalamityLostThemesPort.SceneEffects
{
	class PlanetoidSE : ModSceneEffect
	{
		public override SceneEffectPriority Priority => ModContent.GetInstance<CalamityLostThemesConfig>().planetoidPriority;
        readonly bool changeTheme = ModContent.GetInstance<CalamityLostThemesConfig>().planetoidThemeChange;

        public override bool IsSceneEffectActive(Player player){
            
            if(changeTheme){
                if(Main.LocalPlayer.ZoneSkyHeight){
                    if(Main.SceneMetrics.GetTileCount(TileID.Cloud) < 2){
                        if(Main.SceneMetrics.GetTileCount(TileID.Dirt) > 20 ||
                        Main.SceneMetrics.GetTileCount(TileID.Stone) > 20 ||
                        Main.SceneMetrics.GetTileCount(TileID.Mud) > 20) return true;
                    }
                    
                }
            }
            return false;

        }
        public override int Music{
            get{
                return MusicLoader.GetMusicSlot(Mod, "Sounds/Music/Planetoids");
            }
        }
	}
	

}