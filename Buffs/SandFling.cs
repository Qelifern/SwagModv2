using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Buffs
{
    public class SandFling : ModBuff
    {

        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            DisplayName.SetDefault("Sandstorm!");
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            int num30 = Dust.NewDust(npc.position, npc.width, npc.height, DustID.Sandnado, 0f, 0f, 255, new Color(0, 0, 0), 2f);
            Dust dust3 = Main.dust[num30];
            dust3.velocity *= 0.1f;
            Main.dust[num30].noGravity = true;
        }

    }
}
