using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SwagModv2.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class SwagBody : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swag Plate");
            Tooltip.SetDefault("'The power of Doge flows through your veins.'\n+500 Life, +500 Mana, +10 minions, +50 Crit, Immune to most debuffs.");
        }

        public override void SetDefaults()
        {
            item.defense = 75;
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.rare = 10;
            item.value = Item.sellPrice(1, 50, 0, 0);
        }
        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 500;
            player.statManaMax2 += 500;
            player.buffImmune[BuffID.Bleeding] = true;
            player.buffImmune[BuffID.Poisoned] = true;
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Darkness] = true;
            player.buffImmune[BuffID.Blackout] = true;
            player.buffImmune[BuffID.Silenced] = true;
            player.buffImmune[BuffID.Cursed] = true;
            player.buffImmune[BuffID.Confused] = true;
            player.buffImmune[BuffID.Slow] = true;
            player.buffImmune[BuffID.OgreSpit] = true;
            player.buffImmune[BuffID.Weak] = true;
            player.buffImmune[BuffID.BrokenArmor] = true;
            player.buffImmune[BuffID.WitheredArmor] = true;
            player.buffImmune[BuffID.WitheredWeapon] = true;
            player.buffImmune[BuffID.Horrified] = true;
            player.buffImmune[BuffID.CursedInferno] = true;
            player.buffImmune[BuffID.Ichor] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.buffImmune[BuffID.Wet] = true;
            player.buffImmune[BuffID.Webbed] = true;
            player.buffImmune[BuffID.Stoned] = true;
            player.buffImmune[BuffID.VortexDebuff] = true;
            player.buffImmune[BuffID.Obstructed] = true;
            player.buffImmune[BuffID.Electrified] = true;
            player.buffImmune[BuffID.ChaosState] = true;
            player.buffImmune[BuffID.Suffocation] = true;
            player.buffImmune[BuffID.WindPushed] = true;
            player.meleeCrit += 50;
            player.magicCrit += 50;
            player.rangedCrit += 50;
            player.thrownCrit += 50;
            player.maxMinions++;
            player.maxMinions++;
            player.maxMinions++;
            player.maxMinions++;
            player.maxMinions++;
            player.maxMinions++;
            player.maxMinions++;
            player.maxMinions++;
            player.maxMinions++;
            player.maxMinions++;
            player.noKnockback = true;
            player.noFallDmg = true;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("SwagiantiumBar"), 20);
            r.AddIngredient(mod.ItemType("CupriteBody"));
            r.AddIngredient(mod.ItemType("MalachiteBody"));
            r.AddIngredient(ItemID.AnkhShield);
            r.AddTile(mod.TileType("TileSwagiantiumForge"));
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
