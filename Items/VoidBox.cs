using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using ALMusic.Tiles;

namespace ALMusic.Items
{
    public class VoidBox : ModItem
    {
        
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Void Music Box");
            //Tooltip.SetDefault(@"Plays 'Gaze into Darkness' by Charlie Debnam");
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Sounds/Music/VoidsEdge"), ModContent.ItemType<VoidBox>(), ModContent.TileType<VoidBoxPlaced>());
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
            Item.createTile = ModContent.TileType<VoidBoxPlaced>();
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.LightRed;
            Item.value = 10000;
            Item.accessory = true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
            .AddIngredient(ItemID.MusicBox)
            //.AddIngredient(ModContent.ItemType<DoomstonePlaced>(), 8)
            .AddTile(TileID.HeavyWorkBench)
            .Register();
        }
    }
}
