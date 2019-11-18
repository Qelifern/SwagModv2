using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SwagModv2.Items.Accessories
{
    public class SpectralMana : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.value = Item.sellPrice(0, 30, 0, 0);
            item.rare = 8;
            item.accessory = true;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spectral Mana");
            Tooltip.SetDefault("'Ectoplasmic Mana'\nSpectre Heal, +50 max mana, -15% magic damage.");
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 50;
            player.ghostHeal = true;
            player.magicDamage -= 0.15f;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.ManaCrystal, 3);
            r.AddIngredient(ItemID.Ectoplasm, 8);
            r.AddIngredient(ItemID.Bottle, 2);
            r.AddTile(TileID.LunarCraftingStation);
            r.SetResult(this);
            r.AddRecipe();
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
