using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SwagModv2.Items
{
    class LifeFruitFragment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life Fruit Fragment");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.value = Item.sellPrice(0, 0, 40, 0);
            item.rare = 7;
            item.maxStack = 99;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("LifeFruitFragment"), 10);
            r.AddTile(TileID.MythrilAnvil);
            r.SetResult(ItemID.LifeFruit, 1);
            r.AddRecipe();
        }

    }
}
