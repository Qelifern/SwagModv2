using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using SwagModv2.Buffs;

namespace SwagModv2.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class SwagHelm : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swag Mask");
            Tooltip.SetDefault("'The mind of Doge echoes in your head.'\n+60% Damage, +100 Max Life, +100 Max Mana, Spectre Heal.");
        }
        public override void SetDefaults()
        {
            item.defense = 50;
            item.rare = 10;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(1, 0, 0, 0);
            item.maxStack = 1;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("SwagHelm") && body.type == mod.ItemType("SwagBody") && legs.type == mod.ItemType("SwagLegs");
        }
        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawShadowSubtle = true;
            player.armorEffectDrawOutlines = true;
            player.armorEffectDrawOutlinesForbidden = true;
            player.armorEffectDrawShadow = true;
            player.armorEffectDrawShadowBasilisk = true;
            player.armorEffectDrawShadowLokis = true;
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "'Michael Jackson's soul shrieks within you.'\n +400 Max Life, +400 Max Mana, You Move Freely In Liquids, +25% chance to not consume ammo.";
            player.statLifeMax2 += 400;
            player.statManaMax2 += 400;
            player.ignoreWater = true;
            player.AddBuff(BuffID.Shine, 1);
            player.ammoCost75 = true;
        }
        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 100;
            player.statManaMax2 += 100;
            player.ghostHeal = true;
            player.meleeDamage += 0.60f;
            player.magicDamage += 0.60f;
            player.rangedDamage += 0.60f;
            player.thrownDamage += 0.60f;
            player.arrowDamage += 0.60f;
            player.rocketDamage += 0.60f;
            player.minionDamage += 0.60f;
            player.bulletDamage += 0.60f;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("SwagiantiumBar"), 18);
            r.AddIngredient(mod.ItemType("CupriteHelm"));
            r.AddIngredient(mod.ItemType("MalachiteHelm"));
            r.AddTile(mod.TileType("TileSwagiantiumForge"));
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
