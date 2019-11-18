using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SwagModv2.Armor;

namespace SwagModv2.Buffs
{
    public class SwagArmorDebuff : ModBuff
    {

        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
            DisplayName.SetDefault("Swag Armor");
            Description.SetDefault("You Recently benefited from Michael Jacksons revive.");
        }

    }
}
