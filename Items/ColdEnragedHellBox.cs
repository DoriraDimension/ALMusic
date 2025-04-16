using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using ALMusic.Tiles;

namespace ALMusic.Items
{
	public class ColdEnragedHellBox : ModItem
	{
		public override void SetStaticDefaults()
		{
			MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Sounds/Music/FrozenUnderworld2"), ModContent.ItemType<ColdEnragedHellBox>(), ModContent.TileType<ColdEnragedHellBoxPlaced>());
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
			Item.createTile = ModContent.TileType<ColdEnragedHellBoxPlaced>();
			Item.width = 32;
			Item.height = 30;
			Item.rare = ItemRarityID.LightRed;
			Item.accessory = true;
		}

        public override void AddRecipes()
        {
            Mod AL = ALMusic.Instance.AL;
			if (AL != null)
			{
                CreateRecipe()
                .AddIngredient(ItemID.MusicBox)
                .AddIngredient(AL.Find<ModItem>("AbyssalHellstone").Type, 10)
                .AddIngredient(AL.Find<ModItem>("ColdAshItem").Type, 20)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
            }
        }
    }
}