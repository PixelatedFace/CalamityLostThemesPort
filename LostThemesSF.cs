using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ID;

namespace CalamityLostThemesPort
{
	class LostThemesSF : ModSceneEffect
	{
		public override SceneEffectPriority Priority => CalamityLostThemesConfig.Instance.planetoidPriorirty;
        public override bool IsSceneEffectActive(Player player){

            return (Main.LocalPlayer.position.Y / 16 <= Main.worldSurface * 0.35) &&
            (Main.SceneMetrics.GetTileCount(TileID.Dirt)>20 || 
            Main.SceneMetrics.GetTileCount(TileID.Stone)>20 ||
             Main.SceneMetrics.GetTileCount(TileID.Mud)>20) && 
             (Main.SceneMetrics.GetTileCount(TileID.Cloud)<2);

        }
        public override int Music{
            get{
                return MusicLoader.GetMusicSlot(Mod, "Sounds/Music/Planetoids");
            }
        }
	}
	

}