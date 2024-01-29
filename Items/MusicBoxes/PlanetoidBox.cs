using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using CalamityLostThemesPort.Tiles.MusicBoxes;
using Terraria.ID;


namespace CalamityLostThemesPort.Items.MusicBoxes
{
	public class PlanetoidBox : ModItem
	{
		public override void SetStaticDefaults()
		{
            
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Sounds/Music/Planetoids"), ModContent.ItemType<PlanetoidBox>(), ModContent.TileType<PlanetoidMusicBox>());

        }

        public override void SetDefaults(){

            Item.DefaultToPlaceableTile(ModContent.TileType<PlanetoidMusicBox>(), 0);
            Item.createTile = ModContent.TileType<PlanetoidMusicBox>();
            Item.width = 32;
            Item.height = 32;
            Item.sellPrice(silver:12);
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;

        }

        public override void AddRecipes(){
            CreateRecipe()
            .AddIngredient(ItemID.DirtBlock, 10)
            .AddIngredient(ItemID.IronBar, 5)
            .AddIngredient(ItemID.Wood, 10)
            .AddTile(TileID.Anvils)
            .Register();
            CreateRecipe()
            .AddIngredient(ItemID.DirtBlock, 10)
            .AddIngredient(ItemID.LeadBar, 5)
            .AddIngredient(ItemID.Wood, 10)
            .AddTile(TileID.Anvils)
            .Register();
            CreateRecipe()
            .AddIngredient(ItemID.DirtBlock, 10)
            .AddIngredient(ItemID.MusicBox, 1)
            .AddTile(TileID.Anvils)
            .Register();
        }
			
	}
	

}