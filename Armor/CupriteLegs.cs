using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using SwagModv2.Buffs;

namespace SwagModv2.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class CupriteLegs : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cuprite Greaves");
            Tooltip.SetDefault("+28% Movement Speed, +24% Melee Speed, You Take No Fall Damage.");
        }
        public override void SetDefaults()
        {
            item.defense = 36;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.rare = 10;
            item.value = Item.sellPrice(0, 50, 0, 0);
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.28f;
            player.meleeSpeed += 0.24f;
            player.noFallDmg = true;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("CupriteBar"), 20);
            r.AddTile(mod.TileType("TileCupriteAnvil"));
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
