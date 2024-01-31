using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using CalamityLostThemesPort.Tiles.MusicBoxes;
using Terraria.ID;


namespace CalamityLostThemesPort.Items.MusicBoxes
{
	public class GolemNewBox : ModItem
	{
		public override void SetStaticDefaults()
		{
            if(CalamityLostThemesPort.instance.clamExtraMusic != null) 
            MusicLoader.AddMusicBox(Mod, CalamityLostThemesPort.instance.GetMusic("FieryFistsOfStone"), ModContent.ItemType<GolemNewBox>(), ModContent.TileType<GolemNewMusicBox>());

        }

        public override void SetDefaults(){

            Item.DefaultToPlaceableTile(ModContent.TileType<GolemNewMusicBox>(), 0);
            Item.createTile = ModContent.TileType<GolemNewMusicBox>();
            Item.width = 32;
            Item.height = 32;
            Item.sellPrice(silver:12);
            Item.rare = ItemRarityID.LightRed;
            Item.accessory = true;
            

        }

        public override void AddRecipes(){
            if(CalamityLostThemesPort.instance.clamExtraMusic != null){
                CreateRecipe()
                .AddIngredient(ItemID.LihzahrdBrick, 10)
                .AddIngredient(ItemID.IronBar, 5)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.Anvils)
                .Register();
                CreateRecipe()
                .AddIngredient(ItemID.LihzahrdBrick, 10)
                .AddIngredient(ItemID.LeadBar, 5)
                .AddIngredient(ItemID.Wood, 10)
                .AddTile(TileID.Anvils)
                .Register();
                CreateRecipe()
                .AddIngredient(ItemID.LihzahrdBrick, 10)
                .AddIngredient(ItemID.MusicBox, 1)
                .AddTile(TileID.Anvils)
                .Register();
            }
        }
			
	}
	

}