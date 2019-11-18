using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.FrostBolt
{
    public class FrostBoltRank6 : FrostBolt
    {
        public override string Texture { get { return "SwagModv2/Weapons/FrostBolt/FrostBolt"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Bolt [Rank 6]");
            Tooltip.SetDefault("Hurls a frozen ball of ice at your target.\nHas a chance to increase critical strike chance with magic by 50% on your next spell, lasts 6 seconds.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("FrostBoltProjRank6");
            item.damage = 64;
            item.mana = 14;
            item.value = Item.buyPrice(0, 15, 0, 0);
        }
    }
}
