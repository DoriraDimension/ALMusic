using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using ALMusic.Tiles;

namespace ALMusic.Items
{
    public class ShroomForestNightBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Sounds/Music/ShroomNight"), ModContent.ItemType<ShroomForestNightBox>(), ModContent.TileType<ShroomForestBoxNightPlaced>());
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
            Item.createTile = ModContent.TileType<ShroomForestBoxNightPlaced>();
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
                .AddIngredient(AL.Find<ModItem>("MyceliumSeeds").Type, 10)
                .AddIngredient(ItemID.Mushroom, 50)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
            }
        }
    }
}