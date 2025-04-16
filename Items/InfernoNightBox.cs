using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using ALMusic.Tiles;

namespace ALMusic.Items
{
    public class InfernoNightBox : ModItem
    {
        public override void SetStaticDefaults()
		{
            //DisplayName.SetDefault("Inferno Night Music Box");
            //Tooltip.SetDefault(@"Plays 'Burnt to Ashes' by Quicksilvur");
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Sounds/Music/DragonHoardNight"), ModContent.ItemType<InfernoNightBox>(), ModContent.TileType<InfernoNightBoxPlaced>());
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
			Item.createTile = ModContent.TileType<InfernoNightBoxPlaced>();
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
                .AddIngredient(AL.Find<ModItem>("Razewood").Type, 60)
                .AddTile(TileID.Sawmill)
                .Register();
            }
        }
    }
}
