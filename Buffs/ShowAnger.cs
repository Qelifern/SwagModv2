using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Buffs
{
    public class ShowAnger : ModBuff
    {

        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            DisplayName.SetDefault("Show some rage!");
            Description.SetDefault("When this runs out it will clear Berserking, keep attacking to renew this buff");
        }

    }
}
