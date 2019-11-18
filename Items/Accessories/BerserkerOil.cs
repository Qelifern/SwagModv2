using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SwagModv2.Items.Accessories
{
    public class BerserkerOil : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.value = Item.sellPrice(0, 30, 0, 0);
            item.rare = 8;
            item.accessory = true;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Berserker Oil");
            Tooltip.SetDefault("Dropped by 'Hell Armored Bones'. \nWhile fighting gain Berserking, a buff that lasts for 3 minutes, when the buff ends gain Undying Rage, \na buff that increases your damage and critical strike chance moderatly for 20 seconds.\nDealing damage hastens the countdown of Berserking.");
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {

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
    }
}
