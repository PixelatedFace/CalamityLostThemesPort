using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using CalamityLostThemesPort.Tiles.MusicBoxes;
using Terraria.ID;


namespace CalamityLostThemesPort.Items.MusicBoxes
{
	public class MeteoriteNewBox : ModItem
	{
		public override void SetStaticDefaults()
		{
            if(CalamityLostThemesPort.instance.clamExtraMusic != null) 
            MusicLoader.AddMusicBox(Mod, CalamityLostThemesPort.instance.GetMusic("ViolenceOfSpace"), ModContent.ItemType<MeteoriteNewBox>(), ModContent.TileType<MeteoriteNewMusicBox>());

        }

        public override void SetDefaults(){

            Item.DefaultToPlaceableTile(ModContent.TileType<MeteoriteNewMusicBox>(), 0);
            Item.createTile = ModContent.TileType<MeteoriteNewMusicBox>();
            Item.width = 30;
            Item.height = 32;
            Item.sellPrice(silver:12);
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
            

        }

        public override void AddRecipes(){
            if(CalamityLostThemesPort.instance.clamExtraMusic != null){
                CreateRecipe()
                .AddIngredient(ItemID.Meteorite, 10)
                .AddIngredient(ItemID.IronBar, 5)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.Anvils)
                .Register();
                CreateRecipe()
                .AddIngredient(ItemID.Meteorite, 10)
                .AddIngredient(ItemID.LeadBar, 5)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.Anvils)
                .Register();
                CreateRecipe()
                .AddIngredient(ItemID.Meteorite, 10)
                .AddIngredient(ItemID.MusicBox, 1)
                .AddTile(TileID.Anvils)
                .Register();
            }
        }
			
	}
	

}