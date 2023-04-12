using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.DataStructures;
using CalamityLostThemesPort.Items.MusicBoxes;

namespace CalamityLostThemesPort.Tiles.MusicBoxes
{
	class PlanetoidMusicBox : ModTile
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

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Music Box");
			AddMapEntry(new Color(89, 59, 178), name);
		
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY){
			Item.NewItem(new EntitySource_TileBreak(i, j), i * 16, j * 16, 32, 32, ModContent.ItemType<PlanetoidBox>());
		}


		public override void MouseOver(int i, int j){
			Player player = Main.LocalPlayer;
			player.noThrow = 2;
			player.cursorItemIconEnabled = true;
			player.cursorItemIconID = ModContent.ItemType<PlanetoidBox>();
			
		}

	}
	

}