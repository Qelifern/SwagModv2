using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using SwagModv2.Buffs;

namespace SwagModv2.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class SwagLegs : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swag Greaves");
            Tooltip.SetDefault("'The speed of Doge lingers inside you.'\nMove like Michael Jackson.");
        }
        public override void SetDefaults()
        {
            item.defense = 55;
            item.maxStack = 1;
            item.width = 20;
            item.height = 20;
            item.rare = 10;
            item.value = Item.sellPrice(1, 25, 0, 0);
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed = player.moveSpeed + 0.8f;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("SwagiantiumBar"), 20);
            r.AddIngredient(mod.ItemType("CupriteLegs"));
            r.AddIngredient(mod.ItemType("MalachiteLegs"));
            r.AddTile(mod.TileType("TileSwagiantiumForge"));
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
