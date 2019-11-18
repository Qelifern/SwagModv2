using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using SwagModv2.Buffs;
using SwagModv2.SwagPlayer;

namespace SwagModv2.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class BerserkingHelm : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chlorophyte Berserker Mask");
            Tooltip.SetDefault("Combine armour set to gain effect");
        }
        public override void SetDefaults()
        {
            item.defense = 12;
            item.rare = 7;
            item.width = 18;
            item.height = 18;
            item.value = 300000;
            item.maxStack = 1;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("BerserkingHelm") && body.type == ItemID.ChlorophytePlateMail && legs.type == ItemID.ChlorophyteGreaves;
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "While fighting gain Berserking, a buff that lasts for 3 minutes, when the buff ends gain Undying Rage, \na buff that increases your damage and critical strike chance moderatly for 20 seconds.\nDealing damage hastens the countdown of Berserking.\nSummons a powerful leaf crystal to shoot at nearby enemies.";

            player.AddBuff(BuffID.LeafCrystal, 18000);


            if (!player.HasBuff(mod.BuffType("ShowAnger")) && player.HasBuff(mod.BuffType("Berserking")))
            {
                player.ClearBuff(mod.BuffType("Berserking"));
            }


            if (player.HasBuff(mod.BuffType("ShowAnger")) && !player.HasBuff(mod.BuffType("Berserking")))
            {
                player.ClearBuff(mod.BuffType("ShowAnger"));
                player.AddBuff(mod.BuffType("UndyingRage"), 1200);
            }

        }
        public override void UpdateEquip(Player player)
        {

        }

        public override void ArmorSetShadows(Player player)
        {
            player.armorEffectDrawShadowSubtle = true;
        }


        public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(ItemID.ChlorophyteBar, 12);
            r.AddTile(TileID.MythrilAnvil);
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}
