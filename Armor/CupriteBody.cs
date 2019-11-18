using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SwagModv2.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class CupriteBody : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cuprite Plate");
            Tooltip.SetDefault("+250 Life, +150 Mana, +5 minions, +32 Crit, Immune To Medusa, Distorted, Chaos State and Wind.");
        }

        public override void SetDefaults()
        {
            item.defense = 40;
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.rare = 10;
            item.value = Item.sellPrice(1, 25, 0, 0);
        }
        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 250;
            player.statManaMax2 += 150;
            player.buffImmune[BuffID.Stoned] = true;
            player.buffImmune[BuffID.VortexDebuff] = true;
            player.buffImmune[BuffID.ChaosState] = true;
            player.buffImmune[BuffID.WindPushed] = true;
            player.meleeCrit += 32;
            player.magicCrit += 32;
            player.rangedCrit += 32;
            player.thrownCrit += 32;
            player.maxMinions += 5;
        }

        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("CupriteBar"), 24);
            r.AddTile(mod.TileType("TileCupriteAnvil"));
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
