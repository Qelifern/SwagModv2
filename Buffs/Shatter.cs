using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SwagModv2.Armor;

namespace SwagModv2.Buffs
{
    public class Shatter : ModBuff
    {

        public override void SetDefaults()
        {
            Main.buffNoTimeDisplay[Type] = false;
            DisplayName.SetDefault("Shatter");
            Description.SetDefault("Next Spell has Magic critical strike chance increased by 50%");
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.magicCrit += 50;
        }
    }
}
