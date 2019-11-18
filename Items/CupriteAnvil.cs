using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SwagModv2.Items
{
    public class CupriteAnvil : ModItem
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cuprite Anvil");
        }
        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 18;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.createTile = mod.TileType("TileCupriteAnvil");


        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("CupriteBar"), 12);
            r.AddTile(TileID.LunarCraftingStation);
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
