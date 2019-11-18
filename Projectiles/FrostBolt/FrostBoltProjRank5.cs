using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using SwagModv2.Weapons;

namespace SwagModv2.Projectiles.FrostBolt
{
    public class FrostBoltProjRank5 : FrostBoltProj
    {
        public override string Texture { get { return "SwagModv2/Projectiles/FrostBolt/FrostBoltProj"; } }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Bolt [Rank 5]");
        }
        public override void SetDefaults()
        {
            base.SetDefaults();
            projectile.damage = 48;



        }
    }
}
