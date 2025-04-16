using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using ALMusic.Tiles;

namespace ALMusic.Items
{
    public class MireUBox : ModItem
	{
		public override void SetStaticDefaults()
		{
            //DisplayName.SetDefault("Mire Underground Music Box");
            //Tooltip.SetDefault(@"Plays 'The Deepest Reaches' by Charlie Debnam");
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Sounds/Music/LakeDepths"), ModContent.ItemType<MireUBox>(), ModContent.TileType<MireUBoxPlaced>());
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

		public override void SetDefaults()
		{
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<MireUBoxPlaced>();
			Item.width = 24;
			Item.height = 24;
			Item.rare = ItemRarityID.LightRed;
			Item.value = 10000;
			Item.accessory = true;
		}
		public override void AddRecipes()
		{
            Mod AL = ALMusic.Instance.AL;
            if (AL != null)
            {
                CreateRecipe()
			    .AddIngredient(ItemID.MusicBox)
			    .AddIngredient(AL.Find<ModItem>("Depthstone").Type, 30)
			    .AddTile(TileID.Sawmill)
			    .Register();
		    }
        }
    }
}
