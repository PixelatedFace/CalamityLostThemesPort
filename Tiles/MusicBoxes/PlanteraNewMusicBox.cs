using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using CalamityLostThemesPort.Items.MusicBoxes;
using Terraria.Localization;

namespace CalamityLostThemesPort.Tiles.MusicBoxes
{
	class PlanteraNewMusicBox : ModTile
	{
		public override void SetStaticDefaults()
		{
			
			Main.tileFrameImportant[Type] = true;
			Main.tileObsidianKill[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.Origin = new Point16(0, 1);
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.newTile.DrawYOffset = 2;
			TileObjectData.addTile(Type);

			LocalizedText name = CreateMapEntryName();

			AddMapEntry(new Color(89, 59, 178), name);
		
		}

		


		public override void MouseOver(int i, int j){
			Player player = Main.LocalPlayer;
			player.noThrow = 2;
			player.cursorItemIconEnabled = true;
			player.cursorItemIconID = ModContent.ItemType<PlanteraNewBox>();
			
		}

	}
	

}