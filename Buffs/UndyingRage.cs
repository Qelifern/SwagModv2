using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Buffs
{
    public class UndyingRage : ModBuff
    {

        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            DisplayName.SetDefault("Undying Rage");
            Description.SetDefault("+40% increased damage, +20% increased critical strike chance");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 0.40f;
            player.magicDamage += 0.40f;
            player.rangedDamage += 0.40f;
            player.thrownDamage += 0.40f;
            player.meleeCrit += 20;
            player.magicCrit += 20;
            player.rangedCrit += 20;
            player.thrownCrit += 20;

            for (int i = 0; i < 6; i++)
            {
                int num30 = Dust.NewDust(player.position, player.width, player.height, DustID.PinkCrystalShard, 0f, 0f, 255, new Color(200, 0, 0), 2f);
                Dust dust3 = Main.dust[num30];
                Main.dust[num30].noGravity = false;
            }
        }

    }
}
