using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SwagModv2.Items.Accessories
{
    public class MagnificentGrapes : ModItem
    {
        public static bool accessory = false;

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 7;
            item.consumable = true;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magnificent Grapes");
            Tooltip.SetDefault("Adds an Additional Accessory slot.");
        }
        public override bool UseItem(Player player)
        {
            if (accessory == false)
            {
                player.extraAccessorySlots += 1;
                accessory = true;
            }
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe r2 = new ModRecipe(mod);
            r2.AddIngredient(ItemID.ManaCrystal, 1);
            r2.AddIngredient(ItemID.Ectoplasm, 5);
            r2.AddIngredient(ItemID.Moonglow, 5);
            r2.AddIngredient(ItemID.SoulofNight, 10);
            r2.AddTile(TileID.MythrilAnvil);
            r2.SetResult(ItemID.MoonCharm);
            r2.AddRecipe();
        }

    }
}
