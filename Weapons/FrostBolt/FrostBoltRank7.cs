using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.FrostBolt
{
    public class FrostBoltRank7 : FrostBolt
    {
        public override string Texture { get { return "SwagModv2/Weapons/FrostBolt/FrostBolt"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Bolt [Rank 7]");
            Tooltip.SetDefault("Hurls a frozen ball of ice at your target.\nHas a chance to increase critical strike chance with magic by 50% on your next spell, lasts 6 seconds.");

        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("FrostBoltProjRank7");
            item.damage = 70;
            item.mana = 19;
            item.useTime = 15;
            item.useAnimation = 15;
            item.value = Item.buyPrice(0, 20, 0, 0);
        }
    }
}
