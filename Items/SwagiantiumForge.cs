using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwagModv2.Items
{
    public class SwagiantiumForge : ModItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swagiantium Forge");
        }
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 34;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = Item.sellPrice(1, 0, 0, 0);
            item.createTile = mod.TileType("TileSwagiantiumForge");


        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("Swagiantium"), 30);
            r.AddIngredient(ItemID.AdamantiteForge);
            r.AddTile(mod.TileType("TileCupriteAnvil"));
            r.SetResult(this);
            r.AddRecipe();
            ModRecipe r2 = new ModRecipe(mod);
            r2.AddIngredient(mod.ItemType("Swagiantium"), 30);
            r2.AddIngredient(ItemID.TitaniumForge);
            r2.AddTile(mod.TileType("TileCupriteAnvil"));
            r2.SetResult(this);
            r2.AddRecipe();
        }

    }
}
