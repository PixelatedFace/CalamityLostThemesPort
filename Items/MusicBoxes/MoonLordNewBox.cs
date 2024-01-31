using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using CalamityLostThemesPort.Tiles.MusicBoxes;
using Terraria.ID;


namespace CalamityLostThemesPort.Items.MusicBoxes
{
	public class MoonLordNewBox : ModItem
	{
		public override void SetStaticDefaults()
		{
            if(CalamityLostThemesPort.instance.clamExtraMusic != null)  
            MusicLoader.AddMusicBox(Mod, CalamityLostThemesPort.instance.GetMusic("Omnipotence"), ModContent.ItemType<MoonLordNewBox>(), ModContent.TileType<MoonLordNewMusicBox>());

        }

        public override void SetDefaults(){

            Item.DefaultToPlaceableTile(ModContent.TileType<MoonLordNewMusicBox>(), 0);
            Item.createTile = ModContent.TileType<MoonLordNewMusicBox>();
            Item.width = 32;
            Item.height = 32;
            Item.sellPrice(silver:12);
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
            

        }


        public override void AddRecipes(){
            if(CalamityLostThemesPort.instance.clamExtraMusic != null){
                CreateRecipe()
                .AddIngredient(ItemID.LunarOre, 10)
                .AddIngredient(ItemID.IronBar, 5)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.Anvils)
                .Register();
                CreateRecipe()
                .AddIngredient(ItemID.LunarOre, 10)
                .AddIngredient(ItemID.LeadBar, 5)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.Anvils)
                .Register();
                CreateRecipe()
                .AddIngredient(ItemID.LunarOre, 10)
                .AddIngredient(ItemID.MusicBox, 1)
                .AddTile(TileID.Anvils)
                .Register();
            }
        }
			
	}
	

}