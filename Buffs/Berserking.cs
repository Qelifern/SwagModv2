using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Buffs
{
    public class Berserking : ModBuff
    {

        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
            DisplayName.SetDefault("Berserking");
            Description.SetDefault("When this buff runs out gain Undying Rage");
        }

    }
}
