using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using SwagModv2.Buffs;

namespace SwagModv2.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MalachiteHelm : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Malachite Helmet");
            Tooltip.SetDefault("+26% Damage, +60 Max Life, +60 Max Mana, Attacks inflict poison, heal you, and you gain mana back on crits.");
        }
        public override void SetDefaults()
        {
            item.defense = 28;
            item.rare = 9;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 75, 0, 0);
            item.maxStack = 1;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("MalachiteHelm") && body.type == mod.ItemType("MalachiteBody") && legs.type == mod.ItemType("MalachiteLegs");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Spore Sac, Brain of Confusion, You Take No Fall Damage, +140 Max Life, +140 Max Mana, 25% Chance To Not Consume Ammo.";
            player.statLifeMax2 += 140;
            player.statManaMax2 += 140;
            player.AddBuff(BuffID.Shine, 1);
            player.brainOfConfusion = true;
            player.sporeSac = true;
            player.noFallDmg = true;
            player.ammoCost75 = true;
        }
        public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            target.AddBuff(BuffID.Poisoned, 1800);
            int shit = damage / Main.rand.Next(15, 20);
            player.HealEffect(shit);
            player.statLife += shit;
            if (crit)
            {
                int shit2 = damage / Main.rand.Next(5, 10);
                player.ManaEffect(shit2);
                player.statMana += shit2;
            }
        }
        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 60;
            player.statManaMax2 += 60;
            player.meleeDamage += 0.26f;
            player.magicDamage += 0.26f;
            player.rangedDamage += 0.26f;
            player.thrownDamage += 0.26f;
            player.arrowDamage += 0.26f;
            player.rocketDamage += 0.26f;
            player.minionDamage += 0.26f;
            player.bulletDamage += 0.26f;
        }
        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(mod.ItemType("MalachiteBar"), 18);
            r.AddTile(TileID.LunarCraftingStation);
            r.SetResult(this);
            r.AddRecipe();
        }
    }
}
