using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using SwagModv2.Buffs;

namespace SwagModv2.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class MalachiteLegs : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Malachite Cuisses");
            Tooltip.SetDefault("+20% movement speed, +20% melee speed.");
        }
        public override void SetDefaults()
        {
            item.defense = 24;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.rare = 9;
            item.value = Item.sellPrice(0, 50, 0, 0);
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.20f;
            player.meleeSpeed += 0.20f;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("MalachiteBar"), 20);
            r.AddTile(TileID.LunarCraftingStation);
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
