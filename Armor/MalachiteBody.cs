using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SwagModv2.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class MalachiteBody : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Malachite Chestplate");
            Tooltip.SetDefault("+200 Max Life, +200 Max Mana, +3 Minions, +23% Crit.");
        }

        public override void SetDefaults()
        {
            item.defense = 38;
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.rare = 9;
            item.value = Item.sellPrice(1, 0, 0, 0);
        }
        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 200;
            player.statManaMax2 += 200;
            player.meleeCrit += 23;
            player.magicCrit += 23;
            player.rangedCrit += 23;
            player.thrownCrit += 23;
            player.maxMinions++;
            player.maxMinions++;
            player.maxMinions++;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("MalachiteBar"), 24);
            r.AddTile(TileID.LunarCraftingStation);
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
