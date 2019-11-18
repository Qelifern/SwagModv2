using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using SwagModv2.Buffs;

namespace SwagModv2.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class CupriteHelm : ModItem
    {
        public bool lifeline = true;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cuprite Mask");
            Tooltip.SetDefault("+34% Damage, +80 Max Life, +80 Max Mana");
        }
        public override void SetDefaults()
        {
            item.defense = 34;
            item.rare = 10;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 75, 0, 0);
            item.maxStack = 1;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("CupriteHelm") && body.type == mod.ItemType("CupriteBody") && legs.type == mod.ItemType("CupriteLegs");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+150 Max Life, +100 Max Mana, You Move Freely In Liquids, +25% chance to not consume ammo.";
            player.statLifeMax2 += 150;
            player.statManaMax2 += 100;
            player.ignoreWater = true;
            player.AddBuff(BuffID.Shine, 1);
            player.ammoCost75 = true;
        }
        public override void ArmorSetShadows(Player player)
        {
            player.shadow = 50.0f;
            player.setSolar = true;

        }
        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 80;
            player.statManaMax2 += 80;
            player.meleeDamage += 0.34f;
            player.magicDamage += 0.34f;
            player.rangedDamage += 0.34f;
            player.thrownDamage += 0.34f;
            player.arrowDamage += 0.34f;
            player.rocketDamage += 0.34f;
            player.minionDamage += 0.34f;
            player.bulletDamage += 0.34f;
        }
        public override bool ConsumeAmmo(Player player)
        {
            int shit = Main.rand.Next(9);
            if (shit == 0 || shit == 1 || shit == 2 || shit == 3 || shit == 4)
            {
                return false;
            }
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("CupriteBar"), 18);
            r.AddTile(mod.TileType("TileCupriteAnvil"));
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
