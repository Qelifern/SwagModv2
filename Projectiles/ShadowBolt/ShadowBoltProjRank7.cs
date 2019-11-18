using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;

namespace SwagModv2.Projectiles.ShadowBolt
{
    public class ShadowBoltProjRank7 : ShadowBoltProj
    {
        public override string Texture { get { return "SwagModv2/Projectiles/ShadowBolt/ShadowBoltProj"; } }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Bolt [Rank 7]");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            projectile.damage = 79;
        }
    }
}
