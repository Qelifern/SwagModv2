using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;

namespace SwagModv2.Weapons.FrostBolt
{
    public class FrostBoltRank2 : FrostBolt
    {
        public override string Texture { get { return "SwagModv2/Weapons/FrostBolt/FrostBolt"; } }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Bolt [Rank 2]");
            Tooltip.SetDefault("Hurls a frozen ball of ice at your target.\nHas a chance to increase critical strike chance with magic by 50% on your next spell, lasts 6 seconds.");
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            item.shoot = mod.ProjectileType("FrostBoltProjRank2");
            item.damage = 20;
            item.mana = 3;
            item.value = Item.buyPrice(0, 1, 0, 0);
        }
    }
}
