using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using ALMusic.Tiles;
using System;

namespace ALMusic.Items
{
    public class ScrapBox : ModItem
    {

        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Void Music Box");
            //Tooltip.SetDefault(@"Plays 'Gaze into Darkness' by Charlie Debnam");
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Sounds/Music/Scrapyard"), ModContent.ItemType<ScrapBox>(), ModContent.TileType<ScrapBoxPlaced>());
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
            Item.createTile = ModContent.TileType<ScrapBoxPlaced>();
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
                //.AddIngredient(AL.Find<ModItem>("DoomiteScrap").Type, 20)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
            }
        }
    }
}